using FreelancersProject.Domain.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Application.DTOs
{
	public class OfferedProjectDTO
	{
		public OfferedProject OfferedProject { get; set; }

		public ApplicationUser FreeLancer { get; set; }

		public Country FreeLancerCountry { get; set; }
	}
}
