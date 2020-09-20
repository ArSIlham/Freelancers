using FreelancersProject.Application.Common;
using FreelancersProject.Application.DTOs;
using FreelancersProject.Application.Services;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Infratructure;
using FreelancersProject.Persistence.Repositories.Concretes;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Queries.ProjectQueries
{
	public class ProjectDetails
	{
		public class ProjectDetailsRequest : IRequest<BaseResponses<ProjectDetailsDTO>>
		{
			public string ProjectId { get; set; }
		}

		public class ProjectDetailsHandler : IRequestHandler<ProjectDetailsRequest, BaseResponses<ProjectDetailsDTO>>
		{
			private readonly IProjectService projectService;
			private readonly IUnitOfWork unitOfWork;
			private readonly IBidRequestService bidRequestService;
			private readonly UserManager<ApplicationUser> userManager;
			private readonly ICountryService countryService;

			public ProjectDetailsHandler(IProjectService projectService, IUnitOfWork unitOfWork, 
				IBidRequestService bidRequestService, UserManager<ApplicationUser> userManager, ICountryService countryService)
			{
				this.projectService = projectService;
				this.unitOfWork = unitOfWork;
				this.bidRequestService = bidRequestService;
				this.userManager = userManager;
				this.countryService = countryService;
			}
			public async Task<BaseResponses<ProjectDetailsDTO>> Handle(ProjectDetailsRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<ProjectDetailsDTO> response = null;
				using (var trx = unitOfWork.BeginTransaction())
				{
					try
					{
						var project = await projectService.GetById(request.ProjectId);
						var bidRequests = await bidRequestService.GetBidRequestsByProjectId(request.ProjectId);
						var projectDetailsDTO = new ProjectDetailsDTO() { Project = project };
						foreach (var item in bidRequests)
						{
							var user = await userManager.FindByIdAsync(item.FreelancerId.ToString());
							var country = await countryService.GetById(user.CountryId.ToString());
							projectDetailsDTO.BidRequests.Add(new BidRequestDTO { BidRequest = item, FreeLancer = user, Country = country });

						}
						unitOfWork.SaveChanges();
						response = new BaseResponses<ProjectDetailsDTO>(projectDetailsDTO);

					}
					catch (RestException ex)
					{
						trx.Rollback();
						response = new BaseResponses<ProjectDetailsDTO>(ex.StatusCode, ex.Message);
						
					}
					return response;
				}
			}
		}
	}
}
