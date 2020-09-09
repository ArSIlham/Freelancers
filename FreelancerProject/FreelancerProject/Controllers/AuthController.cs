using FreelancersProject.Domain.Concretes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Controllers
{
	public class AuthController :Controller
	{
		

		
		public ActionResult Index()
		{
			//roleManager.CreateAsync(new Role() { Name = "Admin" });
			//var data=await roleStore.CreateAsync(new Role() { Name = "Admin" }, CancellationToken.None);
			
			return View();
		}
	}
}
