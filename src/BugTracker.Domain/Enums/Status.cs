using System.ComponentModel.DataAnnotations;

namespace BugTracker.Domain.Enums
{
    public enum Status
    {
        New,
        Open,

        [Display(Name = "In Progress")]
        Progress,

        Solved,
        Closed,

        [Display(Name = "Re opened")]
        ReOpened
    }
}
