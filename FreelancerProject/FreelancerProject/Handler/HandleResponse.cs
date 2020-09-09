using FreelancersProject.Application.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace FreelancersProject.Handler
{
    public class HandleResponse
    {
        public static IActionResult Response<T>(BaseResponses<T> entity)
        {
            if (!entity.Success && entity.Errors.Length > 0 && entity.Errors.Contains("Unauthorize"))
                return new UnauthorizedResult();

            else if (!entity.Success && entity.Errors.Length > 0 && entity.StatusCode == System.Net.HttpStatusCode.NotFound)
                return new NotFoundObjectResult(entity);

            else if (!entity.Success && entity.Errors.Length > 0 && entity.StatusCode == HttpStatusCode.BadRequest)
                return new BadRequestObjectResult(entity);

            else if (!entity.Success && entity.Errors.Length > 0)
                return new NoContentResult();
            return new JsonResult(entity);
        }
    }
}
