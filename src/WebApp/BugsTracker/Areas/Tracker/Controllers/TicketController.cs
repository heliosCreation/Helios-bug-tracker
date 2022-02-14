using BugTracker.Application.Dto.Tickets;
using BugTracker.Application.Features.Team.Queries.GetAllAccessibleMembers;
using BugTracker.Application.Features.TicketConfigurations.Queries.GetAll;
using BugTracker.Application.Features.Tickets.Commands.Create;
using BugTracker.Application.Features.Tickets.Queries.GetProjectTickets;
using BugTracker.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Area("Tracker")]

    public class TicketController : BaseController
    {
        private const string ModalBasePath = "~/Areas/Tracker/Views/Shared/Partial/Ticket/";
        private const string ModalType = "TicketModalPartial.cshtml";
        private const string CreateModalPath = ModalBasePath + "_create" + ModalType;
        private const string UpdateModalPath = ModalBasePath + "_update" + ModalType;
        private const string DeleteModalPath = ModalBasePath + "_delete" + ModalType;

        public IActionResult GetAll()
        {
            return View();
        }

        public async Task<IActionResult> ByProject(Guid projectId, string projectName, bool isSuccess = false, bool isFailed = false, string type = null, string action = null)
        {
            ViewBag.projectId = projectId;
            ViewBag.Type = type;
            ViewBag.Action = action;

            var response = await Mediator.Send(new GetProjectTicketsQuery(projectId));
            var viewModel = new ProjectWithTicketVm(projectId,projectName, response.DataList);
            return View("ProjectTickets", viewModel);
        }
        public async Task<IActionResult> Create(CreateTicketCommand command, Guid projectId, string projectName)
        {
            var response = await Mediator.Send(command);
            if (response.Succeeded)
            {
                return RedirectToAction("ByProject", new {projectId = projectId, projectName = projectName, isSuccess = true, type = "ticket", action = "created" });
            }
            return RedirectToAction("ByProject", new { projectId = projectId, projectName = projectName, isFailed = true });
        }
        public async Task<IActionResult> LoadCreateModal(Guid projectId, string projectName)
        {
            var dto = new CreateTicketDto(projectId);

            var teamResponse = await Mediator.Send(new GetAllAccessibleMembersQuery());
            var ticketConfigurationResponse = await Mediator.Send(new GetAllTicketConfigurationsQuery());
            dto.Team = teamResponse.DataList;
            dto.TicketConfigurations = ticketConfigurationResponse.Data;
            dto.ProjectName = projectName;

            return PartialView(CreateModalPath, dto);
        }
    }
}
