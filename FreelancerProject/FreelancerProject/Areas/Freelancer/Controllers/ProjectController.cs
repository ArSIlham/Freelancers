using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FreelancersProject.Areas.Freelancer.Controllers
{
	[Area("Freelancer")]
	public class ProjectController : Controller
	{
		
		
		public IActionResult MyProjects()
		{

			return View();
		}

		public IActionResult MyMessages()
		{
			return View();
		}
	}
}
