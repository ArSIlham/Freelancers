using AutoMapper;
using FreelancersProject.Application.Handler.CQRS.Queries;
using FreelancersProject.Domain.Owner;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Application.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateOwner.AddOwnerRequest, OwnerModel>();






        }
    }
}
