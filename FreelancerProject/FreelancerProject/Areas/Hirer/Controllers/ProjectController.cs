using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FreelancersProject.Areas.Hirer.Controllers
{
	[Area("Freelancer")]
	//[Authorize(Roles ="Freelancer")]
	public class ProjectController : Controller
	{
		public IActionResult MyProjectss()
		{
			return View();
		}
		public IActionResult CreateProject()
		{
			return View();
		}
		public IActionResult OfferProject()
		{
			return View();
		}
	}
}
