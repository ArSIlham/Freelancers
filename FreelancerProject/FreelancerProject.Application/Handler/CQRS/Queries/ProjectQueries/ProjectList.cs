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
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Queries.ProjectQueries
{
	public class ProjectList
	{
		public class ProjectListRequest : IRequest<BaseResponses<IEnumerable<ProjectDTO>>>
		{
			public string Username { get; set; }
		}

		public class ProjectListHandler : IRequestHandler<ProjectListRequest, BaseResponses<IEnumerable<ProjectDTO>>>
		{
			private readonly IProjectService projectService;
			private readonly ISkillService skillService;
			private readonly UserManager<ApplicationUser> userManager;
			private readonly IUnitOfWork unitOfWork;

			public ProjectListHandler(IProjectService projectService, ISkillService skillService,
				UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
			{
				this.projectService = projectService;
				this.skillService = skillService;
				this.userManager = userManager;
				this.unitOfWork = unitOfWork;
			}
			public async Task<BaseResponses<IEnumerable<ProjectDTO>>> Handle(ProjectListRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<IEnumerable<ProjectDTO>> response = null;
				if (!string.IsNullOrEmpty(request.Username))
				{
					using (var trx = unitOfWork.BeginTransaction())
					{
						try
						{
							var user = await userManager.FindByNameAsync(request.Username);
							var projects = await projectService.GetProjectByOwnerId(user.Id);
							var projectDto = new List<ProjectDTO>();
							foreach (var item in projects)
							{
								var skills = await skillService.GetProjectSkills(item.Id);
								projectDto.Add(new ProjectDTO { Project = item, ProjectSkills = skills });
								
							}
							response = new BaseResponses<IEnumerable<ProjectDTO>>(projectDto);
							unitOfWork.SaveChanges();
						}
						catch (RestException ex)
						{

							trx.Rollback();
							response = new BaseResponses<IEnumerable<ProjectDTO>>(ex.StatusCode, ex.Message);
						}

					}

				}
				return response;
			}
		}
	}
}
