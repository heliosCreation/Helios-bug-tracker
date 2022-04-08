using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Dto.Audits;
using BugTracker.Application.Enums;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Audits.Queries
{
    public class LogToViewHelper
    {
        private readonly IIdentityService _identityService;
        private readonly ITicketConfigurationRepository _ticketConfigurationRepository;

        public LogToViewHelper(IIdentityService identityService, ITicketConfigurationRepository ticketConfigurationRepository)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
            _ticketConfigurationRepository = ticketConfigurationRepository ?? throw new ArgumentNullException(nameof(ticketConfigurationRepository));
        }

        public async Task<List<AuditLogDto>> AssignAuditLogtIdToTextAsync(List<AuditLogDto> auditLogs)
        {
            foreach (var item in auditLogs.ToList())
            {
                item.User = await _identityService.GetUserNameById(item.User);

                //if (item.Type == AuditType.Update.ToString())
                //{
                //    await ManageUpdate(item);
                //}
                if (item.TableName == "TicketsTeamMembers")
                {
                    await ManageTeam(item, auditLogs);
                }

            }

            return auditLogs.OrderByDescending(al => al.DateTime).ToList();
        }



        public async Task ManageTeam(AuditLogDto item, List<AuditLogDto> auditLogs)
        {
            string action = item.Type == AuditType.Delete.ToString() ? "User deleted" : "User added";
            var target = item.Type == AuditType.Delete.ToString() ? item.OldValues : item.NewValues;

            var userId = item.PrimaryKey["UserId"];
            var userName = target["UserId"];
            var userRoles = (await _identityService.GetUserRolesById(userId)).ToList();
            object userRole = userRoles.Count > 0 ? userRoles.First() : "None";

            var targetParent = auditLogs
                .Where(
                    al => al.DateTime.ToString() == item.DateTime.ToString()
                    && al.TableName == "Ticket"
                )
                .FirstOrDefault();

            if (targetParent != null)
            {
                //If the key already exist, just concat a new value to the actual
                if (targetParent.NewValues.ContainsKey(action))
                {
                    targetParent.NewValues[action] = targetParent.NewValues[action] + ";" + userName + " - " + userRole;
                }
                //Otherwise add an entry
                else
                {
                    targetParent.NewValues.Add(action, userName + " -  " + userRole);
                }

            }
            else
            {

                //If no parent currently exists, create a new one that will hold  
                auditLogs.Add(new AuditLogDto
                {
                    Id = Guid.NewGuid(),
                    DateTime = item.DateTime,
                    User = item.User,
                    TableName = "Ticket",
                    NewValues = new Dictionary<string, string>() { { action, userName + " - " + userRole } },
                    Type = AuditType.Update.ToString()
                });

            }
            auditLogs.Remove(item);
        }
    }
}
