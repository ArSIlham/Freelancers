using FreelancersProject.Application.Services.Bases;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Services
{

	public interface ICountryService :IBaseServices<Country>{}
	public class CountryService : ICountryService
	{
		private readonly ICountryRepository countryRepository;

		public CountryService(ICountryRepository countryRepository)
		{
			this.countryRepository = countryRepository;
		}
		public Task<Country> Add(Country entity)
		{
			try
			{
				var id = countryRepository.Add(entity);
				var result = countryRepository.GetById(id.ToString());
				return result;
			}
			catch (Exception ex)
			{

				throw new RestException(HttpStatusCode.NotFound, ex.Message);
			}
		}

		public Task<string> Delete(string id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Country>> Find(Expression<Func<Country, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Country>> GetAll()
		{
			try
			{
				var result = await countryRepository.GetAll();
				return result;
			}
			catch (Exception ex)
			{

				throw new RestException( HttpStatusCode.NotFound, ex.Message);
			}
		}

		public Task<Country> GetById(string id)
		{
			throw new NotImplementedException();
		}

		public Task<Country> Update(Country entity)
		{
			throw new NotImplementedException();
		}
	}
}
