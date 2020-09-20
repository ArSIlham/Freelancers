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
	public interface IBidRequestService : IBaseServices<BidRequest>
	{
		Task<IEnumerable<BidRequest>> GetBidRequestsByProjectId(string projectId);
	}
	public class BidRequestService : IBidRequestService
	{
		private readonly IBidRequestRepository bidRequestRepository;

		public BidRequestService(IBidRequestRepository bidRequestRepository)
		{
			this.bidRequestRepository = bidRequestRepository;
		}
		public Task<BidRequest> Add(BidRequest entity)
		{
			throw new NotImplementedException();
		}

		public Task<string> Delete(string id)
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

		public async Task<IEnumerable<BidRequest>> GetBidRequestsByProjectId(string projectId)
		{
			try
			{
				var result = await bidRequestRepository.GetBidRequestsByProjectId(projectId);
				return result;
			}
			catch (Exception ex)
			{

				throw new RestException(HttpStatusCode.NotFound, ex.Message);
			}
		}

		public Task<BidRequest> GetById(string id)
		{
			throw new NotImplementedException();
		}

		public Task<BidRequest> Update(BidRequest entity)
		{
			throw new NotImplementedException();
		}
	}
}
