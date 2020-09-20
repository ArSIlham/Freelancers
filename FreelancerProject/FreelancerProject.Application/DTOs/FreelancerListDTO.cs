using FreelancersProject.Domain.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Application.DTOs
{
	public class FreelancerListDTO
	{
		public ApplicationUser User { get; set; }

		public IEnumerable<Skill> FreelancerSkils { get; set; }
		public Country Country { get; set; }
	}
}
