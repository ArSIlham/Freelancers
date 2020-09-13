using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FreelancersProject.Areas.Freelancer.Controllers
{
	[Area("Freelancer")]
	[Authorize(Roles ="Freelancer")]
	public class HomeController : Controller
	{
		public IActionResult Projects()
		{
			return View();
		}
	}
}
