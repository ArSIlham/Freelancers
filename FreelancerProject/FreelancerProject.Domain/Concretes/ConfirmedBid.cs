using FreelancersProject.Domain.Bases;

using System;

namespace FreelancersProject.Domain.Concretes
{
	public class ConfirmedBid : BaseEntity<Guid>
	{
		
		public string BidId { get; set; }
		public DateTime DeadlineDate { get; set; }
		public DateTime ConfirmedDate { get; set; }
	}
}