using AutoMapper;
using FreelancersProject.Application.Common;
using FreelancersProject.Application.Handler.Base;
using FreelancersProject.Application.Services;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Infratructure;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands
{
    public class GetAllMyProject
    {
        public class GetAllMyProjectRequest : IRequestWrapper<List<Project>>
        {
            public string id { get; set; }
        }
        public class GetAllMyProjectHandler : IHandlerWrapper<GetAllMyProjectRequest, List<Project>>
        {
            private readonly IProjectService AddressService;
            private readonly IUnitOfWork unitOfWork;
            private readonly IMapper mapper;





            public GetAllMyProjectHandler(IProjectService AddressService, IUnitOfWork unitOfWork, IMapper mapper)
            {
                this.AddressService = AddressService;
                this.unitOfWork = unitOfWork;
                this.mapper = mapper;
            }

            public async Task<BaseResponses<List<Project>>> Handle(GetAllMyProjectRequest request, CancellationToken cancellationToken)
            {


            BaseResponses<List<Project>> responses = null;
                using (var trx = unitOfWork.BeginTransaction())
                {
                    try
                    {
                        var data = await AddressService.GetFreelancermyProject(request.id.ToString());
                        responses = new BaseResponses<List<Project>>(data.ToList());
                    }
                    catch (RestException ex)
                    {
                        responses = new BaseResponses<List<Project>>(ex.StatusCode, ex.Message);
                    }
                }

                return responses;
            }
        }
    }
}
