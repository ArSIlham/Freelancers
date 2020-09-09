using FreelancersProject.Domain.Bases;

using System;

namespace FreelancersProject.Domain.Concretes
{
	public class Country : BaseEntity<Guid>
	{
		
		public string Name { get; set; }
	}
}