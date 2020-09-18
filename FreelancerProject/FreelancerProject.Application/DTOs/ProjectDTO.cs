using FreelancersProject.Domain.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Application.DTOs
{
	public class ProjectDTO
	{
		public Project Project { get; set; }
		public IEnumerable<Skill> ProjectSkills { get; set; }
	}
}
