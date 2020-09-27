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
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Queries.ProjectQueries
{
	public class AllProjectList 
	{

		public class AllProjectRequest : IRequest<BaseResponses<IEnumerable<ProjectManagementDTOcs>>>
		{

		}

		public class AllProjectHandler : IRequestHandler<AllProjectRequest, BaseResponses<IEnumerable<ProjectManagementDTOcs>>>
		{
			private readonly IMapper mapper;
			private readonly UserManager<ApplicationUser> userManager;
			private readonly IProjectService projectService;
			private readonly IUnitOfWork unitOfWork;

			public AllProjectHandler(IMapper mapper, UserManager<ApplicationUser> userManager, IProjectService projectService 
				,IUnitOfWork unitOfWork)
			{
				this.mapper = mapper;
				this.userManager = userManager;
				this.projectService = projectService;
				this.unitOfWork = unitOfWork;
			}
			public async  Task<BaseResponses<IEnumerable<ProjectManagementDTOcs>>> Handle(AllProjectRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<IEnumerable<ProjectManagementDTOcs>> response = null;

				using (var trx = unitOfWork.BeginTransaction())
				{
					try
					{
						var projects = await projectService.GetAll();
						var projectDtos = new List<ProjectManagementDTOcs>();
						foreach (var item in projects)
						{
							var user = await userManager.FindByIdAsync(item.OwnerId.ToString());
							var data = new ProjectManagementDTOcs()
							{
								CreatedDate = item.CreateDate,
								MaxPrice = item.MaxPrice,
								MinPrice = item.MinPrice,
								ProjectName = item.Title,
								ProjectOwnerName = $"{user.Name} {user.SurName}",
								ProjectId = item.Id.ToString(),
								Status=item.Status

							};
							projectDtos.Add(data);


						}
						unitOfWork.SaveChanges();
						response = new BaseResponses<IEnumerable<ProjectManagementDTOcs>>(projectDtos);
					}
					catch (RestException ex)
					{
						trx.Rollback();
						response = new BaseResponses<IEnumerable<ProjectManagementDTOcs>>(ex.StatusCode, ex.Message);
					}
					return response;
				}
			}
		}
	}
}
