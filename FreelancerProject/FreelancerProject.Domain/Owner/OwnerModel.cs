using FreelancersProject.Domain.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Domain.Owner
{
    public class OwnerModel : IBaseEntity<Guid>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public string Projects { get; set; }
        public int Country { get; set; }
        public int Skils { get; set; }
        public int Roles { get; set; }
		public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
