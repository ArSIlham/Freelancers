using FreelancersProject.Domain.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Application.DTOs
{
	public class ProjectDetailsDTO
	{
		public Project Project { get; set; }
		public List<BidRequestDTO> BidRequests { get; set; }
		public string ProjectId { get; set; }
		public ConfirmedBid ConfirmedBid { get; set; }
		public ProjectDetailsDTO()
		{
			BidRequests = new List<BidRequestDTO>();
		}
	}
}
