using FreelancersProject.Domain.Bases;

using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Domain.Concretes
{
	public class ApplicationRole : BaseEntity<int>
	{
	
		public string Name { get; set; }
		public string NormalizedName { get; set; }
	}
}
