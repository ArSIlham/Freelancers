using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FreelancersProject.Application.DTOs;
using FreelancersProject.Application.Handler.CQRS.Commands.LoginCommands;
using FreelancersProject.Application.Handler.CQRS.Queries.UserListQueries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FreelancersProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = "Admin")]
	public class UserController : Controller
	{
		private readonly IMediator mediator;

		public UserController(IMediator mediator)
		{
			this.mediator = mediator;
		}
		[HttpGet]
		public IActionResult CreateUser()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateUser(CreateAdmin.CreateAdminRequest model)
		{
			ModelState.Clear();
			if (ModelState.IsValid)
			{
				var responce = await mediator.Send(model);
				if (responce.Success)
				{

					return RedirectToAction("Index", "Home", new { Ares="Admin"});
				}
				else
				{
					foreach (var item in responce.ValidationErrors)
					{
						ModelState.AddModelError("All", item.Value);
					}
				}

			}



			
			return View(model);
		}

		[HttpGet]

		public IActionResult GetAllUsers()
		{
			return View();
		}

		[HttpPost]

		public IActionResult GetAllUsers(string rolename)
		{

			ViewBag.RoleName = rolename;

			return View();

		}


		public async Task<IActionResult> Delete(string userEmail)
		{

			var result = await mediator.Send(new DeleteUser.DeletUserRequest{Email=userEmail });
			if (result.StatusCode == HttpStatusCode.OK)
			{
				return RedirectToAction("GetAllUsers");
			}
			else
			{
				var error = new ErrorPageDTO() { StatusCode = result.StatusCode, Errors = result.Errors, Success = result.Success };
				return RedirectToAction("ResponsePage", "Home", new { Area="Hirer", model= error });
			}
			

		}

	}
}
