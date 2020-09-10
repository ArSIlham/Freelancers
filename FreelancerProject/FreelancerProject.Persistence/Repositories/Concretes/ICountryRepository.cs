using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreelancersProject.Persistence.Repositories.Concretes
{
	public interface ICountryRepository :IRepository<Country>
	{
	}

	public class CountryRepository : ICountryRepository
	{
		public Task<int> Add(Country entity)
		{
			throw new NotImplementedException();
		}

		public Task Delete(string id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Country>> Find(Expression<Func<Country, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Country>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Country> GetById(string id)
		{
			throw new NotImplementedException();
		}

		public Task Update(Country entity)
		{
			throw new NotImplementedException();
		}
	}
}
