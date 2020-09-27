using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreelancersProject.Application.DTOs;
using FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands;
using FreelancersProject.Domain.Concretes;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FreelancersProject.Areas.Freelancer.Controllers
{
    [Area("Freelancer")]
    [Authorize(Roles = "Freelancer")]
    public class HomeController : Controller
    {
        private readonly IMediator mediator;
        public UserManager<ApplicationUser> UserManager { get; }

        public HomeController(IMediator mediator, UserManager<ApplicationUser> userManager)
        {
            this.mediator = mediator;
            UserManager = userManager;
        }
        public async Task<IActionResult> Projects()
        {

            var list = await mediator.Send(new GetAllProject.GetAllProjectRequest());
            return View(list.Entity);
        }
        [HttpGet]
        public async Task<IActionResult> detail(ProjectComment.ProjectCommentRequest project)
        {


            var list = await mediator.Send(project);


            return View(list.Entity);


        }

        [HttpPost]
        public async Task<IActionResult> Comment(ProjectBidRequestDTO project)
        {

            var list = await mediator.Send(
                new ProjectComment.ProjectCommentRequest
                {
                    BidPrice = project.bidrequests.BidPrice,
                    Comment = project.bidrequests.Comment,
                    ProjectID = project.Project.Id,
                    FreekancerName = User.Identity.Name

                });

            return View("detail", list.Entity);
        }



        public IActionResult Error()
        {

            return View();


        }
    }
}

