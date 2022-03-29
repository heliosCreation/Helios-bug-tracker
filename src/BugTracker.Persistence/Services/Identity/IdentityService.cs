using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Model.Identity.Authentication;
using BugTracker.Application.Model.Identity.ConfirmationAndReset;
using BugTracker.Application.Model.Identity.Registration;
using BugTracker.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Services.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public IdentityService(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }


        public async Task<IdentityResult> Register(RegistrationModel model)
        {
            var user = new ApplicationUser
            {
                UserName = $"{model.FirstName} {model.LastName}",
                NormalizedUserName = model.Email.ToUpper(),
                Email = model.Email,
                NormalizedEmail = model.Email.ToUpper(),
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = false,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };

            return await _userManager.CreateAsync(user, model.Password);

        }
        public async Task<string> GenerateRegistrationEncodedToken(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            return WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
        }
        public async Task<IdentityResult> ConfirmEmail(string uid, string token)
        {
            token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token));
            return await _userManager.ConfirmEmailAsync(await _userManager.FindByIdAsync(uid), token);
        }
        public async Task<SignInResult> AuthenticateAsync(AuthenticationModel request)
        {
            var signedUser = await _userManager.FindByEmailAsync(request.Email);
            var result = await _signInManager.PasswordSignInAsync(signedUser, request.Password, false, false);
            return result;
        }
        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
        
        public async Task<bool> LockOutUser(string uid)
        {
            var user = await _userManager.FindByIdAsync(uid);
            user.LockoutEnabled = true;
            user.LockoutEnd = DateTime.MaxValue;
            _context.Entry(user).CurrentValues.SetValues(user);

            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> UnlockUser(string uid)
        {
            var user = await _userManager.FindByIdAsync(uid);
            user.LockoutEnabled = false;
            user.LockoutEnd = DateTime.Now;
            _context.Entry(user).CurrentValues.SetValues(user);

            return await _context.SaveChangesAsync() > 0;
        }
        
        public async Task<IdentityResult> DeleteUserAsync(string uid)
        {
            var user = await _userManager.FindByIdAsync(uid);
            return await _userManager.DeleteAsync(user);
        }
        public async Task<IEnumerable<IdentityRole<string>>> ListAllRoles()
        {
            return await _roleManager.Roles.ToListAsync();
        }
        public async Task<IdentityResult> AddUserToRole(ApplicationUser user, string role)
        {
            return await _userManager.AddToRoleAsync(user, role);
        }
        public async Task<IdentityResult> RemoveUserFromRole(ApplicationUser user, string role)
        {
            return await _userManager.RemoveFromRoleAsync(user, role);
        }
        
        public async Task<bool> UpdateUserRoles(string uid, List<string> rolesIds)
        {
            //Get the list of associated role id of the user
            var userRoles = (await GetUserRolesById(uid)).Select(ur => ur.Id).ToList();
            if (rolesIds != null)
            {
                foreach (var roleId in rolesIds)
                {
                    if (!userRoles.Contains(roleId))
                    {
                        await _context.UserRoles.AddAsync(new IdentityUserRole<string>
                        {
                            RoleId = roleId,
                            UserId = uid
                        });
                    }
                }

                foreach (var userRoleId in userRoles)
                {
                    if (!rolesIds.Contains(userRoleId))
                    {
                        _context.UserRoles.Remove(new IdentityUserRole<string>
                        {
                            RoleId = userRoleId,
                            UserId = uid
                        });
                    }
                }
            }
            else
            {
                 _context.UserRoles.RemoveRange(_context.UserRoles.Where(u => u.UserId == uid));
            }

            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<ICollection<IdentityRole<string>>> GetUserRolesById(string id)
        {
            var response = new List<IdentityRole<string>>();
            var userRoles =  await _userManager.GetRolesAsync(new ApplicationUser { Id = id });
            foreach (var role in userRoles)
            {
                var roleId = await _context.Roles.Where(r => r.Name == role).Select(r => r.Id).FirstOrDefaultAsync();
                response.Add(new IdentityRole<string> { Id = roleId, Name = role });
            }
            return response; 
        }
        public async Task<string> GetUserNameById(string id)
        {
            return await _context.Users.Where(u => u.Id == id).Select(u => u.UserName).FirstOrDefaultAsync();
        }
        
        public async Task<IEnumerable<ApplicationUser>> GetAllManageableUsers(int page, string searchString, bool showLocked, bool showNoRole)
        {
            var itemPerPage = 7;
            var toSkip = (page - 1) * itemPerPage;

            var admins = await _userManager.GetUsersInRoleAsync("Admin");
            var users = new List<ApplicationUser>();

            if (!string.IsNullOrEmpty(searchString))
            {
                //First check on the basic fields of the user set.
                users = await _context.Users
                    .Where(u => u.UserName.Contains(searchString)
                    || u.Email.Contains(searchString))
                    .ToListAsync();

                //If there is no result
                //Get the roles containing the searchstring
                var rolesId = await _context.Roles
                    .Where(r => r.Name.ToLower().Contains(searchString))
                    .Select(r => r.Id)
                    .ToListAsync();

                //Does any entry exist?
                if (rolesId.Count() > 0)
                {
                    //Get the corresponding user id from user role table, match them to their user and add them to the list.
                    var userIds = await _context.UserRoles.Where(ur => rolesId.Contains(ur.RoleId)).Select(u => u.UserId).ToListAsync();
                    users.AddRange(await _context.Users.Where(u => userIds.Contains(u.Id)).ToListAsync());
                }
            }
            else if (showLocked)
            {
                users = await _context.Users
                        .Where(u => u.LockoutEnabled == true)
                        .ToListAsync();
            }
            else if (showNoRole)
            {
                users = await _context.Users
                    .Where(c => !_context.UserRoles
                    .Select(b => b.UserId).Distinct()
                    .Contains(c.Id)).ToListAsync();
            }
            else
            {
                users = await _context.Users
                    .Skip(toSkip)
                    .Take(itemPerPage)
                    .ToListAsync();
            }
            return users.Except(admins).ToList();
        }

        public async Task<int> CountManageableUsers()
        {
            var admins = await _userManager.GetUsersInRoleAsync("Admin");
            return (await _context.Users.ToListAsync()).Except(admins).Count();
            
        }
        public async Task<ICollection<ApplicationUser>> GetAllAccessibleUsersPerRole(string uid)
        {
            //Get current user role
            var currentUserRole = await _userManager.GetRolesAsync(new ApplicationUser { Id = uid });
            var accessibleTeam = new List<ApplicationUser>();

            if (currentUserRole == null)
            {
                return accessibleTeam;
            }

            if (currentUserRole[0].Contains("Admin"))
            {
                var admins = await _userManager.GetUsersInRoleAsync("Admin");

                accessibleTeam = await _context.Users.ToListAsync();
                accessibleTeam = accessibleTeam.Except(admins).ToList();
            }
            else if (currentUserRole[0].Contains("Project Manager"))
            {
                accessibleTeam = await _context.Users.ToListAsync();
                var admins = await _userManager.GetUsersInRoleAsync("Admin");
                var pm = await _userManager.GetUsersInRoleAsync("Project Manager");
                accessibleTeam = accessibleTeam.Except(admins.Concat(pm)).ToList();
            }

            return accessibleTeam;
        }
        public async Task<ICollection<ApplicationUser>> GetAccessibleTicketTeam(string uid, Guid projectId)
        {
            var accessibleUsers = (await GetAllAccessibleUsersPerRole(uid)).ToList();
            var teamIds = await _context.ProjectTeamMembers
                        .Where(ptm => ptm.ProjectId == projectId)
                        .Select(x => x.UserId)
                        .ToListAsync();

            var ticketTeam = accessibleUsers.Where(u => teamIds.Contains(u.Id)).ToList();

            return ticketTeam;
        }
        public async Task<ICollection<ApplicationUser>>GetCurrentTicketTeam(Guid ticketId)
        {
            var team = await _context.TicketsTeamMembers
                        .Where(ttm => ttm.TicketId == ticketId)
                        .Select(x => x.UserId)
                        .ToListAsync();
            var projectId = await _context.Tickets.Where(t => t.Id == ticketId).Select(t => t.ProjectId).FirstOrDefaultAsync();
            var pmRoleIds = await _context.Roles.Where(r => r.Name == "Project Manager").Select(r => r.Id).FirstOrDefaultAsync();
            var pmsIds = await _context.UserRoles.Where(ur => pmRoleIds.Contains(ur.RoleId)).Select(ur => ur.UserId).ToListAsync();
            var pmId = await _context.ProjectTeamMembers.Where(ptm => ptm.ProjectId == projectId && pmsIds.Contains(ptm.UserId)).Select(ptm => ptm.UserId).FirstOrDefaultAsync();
            team.Add(pmId);

            var ticketTeam = await _context.Users.
                            Where(u => team.Contains(u.Id))
                            .ToListAsync();

            return ticketTeam;
        }
       
        
        public async Task<string> GeneratePasswordForgottenMailToken(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            return token;
        }
        public async Task<IdentityResult> ResetPassword(ResetPasswordModel model)
        {
            return await _userManager.ResetPasswordAsync(await _userManager.FindByIdAsync(model.Uid), model.Token, model.NewPassword);
        }
        public async Task<bool> UserEmailExist(string email)
        {
            return await _userManager.FindByEmailAsync(email) != null;
        }
        public async Task<bool> UserIdExists(string id)
        {
            return await _context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id) != null;
        }
        public async Task<ApplicationUser> GetUserOrNullAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }
        public async Task<bool> UsernameExist(string name)
        {
            return await _userManager.FindByNameAsync(name) != null;
        }
    }
}
