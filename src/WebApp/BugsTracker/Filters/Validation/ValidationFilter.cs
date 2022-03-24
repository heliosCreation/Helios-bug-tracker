using BugTracker.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace BugTracker.Filters.Validation
{
    public class ValidationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var result = context.Result;
            if (result is ViewResult view)
            {
                var model = view.Model as BaseResponse;
                switch (model.StatusCode)
                {
                    case 401:
                        context.Result = new RedirectToRouteResult(
                        new RouteValueDictionary(new { area = "Tracker", controller = "Home", action = "Dashboard" }));
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
