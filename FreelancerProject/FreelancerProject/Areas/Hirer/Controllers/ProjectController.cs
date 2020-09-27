using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using FreelancersProject.Application.Common;
using FreelancersProject.Application.DTOs;
using FreelancersProject.Application.Handler.CQRS.Commands.ConfirmedBidCommands;
using FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands;
using FreelancersProject.Application.Handler.CQRS.Queries.Freelancer;
using FreelancersProject.Application.Handler.CQRS.Queries.OfferedProjectQueries;
using FreelancersProject.Application.Handler.CQRS.Queries.ProjectQueries;
using FreelancersProject.Application.Handler.CQRS.Queries.SkillQueries;
using FreelancersProject.Persistence.Repositories.Concretes;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FreelancersProject.Areas.Hirer.Controllers
{
	[Area("Hirer")]
	[Authorize(Roles ="Owner")]
	public class ProjectController : Controller
	{
		private readonly IMediator mediator;

		public ProjectController(IMediator mediator)
		{
			this.mediator = mediator;
		}
		public async Task<IActionResult> MyProjectss()
		{
			var username = User.Identity.Name;
			var projList = new ProjectList.ProjectListRequest() { Username = username };

			var result = await mediator.Send(projList);

			return View(result.Entity);
		}
		[HttpGet]
		public async Task<IActionResult> CreateProject()
		{
			var skills = await mediator.Send(new SkillList.SkillListRequest());

			var listDTO = new List<SkillListDTO>();
			foreach (var item in skills.Entity)
			{
				var data = new SkillListDTO { Id = item.Id, Name = item.Name };
				listDTO.Add(data);
			}
			ViewBag.SkillList = listDTO;
			return View();
		}

		[HttpPost]

		public async Task<IActionResult> CreateProject(CreateProject.CreateProjectRequest model)
		{
			ModelState.Clear();
			if (ModelState.IsValid)
			{
				var result = await mediator.Send(model);
				if (result.Success)
				{
					return RedirectToAction("MyProjectss");
				}
				else
				{
					foreach (var item in result.ValidationErrors)
					{
						ModelState.AddModelError("All", item.Value);
					}
				}
			}
			
			
				var skills = await mediator.Send(new SkillList.SkillListRequest());

				var listDTO = new List<SkillListDTO>();
				foreach (var item in skills.Entity)
				{
					var data = new SkillListDTO { Id = item.Id, Name = item.Name };
					listDTO.Add(data);
				}
				ViewBag.SkillList = listDTO;
				return View(model);
			
			
		}

		public  async Task<IActionResult> MakeOffer()
		{
			var users = await mediator.Send(new FreelancerList.FreelancerListRequest());
			return View(users.Entity);
		}
		[HttpGet]
		public   IActionResult OfferProject(string freelancerId)
		{
			var username = User.Identity.Name;
			var model = new OfferProject.OfferProjectRequest() { OwnerUserName = username, FreelancerId=Convert.ToInt32(freelancerId) };

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> OfferProject(OfferProject.OfferProjectRequest model)
		{
			if (ModelState.IsValid)
			{
				var result =await mediator.Send(model);
				if (result.StatusCode == HttpStatusCode.OK)
				{
					return RedirectToAction("OfferedProjects");
				}
				else
				{
					var error = new ErrorPageDTO() { StatusCode = result.StatusCode, Errors = result.Errors, Success = result.Success };
					return RedirectToAction("ResponsePage", "Home", error);
				}
			}
			
			return View(model);
		}
		public async Task<IActionResult> ProjectDetails([FromQuery]string projectId)
		{
			var result = await mediator.Send(new ProjectDetails.ProjectDetailsRequest { ProjectId = projectId });
			if (result.StatusCode == HttpStatusCode.OK)
			{
			return View(result.Entity);

			}

			else
			{
				var error = new ErrorPageDTO() { StatusCode = result.StatusCode, Errors = result.Errors, Success = result.Success };
				return RedirectToAction("ResponsePage", "Home", error);
			}
		}

		public async Task<IActionResult> OfferedProjects()
		{
			var username = User.Identity.Name;
			var model = new OfferedProjectList.OfferedProjectListRequest { UserName = username };
			var result = await mediator.Send(model);
			return View(result.Entity);
		}

		[HttpPost]
		public async Task<IActionResult> ConfirmBid(ProjectDetailsDTO model)
		{
			var data = new CreateConfirmedBid.ConfirmedBidRequest { ProjectId = model.ProjectId, ConfirmedBid = model.ConfirmedBid };
			var result = await mediator.Send(data);
			if (result.StatusCode == HttpStatusCode.OK)
			{
				
			    return RedirectToAction("MyProjectss");

			}

			else
			{
				var error = new ErrorPageDTO() { StatusCode = result.StatusCode, Errors = result.Errors, Success = result.Success };
				return RedirectToAction("ResponsePage", "Home", error);
			}
		}
	}
}
