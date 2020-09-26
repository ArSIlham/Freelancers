using FreelancersProject.Domain.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Application.DTOs
{
   public class ProjectBidRequestDTO
    {

		public Project Project { get; set; }
		public List<BidRequestDTO> BidRequests { get; set; }
		public BidRequest bidrequests { get; set; }
		public ApplicationUser applicationUser { get; set; }
		public string ProjectId { get; set; }
		public ProjectBidRequestDTO()
		{
			BidRequests = new List<BidRequestDTO>();
		}
	}
}
