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
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands
{
	public class OfferProject
	{
		public class OfferProjectRequest : IRequest<BaseResponses<OfferedProject>>
		{
			[Required]
			public string Title { get; set; }
			[Required]
			public string Description { get; set; }
			[NotMapped]
			public int FreelancerId { get; set; }
			[NotMapped]
			public int OwnerId { get; set; }
			[Required]
			[Range(0,99999999999)]
			public decimal Price { get; set; }
			[NotMapped]
			public DateTime OfferedDate { get; set; } = DateTime.Now;

			public bool IsAccepted { get; set; } = false;

			[Required]
			[Range(0,9999999999999999999.99)]
			public int DeadlineDayCounts { get; set; }
			[NotMapped]
			public DateTime AcceptedDate { get; set; } = new DateTime(1990, 01, 01);
			[NotMapped]
			public string OwnerUserName { get; set; }
		}

		public class OfferProjectHandler : IRequestHandler<OfferProjectRequest, BaseResponses<OfferedProject>>
		{
			private readonly IUnitOfWork unitOfWork;
			private readonly IMapper mapper;
			private readonly IOfferProjectService offerProjectService;
			private readonly UserManager<ApplicationUser> userManager;

			public OfferProjectHandler(IUnitOfWork unitOfWork,
				IMapper mapper, IOfferProjectService offerProjectService, UserManager<ApplicationUser> userManager)
			{
				this.unitOfWork = unitOfWork;
				this.mapper = mapper;
				this.offerProjectService = offerProjectService;
				this.userManager = userManager;
			}
			public async  Task<BaseResponses<OfferedProject>> Handle(OfferProjectRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<OfferedProject> response = null;
				using (var trx = unitOfWork.BeginTransaction())
				{
					try
					{

						var user = await userManager.FindByNameAsync(request.OwnerUserName);
						request.OwnerId = user.Id;
						var project = mapper.Map<OfferedProject>(request);
						var result = await offerProjectService.Add(project);
						response = new BaseResponses<OfferedProject>(result);
						unitOfWork.SaveChanges();
					}
					catch (RestException ex)
					{
						trx.Rollback();
						response = new BaseResponses<OfferedProject>(ex.StatusCode, ex.Message);
						
					}
						return response;
				}

					
			}
		}
	}
}