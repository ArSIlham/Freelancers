using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreelancersProject.Persistence.Repositories.Concretes
{
	public interface IBidRequestRepository: IRepository<BidRequest>
	{
		//GetBidRequestsByProjectId(int ProjectId)
	}

	public class BidRequestRepository : IBidRequestRepository
	{
		public Task<Guid> Add(BidRequest entity)
		{
			throw new NotImplementedException();
		}

		public Task Delete(string id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<BidRequest>> Find(Expression<Func<BidRequest, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<BidRequest>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<BidRequest> GetById(string id)
		{
			throw new NotImplementedException();
		}

		public Task Update(BidRequest entity)
		{
			throw new NotImplementedException();
		}
	}
}
