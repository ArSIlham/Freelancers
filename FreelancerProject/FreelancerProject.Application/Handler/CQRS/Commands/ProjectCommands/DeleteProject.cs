using FreelancersProject.Application.Common;
using FreelancersProject.Application.Services;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.Infratructure;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static FreelancersProject.Application.Handler.CQRS.Commands.LoginCommands.DeleteUser;

namespace FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands
{
   public class DeleteProject
	{
		public class DeleteProjectRequest : IRequest<BaseResponses<string>>
		{
			public string ProjectId { get; set; }
		}

		public class DeleteUserHandler : IRequestHandler<DeleteProjectRequest, BaseResponses<string>>
		{
			private readonly IProjectService projectService;
			private readonly IUnitOfWork unitOfWork;

			public DeleteUserHandler(IProjectService projectService, IUnitOfWork unitOfWork)
			{
				this.projectService = projectService;
				this.unitOfWork = unitOfWork;
			}

			public async Task<BaseResponses<string>> Handle(DeleteProjectRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<string> responce = null;
				using (var trx = unitOfWork.BeginTransaction())
				{
					try
					{
						var project = await projectService.GetById(request.ProjectId);
						if (project.Status != Statuses.Confirmed.ToString())
						{
							var result = await projectService.Delete(request.ProjectId);
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
