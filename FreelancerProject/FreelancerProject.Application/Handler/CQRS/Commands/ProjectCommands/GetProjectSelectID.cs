using AutoMapper;
using FreelancersProject.Application.Common;
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
   public class GetProjectSelectID
    {


		public class GetProjectSelectIDRequest : IRequest<BaseResponses<Project>>
		{
			[Required]
			public Guid ID { get; set; }




		}
		public class GetProjectSelectIDHandler : IRequestHandler<GetProjectSelectIDRequest, BaseResponses<Project>>
		{
			private readonly IMapper mapper;
			private readonly IProjectService projectService;
			private readonly UserManager<ApplicationUser> userManager;
			private readonly IUnitOfWork unitOfWork;

			public GetProjectSelectIDHandler(IMapper mapper, IProjectService projectService, UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
			{
				this.mapper = mapper;
				this.projectService = projectService;
				this.userManager = userManager;
				this.unitOfWork = unitOfWork;
			}
			public async Task<BaseResponses<Project>> Handle(GetProjectSelectIDRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<Project> response = null;
				using (var trx = unitOfWork.BeginTransaction())
				{
					try
					{

						var data = await projectService.GetById(request.ID.ToString());
						
						unitOfWork.SaveChanges();
						response = new BaseResponses<Project>(data);

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

