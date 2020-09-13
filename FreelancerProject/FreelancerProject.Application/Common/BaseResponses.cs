using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace FreelancersProject.Application.Common
{
    public class BaseResponses<T>
    {
        public T Entity { get; set; }
        public bool Success { get; set; }
        public string Errors { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public List<ValidationError> ValidationErrors { get; set; }

      
        public BaseResponses(T entity, HttpStatusCode statusCode, bool success = true, string errors = null)
        {
            Entity = entity;
            Success = success;
            Errors = errors;
            StatusCode = statusCode;

        }
        public BaseResponses(T entity, bool success = true, string errors = null)
        {
            Entity = entity;
            Success = success;
            Errors = errors;
            StatusCode = HttpStatusCode.OK;
        }
        public BaseResponses(HttpStatusCode code, string errors)
        {
            StatusCode = code;
            Errors = errors;
            Success = false;
        }

        public BaseResponses(HttpStatusCode statusCode)
        {
            ValidationErrors = new List<ValidationError>();
            StatusCode = statusCode;
        }
       
    }
}
