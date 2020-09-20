using FreelancersProject.Application.Common;
using FreelancersProject.Application.DTOs;
using FreelancersProject.Application.Services;
using FreelancersProject.Domain.Bases;
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

namespace FreelancersProject.Application.Handler.CQRS.Queries.Freelancer
{
	public class FreelancerList
	{
		public class FreelancerListRequest : IRequest<BaseResponses<IEnumerable<FreelancerListDTO>>>
		{

		}

		public class FreelancerListHandler : IRequestHandler<FreelancerListRequest, BaseResponses<IEnumerable<FreelancerListDTO>>>
		{
			private readonly IUnitOfWork unitOfWork;
			private readonly ICountryService countryService;
			private readonly UserManager<ApplicationUser> userManager;
			private readonly ISkillService skillService;

			public FreelancerListHandler(IUnitOfWork unitOfWork,ICountryService countryService,
				UserManager<ApplicationUser> userManager, ISkillService skillService)
			{
				this.unitOfWork = unitOfWork;
				this.countryService = countryService;
				this.userManager = userManager;
				this.skillService = skillService;
			}
			public async Task<BaseResponses<IEnumerable<FreelancerListDTO>>> Handle(FreelancerListRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<IEnumerable<FreelancerListDTO>> response = null;
				using ( var trx = unitOfWork.BeginTransaction())
				{
					try
					{
						string roleName = "Freelancer";
						var users = await userManager.GetUsersInRoleAsync(roleName);
						var freelancerDTO = new List<FreelancerListDTO>();
						foreach (var item in users)
						{
							var skill = await skillService.GetFreelancerSkill(item.Id);
							var country = await countryService.GetById(item.CountryId.ToString());
							freelancerDTO.Add(new FreelancerListDTO { User = item, FreelancerSkils = skill, Country=country });
						}
						response = new BaseResponses<IEnumerable<FreelancerListDTO>>(freelancerDTO);
						unitOfWork.SaveChanges();
					}
					catch (RestException ex)
					{

						trx.Rollback();
						response = new BaseResponses<IEnumerable<FreelancerListDTO>>(ex.StatusCode, ex.Message);
					}
				}
				return response;
			}
		}
	}
}
