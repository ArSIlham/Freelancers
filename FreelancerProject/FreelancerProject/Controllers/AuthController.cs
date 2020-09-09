using FreelancersProject.Domain.Concretes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancersProject.Controllers
{
	public class AuthController :Controller
	{
		private readonly RoleManager<Role> roleManager;

		public AuthController(RoleManager<Role> roleManager)
		{
			this.roleManager = roleManager;
		}
		public IActionResult Index()
		{
			roleManager.CreateAsync(new Role() { Name = "Admin" });
			return View();
		}
	}
}
