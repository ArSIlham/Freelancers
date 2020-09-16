using FreelancersProject.Domain.Bases;

using System;

namespace FreelancersProject.Domain.Concretes
{
	public class OfferedProject : BaseEntity<Guid>
	{
		
		public string Title { get; set; }
		public string Description { get; set; }

		public int FreelancerId { get; set; }
		public int OwnerId { get; set; }
		public decimal Price { get; set; }

		public DateTime OfferedDate { get; set; }

		public bool IsAccepted { get; set; }

		public int DeadlineDaysCount { get; set; }

		public DateTime AcceptedDate { get; set; }

		
	}
}