using FreelancersProject.Domain.Bases;

using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Domain.Concretes
{
	public class User : BaseEntity<Guid>
	{
		
		public string FisrtName { get; set; }
		public string LastName { get; set; }
		public  string  Email { get; set; }
		public string NormalizedEmail { get; set; }
		public string Password { get; set; }
		public string ImageUrl { get; set; }
		public Guid CountryId { get; set; }
	}
}
