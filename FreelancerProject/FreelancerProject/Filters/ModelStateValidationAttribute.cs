using FreelancersProject.Application.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancersProject.Filters
{
    public class ModelStateValidationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                BaseResponses<string> responses = new BaseResponses<string>(System.Net.HttpStatusCode.BadRequest);
                var modelErrors = context.ModelState.Keys
                    .SelectMany(key =>
                        context.ModelState[key].Errors.Select(x => new ValidationError(key, x.ErrorMessage)));

                modelErrors.ToList().ForEach(x =>
                {
                    responses.ValidationErrors.AddRange(modelErrors);
                });

                context.Result = new BadRequestObjectResult(responses);
            }
        }
    }
}
