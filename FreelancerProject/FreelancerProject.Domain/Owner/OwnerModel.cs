using FreelancersProject.Domain.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Domain.Owner
{
    public class OwnerModel : BaseEntity<Guid>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public string Projects { get; set; }
        public int Country { get; set; }
        public int Skils { get; set; }
        public int Roles { get; set; }

    }
}
