using System.Collections.Generic;
using System.Net;

namespace BugTracker.Application.Responses
{
    public class ApiResponse<T> : BaseResponse where T : class
    {

        public T Data { get; set; }

        public List<T> DataList { get; set; } = new List<T>();


        public ApiResponse<T> setNotFoundResponse(string message = null)
        {
            Succeeded = false;
            StatusCode = (int)HttpStatusCode.NotFound;
            ErrorMessages.Add(message);
            return this;
        }

        public ApiResponse<T> SetBadRequestResponse(string message = null, List<string> errors = null)
        {
            Succeeded = false;
            StatusCode = (int)HttpStatusCode.BadRequest;
            if (message != null)
            {
                ErrorMessages.Add(message);
            }
            else
            {
                ErrorMessages = errors;
            }
            return this;
        }
        public ApiResponse<T> SetUnhautorizedResponse()
        {
            Succeeded = false;
            StatusCode = (int)HttpStatusCode.Unauthorized;
            ErrorMessages.Add("You don't have the right to access this feature.");
            return this;
        }
        public ApiResponse<T> SetInternalServerErrorResponse()
        {
            Succeeded = false;
            StatusCode = (int)HttpStatusCode.InternalServerError;
            ErrorMessages.Add("An error occured while processing your request. If the problem persist, try to contact your administrator.");
            return this;
        }
    }
}
