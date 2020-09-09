using FreelancersProject.Domain.Bases;
using Identity.Dapper.Entities;
using System;

namespace FreelancersProject.Domain.Concretes
{
	public class BidRequest : DapperIdentityUser, IBaseEntity<Guid>
	{
		
		Guid IBaseEntity<Guid>.Id { get; set; }
		public Guid FreelancerId { get; set; }
		public Guid ProjectId { get; set; }
		public decimal BidPrice { get; set; }
		public DateTime CreateDate { get; set; }
		public bool IsConfirmed { get; set; }


	}

}