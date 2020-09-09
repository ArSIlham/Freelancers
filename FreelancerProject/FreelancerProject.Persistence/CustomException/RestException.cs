using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace FreelancersProject.Persistence.CustomException
{
    public class RestException : Exception
    {
        public HttpStatusCode Code { get; }
        public string Message { get; }
        public RestException(HttpStatusCode code, string message)
        {
            Code = code;
            Message = message;
        }

    }
}
