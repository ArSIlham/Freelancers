using AutoMapper;
using FreelancersProject.Application.Common;
using FreelancersProject.Application.DTOs;
using FreelancersProject.Application.Services;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Infratructure;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands
{
    public class ProjectComment
    {
	public class ProjectCommentRequest : IRequest<BaseResponses<ProjectBidRequestDTO>>
		{
			public decimal BidPrice { get; set; }
			public string Comment { get; set; }
			public Guid ProjectID { get; set; }
			public string FreekancerName { get; set; }
		}

		public class ProjectCommentHandler : IRequestHandler<ProjectCommentRequest, BaseResponses<ProjectBidRequestDTO>>
		{
			private readonly IProjectService projectService;
			private readonly IUnitOfWork unitOfWork;
			private readonly IBidRequestService bidRequestService;
			private readonly UserManager<ApplicationUser> userManager;
			private readonly ICountryService countryService;

			public ProjectCommentHandler(IProjectService projectService, IUnitOfWork unitOfWork, 
				IBidRequestService bidRequestService, UserManager<ApplicationUser> userManager, ICountryService countryService)
			{
				this.projectService = projectService;
				this.unitOfWork = unitOfWork;
				this.bidRequestService = bidRequestService;
				this.userManager = userManager;
				this.countryService = countryService;
			}
			public async Task<BaseResponses<ProjectBidRequestDTO>> Handle(ProjectCommentRequest request, CancellationToken cancellationToken)
			{
				
				BaseResponses<ProjectBidRequestDTO> response = null;
				using (var trx = unitOfWork.BeginTransaction())
				{
					try
					{
						if(request.Comment != null)
						{
							var user1 = userManager.FindByNameAsync(request.FreekancerName);
							//ApplicationUser appuser = new ApplicationUser();
							//appuser = user1.Result;
							BidRequest bid = new BidRequest();
							bid.BidPrice = request.BidPrice;
							bid.Comment = request.Comment;
							bid.ProjectId = request.ProjectID.ToString();
							bid.FreelancerId = user1.Result.Id;
							await bidRequestService.Add(bid);
						}
						var project = await projectService.GetById(request.ProjectID.ToString());
						var bidRequests = await bidRequestService.GetBidRequestsByProjectId(request.ProjectID.ToString());
						var projectDetailsDTO = new ProjectBidRequestDTO() { Project = project };
						foreach (var item in bidRequests)
						{
							var user = await userManager.FindByIdAsync(item.FreelancerId.ToString());
							
							projectDetailsDTO.BidRequests.Add(
								new BidRequestDTO { 
								BidRequest = item, 
								FreeLancer = user
							});

						}
						unitOfWork.SaveChanges();
						response = new BaseResponses<ProjectBidRequestDTO>(projectDetailsDTO);

					}
					catch (RestException ex)
					{
						trx.Rollback();
						response = new BaseResponses<ProjectBidRequestDTO>(ex.StatusCode, ex.Message);
						
					}
					return response;
				}
			}
		}
	}
}
