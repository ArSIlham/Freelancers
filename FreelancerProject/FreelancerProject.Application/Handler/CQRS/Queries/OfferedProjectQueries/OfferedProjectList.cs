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
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Queries.OfferedProjectQueries
{
	public class OfferedProjectList
	{

		public class OfferedProjectListRequest : IRequest<BaseResponses<IEnumerable<OfferedProjectDTO>>>
		{
			public string UserName { get; set; }
		}

		public class OfferedProjectListHandler : IRequestHandler<OfferedProjectListRequest, BaseResponses<IEnumerable<OfferedProjectDTO>>>
		{
			private readonly UserManager<ApplicationUser> userManager;
			private readonly IOfferProjectService offerProjectService;
			private readonly ICountryService countryService;
			private readonly IUnitOfWork unitOfWork;

			public OfferedProjectListHandler(UserManager<ApplicationUser> userManager,
				IOfferProjectService offerProjectService, ICountryService countryService, IUnitOfWork unitOfWork)
			{
				this.userManager = userManager;
				this.offerProjectService = offerProjectService;
				this.countryService = countryService;
				this.unitOfWork = unitOfWork;
			}

			

			public async Task<BaseResponses<IEnumerable<OfferedProjectDTO>>> Handle(OfferedProjectListRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<IEnumerable<OfferedProjectDTO>> response = null;
				using (var trx = unitOfWork.BeginTransaction())
				{
					try
					{
						var user = await userManager.FindByNameAsync(request.UserName);
						var projects = await offerProjectService.GetOfferedProjectByOwnerId(user.Id);
						
						var offeredProjectDTO = new List<OfferedProjectDTO>();

						foreach (var item in projects)
						{
							var freelancer = await userManager.FindByIdAsync(item.FreelancerId.ToString());
							var country = await countryService.GetById(freelancer.CountryId.ToString());
							offeredProjectDTO.Add(new OfferedProjectDTO { OfferedProject = item, FreeLancer = freelancer, FreeLancerCountry = country });
						}
						unitOfWork.SaveChanges();
						response = new BaseResponses<IEnumerable<OfferedProjectDTO>>(offeredProjectDTO);

					}
					catch (RestException ex)
					{
						trx.Rollback();
						response = new BaseResponses<IEnumerable<OfferedProjectDTO>>(ex.StatusCode, ex.Message);
						
					}
					return response;
				}
			}
		}
	}
}
