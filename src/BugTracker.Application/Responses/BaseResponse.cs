using System.Collections.Generic;
using System.Net;

namespace BugTracker.Application.Responses
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            Succeeded = true;
        }

        public BaseResponse(string message = null)
        {
            Succeeded = true;
            Message = message;
        }

        public BaseResponse(string message, bool success)
        {
            Succeeded = success;
            Message = message;
        }

        public bool Succeeded { get; set; }

        public string Message { get; set; }

        public int StatusCode { get; set; } = (int)HttpStatusCode.OK;

        public List<string> ErrorMessages { get; set; } = new List<string>();
    }
}