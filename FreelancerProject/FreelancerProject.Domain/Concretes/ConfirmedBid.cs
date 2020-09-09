using FreelancersProject.Domain.Bases;
using Identity.Dapper.Entities;
using System;

namespace FreelancersProject.Domain.Concretes
{
	public class ConfirmedBid : DapperIdentityUser, IBaseEntity<Guid>
	{
		Guid IBaseEntity<Guid>.Id { get; set; }
		public Guid BidId { get; set; }
		public DateTime DeadlineDate { get; set; }
		public DateTime ConfirmedDate { get; set; }
	}
}