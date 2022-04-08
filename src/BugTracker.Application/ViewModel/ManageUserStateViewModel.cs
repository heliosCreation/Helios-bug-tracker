namespace BugTracker.Application.ViewModel
{
    public class ManageUserStateViewModel
    {
        public ManageUserStateViewModel(string uid, int page)
        {
            Uid = uid;
            Page = page;
        }
        public string Uid { get; set; }
        public int Page { get; set; }
    }
}
