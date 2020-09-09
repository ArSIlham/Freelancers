using FreelancersProject.Domain.Bases;

using System;

namespace FreelancersProject.Domain.Concretes
{
	public class BidRequest : BaseEntity<Guid>
	{
		
		
		public Guid FreelancerId { get; set; }
		public Guid ProjectId { get; set; }
		public decimal BidPrice { get; set; }
		public DateTime CreateDate { get; set; }
		public bool IsConfirmed { get; set; }


	}

}