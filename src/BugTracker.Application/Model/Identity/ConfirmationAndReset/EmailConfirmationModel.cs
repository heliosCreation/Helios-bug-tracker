namespace BugTracker.Application.Model.Identity.ConfirmationAndReset
{
    public class EmailConfirmationModel
    {
        public string Email { get; set; }

        public bool IsSent { get; set; } = false;

        public bool IsVerified { get; set; } = false;
    }
}
