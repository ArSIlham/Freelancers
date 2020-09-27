using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Application.DTOs
{
	public class ProjectManagementDTOcs
	{
		public string ProjectId { get; set; }
		public string ProjectName { get; set; }
		public string Status { get; set; }
		public DateTime CreatedDate { get; set; }
		public string ProjectOwnerName { get; set; }
		public decimal MinPrice { get; set; }
		public decimal MaxPrice { get; set; }
		
	}
}
