using FreelancersProject.Domain.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Application.DTOs
{
	public class BidRequestDTO 
	{
		public BidRequest BidRequest { get; set; }
		public ApplicationUser FreeLancer { get; set; }
		public Country Country { get; set; }

		
	}
}
