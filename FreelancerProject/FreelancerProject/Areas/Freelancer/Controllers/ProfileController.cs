using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FreelancersProject.Areas.Freelancer.Controllers
{
	public class ProfileController : Controller
	{
		public IActionResult Settings()
		{
			return View();
		}
	}
}
