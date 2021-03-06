﻿using AutoMapper;
using FreelancersProject.Application.Common;
using FreelancersProject.Application.Handler.Base;
using FreelancersProject.Application.Services.Owner;
using FreelancersProject.Domain.Owner;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Infratructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Queries
{
    public class GettAllProject
    {
        public class GetAllProjectRequest : IRequestWrapper<List<OwnerModel>>
        {
        }
        public class GetAllOwnerHandler : IHandlerWrapper<GetAllProjectRequest, List<OwnerModel>>
        {
            private readonly IOwnerService AddressService;
            private readonly IUnitOfWork unitOfWork;
            private readonly IMapper mapper;

            public GetAllOwnerHandler(IOwnerService AddressService, IUnitOfWork unitOfWork, IMapper mapper)
            {
                this.AddressService = AddressService;
                this.unitOfWork = unitOfWork;
                this.mapper = mapper;
            }

            public async Task<BaseResponses<List<OwnerModel>>> Handle(GetAllProjectRequest request, CancellationToken cancellationToken)
            {
                BaseResponses<List<OwnerModel>> responses = null;
                using (var trx = unitOfWork.BeginTransaction())
                {
                    try
                    {
                        var data = await AddressService.GetAll();
                        responses = new BaseResponses<List<OwnerModel>>(data.ToList());
                    }
                    catch (RestException ex)
                    {
                        responses = new BaseResponses<List<OwnerModel>>(ex.StatusCode, ex.Message);
                    }
                }

                return responses;
            }
        }
    }
}
