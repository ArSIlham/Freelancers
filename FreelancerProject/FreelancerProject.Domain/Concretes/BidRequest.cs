using FreelancersProject.Domain.Bases;

using System;

namespace FreelancersProject.Domain.Concretes
{
	public class BidRequest : BaseEntity<Guid>
	{
		
		
		public int FreelancerId { get; set; }
		public string ProjectId { get; set; }
		public decimal BidPrice { get; set; }
		public DateTime CreateDate { get; set; } = DateTime.Now;
		public bool IsConfirmed { get; set; } = false;
		public string Comment { get; set; }


	}

}