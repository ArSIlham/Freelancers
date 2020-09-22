using AutoMapper;
using FreelancersProject.Application.Handler.CQRS.Commands.ConfirmedBidCommands;
using FreelancersProject.Application.Handler.CQRS.Commands.LoginCommands;
using FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands;
using FreelancersProject.Application.Handler.CQRS.Queries;
using FreelancersProject.Domain.Concretes;
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

            CreateMap<SignIn.SignInRequest, ApplicationUser>();
            CreateMap<CreateProject.CreateProjectRequest, Project>();
            CreateMap<OfferProject.OfferProjectRequest, OfferedProject>();
            CreateMap<CreateConfirmedBid.ConfirmedBidRequest, ConfirmedBid>();




        }
    }
}
