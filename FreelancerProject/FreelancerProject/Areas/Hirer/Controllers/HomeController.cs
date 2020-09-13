using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FreelancersProject.Areas.Hirer.Controllers
{
	[Area("Hirer")]
	//[Authorize(Roles ="Owner")]
	public class HomeController : Controller
	{
		public IActionResult Main()
		{
			return View();
		}
	}
}
