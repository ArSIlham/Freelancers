using AutoMapper;
using FreelancersProject.Application.Common;
using FreelancersProject.Application.Handler.Base;
using FreelancersProject.Application.Services.Owner;
using FreelancersProject.Domain.Owner;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Infratructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Queries
{

    public class CreateOwner
    {
        public class AddOwnerRequest : BaseRequest, IRequestWrapper<OwnerModel>
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string ImageUrl { get; set; }
            public string Projects { get; set; }
            public int Country { get; set; }
            public int Skils { get; set; }
            public int Roles { get; set; }
        }

        public class AddOwnerHandler : IHandlerWrapper<AddOwnerRequest, OwnerModel>
        {
            private readonly IMapper mapper;
            private readonly IOwnerService addressService;
            private readonly IUnitOfWork unitOfWork;

            public AddOwnerHandler(IMapper mapper, IOwnerService AddressService, IUnitOfWork unitOfWork)
            {
                this.mapper = mapper;
                addressService = AddressService;
                this.unitOfWork = unitOfWork;
            }
            public async Task<BaseResponses<OwnerModel>> Handle(AddOwnerRequest request, CancellationToken cancellationToken)
            {
                BaseResponses<OwnerModel> responses = null;
                using (var trx = unitOfWork.BeginTransaction())
                {
                    try
                    {
                        var mapData = mapper.Map<OwnerModel>(request);
                        var data = await addressService.Add(mapData);
                        responses = new BaseResponses<OwnerModel>(data);
                        unitOfWork.SaveChanges();
                    }
                    catch (RestException ex)
                    {
                        trx.Rollback();
                        responses = new BaseResponses<OwnerModel>(ex.Code, ex.Message);
                    }
                    return responses;
                }
            }
        }
    }
}


