using BugTracker.Application.Dto.Tickets;
using BugTracker.Application.Features.Team.Queries.GetAllAccessibleMembers;
using BugTracker.Application.Features.Tickets.Commands.Create;
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

        public IActionResult GetTickets(Guid projectID, bool isSuccess = false, bool isFailed = false, string type = null, string action = null)
        {
            ViewBag.Type = type;
            ViewBag.Action = action;
            return View("ProjectTickets");
        }
        public async Task<IActionResult> Create(CreateTicketCommand command)
        {
            var response = await Mediator.Send(command);
            if (response.Succeeded)
            {
                return RedirectToAction("GetTickets", new { isSuccess = true, type = "ticket", action = "created" });
            }
            return RedirectToAction("GetTickets", new { isFailed = true });
        }
        public async Task<IActionResult> LoadCreateModal()
        {
            var dto = new CreateTicketDto();
            var response = await Mediator.Send(new GetAllAccessibleMembersQuery());
            dto.Team = response.DataList;

            return PartialView(CreateModalPath, dto);
        }
    }
}
