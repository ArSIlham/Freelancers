using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FreelancersProject.Application.DTOs
{
	public class LoginDTO
	{

		[Required]
		public string EMail { get; set; }

		[Required]
		public string Password { get; set; }
	}
}
