using AutoMapper;
using FreelancersProject.Application.Common;
using FreelancersProject.Application.Handler.Base;
using FreelancersProject.Application.Services.Owner;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Infratructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Owner.Application.Handler.CQRS.Queries.ADDress
{
    public class DeleteOwner
    {
        public class DeleteOwnerRequest : IRequestWrapper<string>
        {
            public string Id { get; set; }
        }
        public class DeleteProductHandler : IHandlerWrapper<DeleteOwnerRequest, string>
        {
            private readonly IOwnerService AddressService;
            private readonly IUnitOfWork unitOfWork;
            private readonly IMapper mapper;

            public DeleteProductHandler(IOwnerService addressService, IUnitOfWork unitOfWork, IMapper mapper)
            {
                this.AddressService = addressService;
                this.unitOfWork = unitOfWork;
                this.mapper = mapper;
            }
            public async Task<BaseResponses<string>> Handle(DeleteOwnerRequest request, CancellationToken cancellationToken)
            {
                BaseResponses<string> responses = null;
                using (var trx = unitOfWork.BeginTransaction())
                {
                    try
                    {
                        var data = await AddressService.Delete(request.Id);
                        unitOfWork.SaveChanges();
                        responses = new BaseResponses<string>("OK");
                    }
                    catch (RestException ex)
                    {
                        trx.Rollback();
                        responses = new BaseResponses<string>(ex.StatusCode, ex.Message);
                    }
                }
                return responses;
            }
        }
    }
}
