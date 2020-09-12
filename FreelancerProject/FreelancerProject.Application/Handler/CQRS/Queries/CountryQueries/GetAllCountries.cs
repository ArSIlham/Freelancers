using FreelancersProject.Application.Common;
using FreelancersProject.Application.Services;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Infratructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Queries.CountryQueries
{
	public class GetAllCountries
	{
		public class AllCountriesQuery : IRequest<BaseResponses<IEnumerable<Country>>>
		{

		}

		public class AllCountriesHandler : IRequestHandler<AllCountriesQuery, BaseResponses<IEnumerable<Country>>>
		{
			private readonly ICountryService countryService;
			private readonly IUnitOfWork unitOfWork;

			public AllCountriesHandler(IUnitOfWork unitOfWork, ICountryService countryService)
			{
				
				this.countryService = countryService;
				this.unitOfWork = unitOfWork;

			}

			

			public  async Task<BaseResponses<IEnumerable<Country>>> Handle(AllCountriesQuery request, CancellationToken cancellationToken)
			{
				BaseResponses<IEnumerable<Country>> response = null;


				
				using (var trx = unitOfWork.BeginTransaction())
				{
					try
					{
						var result = await countryService.GetAll();
						response = new BaseResponses<IEnumerable<Country>>(result);
					}
					catch (RestException ex)
					{
						response = new BaseResponses<IEnumerable<Country>>(ex.StatusCode, ex.Message);
					}
					return response;
				}
			}
		}
	}
}
