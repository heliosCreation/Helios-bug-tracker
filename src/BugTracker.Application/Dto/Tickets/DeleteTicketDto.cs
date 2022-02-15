using System;

namespace BugTracker.Application.Dto.Tickets
{
    public class DeleteTicketDto
    {
        public DeleteTicketDto(Guid id, Guid projectId, string name)
        {
            Id = id;
            ProjectId = projectId;
            Name = name;
        }

        public Guid Id { get; set; }
        public Guid ProjectId { get; }
        public string Name { get; set; }
    }
}
