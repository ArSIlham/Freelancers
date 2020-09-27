using FreelancersProject.Application.Common;
using FreelancersProject.Application.Services;
using FreelancersProject.Persistence.Infratructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands.DeleteProject;

namespace FreelancersProject.Application.Handler.CQRS.Commands.ConfirmedBidCommands
{
	public class DeleteBid
	{

		public class DeleteBidRequest : IRequest<BaseResponses<string>>
		{
			public string BidRequestId { get; set; }
		}

		public class DeleteBidHandler : IRequestHandler<DeleteBidRequest, BaseResponses<string>>
		{
			
             private readonly IBidRequestService bidRequestService;
			private readonly IUnitOfWork unitOfWork;

			public DeleteBidHandler(IBidRequestService bidRequestService, IUnitOfWork unitOfWork)
			{
				this.bidRequestService = bidRequestService;
				this.unitOfWork = unitOfWork;
			}

			public async Task<BaseResponses<string>> Handle(DeleteBidRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<string> responce = null;
				using (var trx = unitOfWork.BeginTransaction())
				{
					try
					{
						var bidrequest = await bidRequestService.GetById(request.BidRequestId);
						if (!bidrequest.IsConfirmed )
						{
							var result = await bidRequestService.Delete(request.BidRequestId);
							unitOfWork.SaveChanges();
							responce = new BaseResponses<string>(result);
						}

					}
					catch (Exception ex)
					{
						trx.Rollback();
						responce = new BaseResponses<string>(System.Net.HttpStatusCode.BadRequest, ex.Message);
					}
					return responce;
				}

			}
		}
	}
}
