using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreelancersProject.Application.DTOs;
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
		public IActionResult ResponsePage(ErrorPageDTO model)
		{
			return View(model);
		}
	}
}
