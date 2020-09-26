using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreelancersProject.Application.DTOs;
using FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands;
using FreelancersProject.Domain.Concretes;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FreelancersProject.Areas.Freelancer.Controllers
{
	[Area("Freelancer")]
	public class ProjectController : Controller
	{
		private readonly IMediator mediator;

		public UserManager<ApplicationUser> UserManager { get; }

		public ProjectController(IMediator mediator,UserManager<ApplicationUser> userManager)
		{
			this.mediator = mediator;
			UserManager = userManager;
		}


		public async Task<IActionResult> MyProjectsAsync()
		{
			string a = User.Identity.Name;
			var user = await UserManager.FindByNameAsync(a);


			GetAllMyProject.GetAllMyProjectRequest getAll = new GetAllMyProject.GetAllMyProjectRequest();
			getAll.id = user.Id.ToString();


			var list = await mediator.Send(getAll);
			
			return View(list.Entity);

		}

		public IActionResult MyMessages()
		{
			return View();
		}
	}
}
