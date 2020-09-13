using AutoMapper;
using FreelancersProject.Application.Common;
using FreelancersProject.Application.Services;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.CustomException;
using MediatR;
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
			
			public string Title { get; set; }
			
			public string Description { get; set; }

			
			public decimal MinPrice { get; set; }
		
			public decimal MaxPrice { get; set; }

			[NotMapped]
			public Guid OwnerId { get; set; }
			[NotMapped]
			public DateTime CreateDate { get; set; } = DateTime.Now;
			[NotMapped]
			public string Status { get; set; } = Statuses.Pending.ToString();



		}
		public class CreateProjectHandler : IRequestHandler<CreateProjectRequest, BaseResponses<Project>>
		{
			private readonly IMapper mapper;
			private readonly IProjectService projectService;

			public CreateProjectHandler(IMapper mapper, IProjectService projectService)
			{
				this.mapper = mapper;
				this.projectService = projectService;
			}
			public async Task<BaseResponses<Project>> Handle(CreateProjectRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<Project> response = null;
				try
				{
					var project = mapper.Map<Project>(request);
					var result =  await projectService.Add(project);
					response = new BaseResponses<Project>(result);
				}
				catch (RestException ex)
				{
					response = new BaseResponses<Project>(ex.StatusCode, ex.Message);
					
				}

				return response;
			}
		}
	}
}
