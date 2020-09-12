using Dapper;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.Infratructure;
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
		private readonly IUnitOfWork unitOfWork;
		private string GetAllSql = "Select * from Countries";
		private string AddSql = "insert into Countries([Name]) values (@Name)";

		public CountryRepository(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}
		public async Task<Guid> Add(Country entity)
		{
			try
			{
				var result = await unitOfWork.GetConnection().QueryFirstAsync<Guid>(AddSql, entity, unitOfWork.GetTransaction());
				return result;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public Task Delete(string id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Country>> Find(Expression<Func<Country, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public  async Task<IEnumerable<Country>> GetAll()
		{
			try
			{
				var result = await unitOfWork.GetConnection().QueryAsync<Country>(GetAllSql, null, unitOfWork.GetTransaction());
				return result;
			}
			catch (Exception ex)
			{

				throw ex;
			}
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
