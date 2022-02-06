namespace BugTracker.Application.Contracts.Identity
{
    public interface ILoggedInUserService
    {
        public string UserId { get; set; }
    }
}
