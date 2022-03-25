using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Dto.Tickets.Diagram;
using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using BugTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Queries.GetTicketDiagramDataByUser
{
    public class GetTicketDiagramDataByUserQueryHandler : IRequestHandler<GetTicketDiagramDataByUserQuery, ApiResponse<TicketDiagramDataModel>>
    {
        private readonly ILoggedInUserService _loggedInUserService;
        private readonly ITicketRepository _ticketRepository;

        public GetTicketDiagramDataByUserQueryHandler(ILoggedInUserService loggedInUserService, ITicketRepository ticketRepository)
        {
            _loggedInUserService = loggedInUserService ?? throw new ArgumentNullException(nameof(loggedInUserService));
            _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
        }

        public async Task<ApiResponse<TicketDiagramDataModel>> Handle(GetTicketDiagramDataByUserQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<TicketDiagramDataModel>();
            response.Data = new TicketDiagramDataModel();

            var dbResult = await GetAppropriateTicketSet();

            response.Data.TypesCount = SetTypeCount(dbResult);
            response.Data.StatusesCount = SetStatusCount(dbResult);
            response.Data.PrioritiesCount = SetPriorityCount(dbResult);

            return response;
        }

        private async Task<IEnumerable<Ticket>> GetAppropriateTicketSet()
        {

            if (_loggedInUserService.Roles.Any(str => str.Contains("Admin")))
            {
                return await _ticketRepository.ListAllAsync(0, null);
            }

            else if (_loggedInUserService.Roles.Any(str => str.Contains("Project Manager")))
            {
                return await _ticketRepository.GetProjectManagerTickets(_loggedInUserService.UserId,0, null);
            }
            else if (_loggedInUserService.Roles.Any(str => str.Contains("Submitter")))
            {
                return await _ticketRepository.GetTicketsByUser(_loggedInUserService.UserId, 0, null, true);
            }

            return await _ticketRepository.GetTicketsByUser(_loggedInUserService.UserId, 0, null, false);

        }
        
        private TicketByTypeDto SetTypeCount(IEnumerable<Ticket> tickets)
        {
            var response = new TicketByTypeDto();

            response.BugCount = tickets.Where(t => t.Type.Name == "Bug - Error").ToList().Count;
            response.FeatureCount = tickets.Where(t => t.Type.Name == "Feature request").ToList().Count;
            response.TrainingCount = tickets.Where(t => t.Type.Name == "Training").ToList().Count;
            response.DocCount = tickets.Where(t => t.Type.Name == "Documentation").ToList().Count;

            return response;
        }

        private TicketByStatusDto SetStatusCount(IEnumerable<Ticket> tickets)
        {
            var response = new TicketByStatusDto();

            response.NewCount = tickets.Where(t => t.Status.Name == "New").ToList().Count;
            response.OpenCount = tickets.Where(t => t.Status.Name == "Open").ToList().Count;
            response.InProgressCount = tickets.Where(t => t.Status.Name == "In progress").ToList().Count;
            response.ResolvedCount = tickets.Where(t => t.Status.Name == "Resolved").ToList().Count;

            return response;
        }

        private TicketByPriorityDto SetPriorityCount(IEnumerable<Ticket> tickets)
        {
            var response = new TicketByPriorityDto();

            response.LowCount = tickets.Where(t => t.Priority.Name == "Low").ToList().Count;
            response.MediumCount = tickets.Where(t => t.Priority.Name == "Medium").ToList().Count;
            response.HighCount = tickets.Where(t => t.Priority.Name == "High").ToList().Count;
            response.ImmediateCount = tickets.Where(t => t.Priority.Name == "Immediate").ToList().Count;

            return response;
        }
    }
}
