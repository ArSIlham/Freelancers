using FreelancersProject.Application.Services.Bases;
using FreelancersProject.Domain.Concretes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Services
{

	public interface IConfirmedBidService : IBaseServices<ConfirmedBid>
	{

	}
	public class ConfirmedBidService : IConfirmedBidService
	{
		public Task<ConfirmedBid> Add(ConfirmedBid entity)
		{
			throw new NotImplementedException();
		}

		public Task<string> Delete(string id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<ConfirmedBid>> Find(Expression<Func<ConfirmedBid, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<ConfirmedBid>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<ConfirmedBid> GetById(string id)
		{
			throw new NotImplementedException();
		}

		public Task<ConfirmedBid> Update(ConfirmedBid entity)
		{
			throw new NotImplementedException();
		}
	}
}
