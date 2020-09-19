using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FreelancersProject.Areas.Freelancer.Controllers
{
    [Area("Freelancer")]
    [Authorize(Roles = "Freelancer")]
    public class HomeController : Controller
    {
        private readonly IMediator mediator;

        public HomeController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IActionResult> Projects()
        {

            var list = await mediator.Send(new GetAllProject.GetAllProjectRequest());
            return View(list.Entity);
        }
        [HttpGet]
        public async Task<IActionResult> detail(GetProjectSelectID.GetProjectSelectIDRequest get)
        {
            

             var list = await mediator.Send(get);
            
            return View(list.Entity);


        }

    }
}
