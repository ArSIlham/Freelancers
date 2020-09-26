using AutoMapper;
using FreelancersProject.Application.Common;
using FreelancersProject.Application.Services;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Infratructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Commands.ConfirmedBidCommands
{
	public class CreateConfirmedBid
	{

		public class ConfirmedBidRequest : IRequest<BaseResponses<ConfirmedBid>>
		{
			public string ProjectId { get; set; }
			public ConfirmedBid ConfirmedBid { get; set; }
		}

		public class ConfirmedBidHandler : IRequestHandler<ConfirmedBidRequest, BaseResponses<ConfirmedBid>>
		{
			private readonly IUnitOfWork unitOfWork;
			private readonly IMapper mapper;
			private readonly IConfirmedBidService confirmedBidService;
			private readonly IBidRequestService bidRequestService;
			
			private readonly IProjectService projectService;

			public ConfirmedBidHandler(IUnitOfWork unitOfWork, IMapper mapper, IConfirmedBidService confirmedBidService, IBidRequestService bidRequestService, IProjectService projectService)
			{
				this.unitOfWork = unitOfWork;
				this.mapper = mapper;
				this.confirmedBidService = confirmedBidService;
				this.bidRequestService = bidRequestService;
			
				this.projectService = projectService;
			}
			public async Task<BaseResponses<ConfirmedBid>> Handle(ConfirmedBidRequest request, CancellationToken cancellationToken)
			{
				


				BaseResponses<ConfirmedBid> responce = null;
				using (var trx = unitOfWork.BeginTransaction())
				{

					try
					{
						var confirmedBid = mapper.Map<ConfirmedBid>(request.ConfirmedBid);
						var result = await confirmedBidService.Add(confirmedBid);
						// bid requesti update elemek lazimdir
						var bidRequest = await bidRequestService.GetById(request.ConfirmedBid.BidId);
						var project = await projectService.GetById(request.ProjectId);
						bidRequest.IsConfirmed = true;
						project.Status = Statuses.Confirmed.ToString();
						var bidUpdateResult = await bidRequestService.Update(bidRequest);
						var projectUpateResult = await projectService.Update(project);
						unitOfWork.SaveChanges();

						responce = new BaseResponses<ConfirmedBid>(confirmedBid);
					}
					catch (RestException ex)
					{
						trx.Rollback();
						responce = new BaseResponses<ConfirmedBid>(ex.StatusCode, ex.Message);

					}

					return responce;

					
				}

			}
		}
	}
}
