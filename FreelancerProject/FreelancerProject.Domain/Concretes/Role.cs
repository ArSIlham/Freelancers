using FreelancersProject.Domain.Bases;
using Identity.Dapper.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Domain.Concretes
{
	public class Role : DapperIdentityUser//, IBaseEntity<Guid>
	{
		//Guid IBaseEntity<Guid>.Id { get; set; }
		public string Name { get; set; }
		public string NormalizedName { get; set; }
	}
}
