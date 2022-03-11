using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Application.Model.Identity.Authentication
{
    public class DemoAuthenticationModel
    {
        [Range(1, 4,
        ErrorMessage = "Please select an appropriate otion.")]
        public int Type { get; set; }
    }
}
