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

                if (item.Type == AuditType.Update.ToString())
                {
                    await ManageUpdate(item);
                }
                if (item.TableName == "TicketsTeamMembers")
                {
                    ManageTeam(item, auditLogs);
                }

            }

            return auditLogs.OrderByDescending(al => al.DateTime).ToList();
        }

        public async Task<Dictionary<string, string>> ReworkEntityFields(Dictionary<string, string> prop, string key)
        {
            Type type = _ticketConfigurationRepository.GetType();
            MethodInfo method = type.GetMethod("Get" + key.Replace("Id", "") + "Name");

            var value = Guid.Parse(prop.Where(nv => nv.Key == key).First().Value);
            Task<string> newName = (Task<string>)method.Invoke(_ticketConfigurationRepository, new object[] { value });

            prop.Remove(key);
            prop.Add(key.Replace("Id", ""), (await newName).ToString());
            return prop;
        }

        public async Task ManageUpdate(AuditLogDto item)
        {
            if (item.AffectedColumns.Contains("PriorityId"))
            {
                item.NewValues = await ReworkEntityFields(item.NewValues, "PriorityId");
                item.OldValues = await ReworkEntityFields(item.OldValues, "PriorityId");
            }
            if (item.AffectedColumns.Contains("TypeId"))
            {
                item.NewValues = await ReworkEntityFields(item.NewValues, "TypeId");
                item.OldValues = await ReworkEntityFields(item.OldValues, "TypeId");
            }
            if (item.AffectedColumns.Contains("StatusId"))
            {
                item.NewValues = await ReworkEntityFields(item.NewValues, "StatusId");
                item.OldValues = await ReworkEntityFields(item.OldValues, "StatusId");
            }


        }

        public void ManageTeam(AuditLogDto item, List<AuditLogDto> auditLogs)
        {
            string action = item.Type == AuditType.Delete.ToString() ? "User deleted" : "User added";
            var target = item.Type == AuditType.Delete.ToString() ? item.OldValues : item.NewValues;

            JObject userJson = JObject.Parse(target["UserId"]);
            var userName = userJson.GetValue("Name");
            var userRoles = userJson.GetValue("Roles");


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
                    targetParent.NewValues[action] = targetParent.NewValues[action] + ";" + userName + " - " + userRoles;
                }
                //Otherwise add an entry
                else
                {
                    targetParent.NewValues.Add(action, userName + " -  " + userRoles);
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
                    NewValues = new Dictionary<string, string>() { { action, userName + " - " + userRoles } },
                    Type = AuditType.Update.ToString()
                });

            }
            auditLogs.Remove(item);
        }
    }
}
