﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using FreelancersProject.Application.Common;
using FreelancersProject.Application.DTOs;
using FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands;
using FreelancersProject.Application.Handler.CQRS.Queries.SkillQueries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FreelancersProject.Areas.Hirer.Controllers
{
	[Area("Hirer")]
	//[Authorize(Roles ="Freelancer")]
	public class ProjectController : Controller
	{
		private readonly IMediator mediator;

		public ProjectController(IMediator mediator)
		{
			this.mediator = mediator;
		}
		public IActionResult MyProjectss()
		{
			return View();
		}
		[HttpGet]
		public async  Task<IActionResult> CreateProject()
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

			var result = await mediator.Send(model);
			if (result.Success)
			{
				return RedirectToAction("MyProjectss");
			}
			else
			{
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
		}

		public IActionResult OfferProject()
		{
			return View();
		}
	}
}