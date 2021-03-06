﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FreelancersProject.Handler;
using FreelancersProject.Controllers.LancerCONTROLLER;
using FreelancersProject.Application.Handler.CQRS.Queries;
using Owner.Application.Handler.CQRS.Queries.ADDress;

namespace FreelancersProject.Controllers
{
    public class Home2Controller : LancerController
    {

        //[HttpPost("Post")]
        //public async Task<IActionResult> Add()
        //{

        //    return HandleResponse.Response(result);
        //}
        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await Mediator.Send(new GettAllProject.GetAllProjectRequest());
            return HandleResponse.Response(result);
        }
     
        [HttpPost("Post")]
        public async Task<IActionResult> Add( CreateOwner.AddOwnerRequest ownerRequest)
        {
            var result = await Mediator.Send(ownerRequest);
            return HandleResponse.Response(result);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<IActionResult> Delete(DeleteOwner.DeleteOwnerRequest ownerRequest)
        {
            var result = await Mediator.Send(ownerRequest);
            return HandleResponse.Response(result);
        }

    }
       
    
}
