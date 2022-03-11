using System.Collections.Generic;

namespace BugTracker.Application.Enums
{
    public static class DemoUserMailDictionnary
    {
        public static Dictionary<int, string> Mails { get; set; } = new Dictionary<int, string>()
        {
            {1, "DemoAdmin@Admin.com"},
            {2, "demoPM@gmail.com" },
            {3, "DemoDev@gmail.com" },
            {4, "demoSubmitter@gmail.com" }
        };
    }
}
