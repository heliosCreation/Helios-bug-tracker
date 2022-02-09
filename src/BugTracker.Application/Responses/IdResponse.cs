using System;

namespace BugTracker.Application.Responses
{
    public class IdResponse
    {
        public IdResponse(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
