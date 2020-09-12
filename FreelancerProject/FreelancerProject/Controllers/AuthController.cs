using FreelancersProject.Application.Handler.CQRS.Commands.LoginCommands;
using FreelancersProject.Domain.Concretes;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static FreelancersProject.Application.Handler.CQRS.Queries.CountryQueries.GetAllCountries;

namespace FreelancersProject.Controllers
{
	public class AuthController :Controller
	{
		private readonly IMediator mediator;

		public AuthController(IMediator mediator)
		{
			this.mediator = mediator;
		}
		
		public IActionResult Index()
		{
			//roleManager.CreateAsync(new Role() { Name = "Admin" });
			//var data=await roleStore.CreateAsync(new Role() { Name = "Admin" }, CancellationToken.None);
			
			return View();
		}

		[HttpGet]
		public async Task< IActionResult> Register()
		{
			var list = await mediator.Send(new AllCountriesQuery());
			var selectedList = new SelectList(list.Entity, "Id", "Name");
			ViewBag.CountryItems = selectedList;

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Register(SignIn.SignInRequest signIn)
		{
			var responce = await mediator.Send(signIn);

			return View();
		}

		public IActionResult SignIn()
		{
			return View();
		}
	}
}
