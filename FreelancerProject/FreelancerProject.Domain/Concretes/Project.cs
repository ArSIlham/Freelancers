using FreelancersProject.Domain.Bases;

using System;

namespace FreelancersProject.Domain.Concretes
{
	public class Project : BaseEntity<Guid>
	{
		
		public string Title { get; set; }
		public string Description { get; set; }

		public decimal MinPrice { get; set; }
		public decimal MaxPrice { get; set; }
		public int OwnerId { get; set; }
		public DateTime CreateDate { get; set; }
		public string Status { get; set; }
	}
}