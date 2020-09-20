using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace FreelancersProject.Application.DTOs
{
	public class ErrorPageDTO
	{
		public bool Success { get; set; }
		public string Errors { get; set; }
		public HttpStatusCode StatusCode { get; set; }
	}
}
