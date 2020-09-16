using FreelancersProject.Domain.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Domain.Concretes
{
	public class ProjectSkill : BaseEntity<Guid>
	{
		public Guid ProjectId { get; set; }
		public Guid SkillId { get; set; }
	}
}
