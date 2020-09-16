using FreelancersProject.Domain.Bases;

using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Domain.Concretes
{
	public class ApplicationUser : BaseEntity<int>
	{
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }

        public string NormalizedUserName { get; set; }

        public string Email { get; set; }

        public string NormalizedEmail { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }
        public string ImageUrl { get; set; }
		public Guid CountryId { get; set; }
	}
}
