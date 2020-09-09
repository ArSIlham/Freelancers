using FreelancersProject.Domain.Bases;
using Identity.Dapper.Entities;
using System;

namespace FreelancersProject.Domain.Concretes
{
	public class Project : DapperIdentityUser, IBaseEntity<Guid>
	{
		Guid IBaseEntity<Guid>.Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }

		public decimal MinPrice { get; set; }
		public decimal MaxPrice { get; set; }
		public Guid OwnerId { get; set; }
		public DateTime CreateDate { get; set; }
		public string Status { get; set; }
	}
}