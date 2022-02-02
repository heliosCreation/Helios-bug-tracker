using System.ComponentModel.DataAnnotations;

namespace BugTracker.Domain.Enums
{
    public enum Type
    {
        [Display(Name = "Bug/Fix")]
        BugFix,

        [Display(Name = "Feature request")]
        FeatureRequest,

        [Display(Name = "Training/Documentation")]
        TrainingDocumentation
    }
}
