using FreelancersProject.Domain.Bases;
using Identity.Dapper.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Domain.Concretes
{
	public class User : DapperIdentityUser//,IBaseEntity<Guid>
	{
		//Guid IBaseEntity<Guid>.Id { get; set; }
		public string FisrtName { get; set; }
		public string LastName { get; set; }
		public override string  Email { get; set; }
		public string NormalizedEmail { get; set; }
		public string Password { get; set; }
		public string ImageUrl { get; set; }
		public Guid CountryId { get; set; }
	}
}
