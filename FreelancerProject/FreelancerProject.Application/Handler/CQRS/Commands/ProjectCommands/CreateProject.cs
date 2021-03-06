﻿using AutoMapper;
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
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands
{
	public class CreateProject
	{

		public class CreateProjectRequest : IRequest<BaseResponses<Project>>
		{
			[Required]
			public string Title { get; set; }
			[Required]
			public string Description { get; set; }

			[Required]
			public decimal MinPrice { get; set; }
		
			[Required]
			public decimal MaxPrice { get; set; }
			[NotMapped]
			public string OwnerName { get; set; }

			[NotMapped]
			public int OwnerId { get; set; }
			[NotMapped]
			public DateTime CreateDate { get; set; } = DateTime.Now;
			[NotMapped]
			public string Status { get; set; } = Statuses.Pending.ToString();

			public List<SkillListDTO> Skills { get; set; }



		}
		public class CreateProjectHandler : IRequestHandler<CreateProjectRequest, BaseResponses<Project>>
		{
			private readonly IMapper mapper;
			private readonly IProjectService projectService;
			private readonly UserManager<ApplicationUser> userManager;
			private readonly IUnitOfWork unitOfWork;

			public CreateProjectHandler(IMapper mapper, IProjectService projectService, UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
			{
				this.mapper = mapper;
				this.projectService = projectService;
				this.userManager = userManager;
				this.unitOfWork = unitOfWork;
			}
			public async Task<BaseResponses<Project>> Handle(CreateProjectRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<Project> response = null;
				using (var trx = unitOfWork.BeginTransaction())
				{
					try
					{
						var user = await userManager.FindByNameAsync(request.OwnerName);
						request.OwnerId = user.Id;
						var project = mapper.Map<Project>(request);
						var result = await projectService.Add(project);
						var projectSkills = new List<ProjectSkill>();
						foreach (var item in request.Skills)
						{
							if (item.IsChecked)
							{
								projectSkills.Add(new ProjectSkill { ProjectId = result.Id, SkillId = item.Id });

							}
						}
						await projectService.AddSkillsToProject(projectSkills);
						unitOfWork.SaveChanges();
						response = new BaseResponses<Project>(result);

					}
					catch (RestException ex)
					{
						trx.Rollback();
						response = new BaseResponses<Project>(ex.StatusCode, ex.Message);

					}

					return response;
				}
			}
		}
	}
}
