using FreelancersProject.Application.DTOs;
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
		private readonly SignInManager<ApplicationUser> signInManager;
		private readonly UserManager<ApplicationUser> userManager;
		private readonly RoleManager<ApplicationRole> roleManager;

		public AuthController(IMediator mediator, SignInManager<ApplicationUser> signInManager,
			UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
		{
			this.mediator = mediator;
			this.signInManager = signInManager;
			this.userManager = userManager;
			this.roleManager = roleManager;
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
			ModelState.Clear();
			if (ModelState.IsValid)
			{
				var responce = await mediator.Send(signIn);
				if (responce.Success)
				{

				return RedirectToAction("Confirmation");
				}
				else
				{
					foreach (var item in responce.ValidationErrors)
					{
						ModelState.AddModelError("All", item.Value);
					}
				}
				
			}

			
				
				var list = await mediator.Send(new AllCountriesQuery());
				var selectedList = new SelectList(list.Entity, "Id", "Name");
				ViewBag.CountryItems = selectedList;
				return View(signIn);
			
			

		}

		[HttpGet]
		public IActionResult SignIn()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> SignIn(LoginDTO model)
		{

			var user = await userManager.FindByEmailAsync(model.EMail);
			if (user != null)
			{
				var result = await signInManager.PasswordSignInAsync(user,model.Password,false,false);
				if (result.Succeeded)
				{
					var freelancer = await roleManager.FindByNameAsync("freelancer");
					var hirer = await roleManager.FindByNameAsync("owner");
					var admin = await roleManager.FindByNameAsync("admin");
					if (User.IsInRole(freelancer.Name)) return RedirectToAction("Projects", "Home", new { area="Freelancer"});
					if (User.IsInRole(hirer.Name)) return RedirectToAction("Main", "Home", new { area = "Hirer" });
				}

			}
			return View();
		}

		

		public IActionResult Confirmation()
		{
			return View();
		}
		public async Task<IActionResult> SignOut()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
	}
}
