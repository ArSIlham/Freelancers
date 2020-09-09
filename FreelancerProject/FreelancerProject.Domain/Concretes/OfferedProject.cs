using FreelancersProject.Domain.Bases;
using Identity.Dapper.Entities;
using System;

namespace FreelancersProject.Domain.Concretes
{
	public class OfferedProject : DapperIdentityUser, IBaseEntity<Guid>
	{
		Guid IBaseEntity<Guid>.Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }

		public Guid FreelancerId { get; set; }
		public decimal Price { get; set; }

		public DateTime OfferedDate { get; set; }

		public bool IsAccepted { get; set; }

		public int DeadlineDaysCount { get; set; }

		public DateTime AcceptedDate { get; set; }

		
	}
}