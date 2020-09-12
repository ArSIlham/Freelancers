using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace FreelancersProject.Persistence.CustomException
{
    public class RestException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public override string Message { get; }
        public RestException(HttpStatusCode code, string message)
        {
            StatusCode = code;
            Message = message;
        }

    }
}
