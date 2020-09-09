using FreelancersProject.Domain.Bases;
using Identity.Dapper.Entities;
using System;

namespace FreelancersProject.Domain.Concretes
{
	public class Country : DapperIdentityUser, IBaseEntity<Guid>
	{
		Guid IBaseEntity<Guid>.Id { get; set; }
		public string Name { get; set; }
	}
}