using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreelancersProject.Persistence.Repositories.Concretes
{
	public interface IConfirmedBidRepository : IRepository<OfferedProject>
	{
	}

	public class ConfirmedBidRepository : IConfirmedBidRepository
	{
		public Task<Guid> Add(OfferedProject entity)
		{
			throw new NotImplementedException();
		}

		public Task Delete(string id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<OfferedProject>> Find(Expression<Func<OfferedProject, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<OfferedProject>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<OfferedProject> GetById(string id)
		{
			throw new NotImplementedException();
		}

		public Task Update(OfferedProject entity)
		{
			throw new NotImplementedException();
		}
	}
}
