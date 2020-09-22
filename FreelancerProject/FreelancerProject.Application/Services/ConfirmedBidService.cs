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

	public interface IConfirmedBidService : IBaseServices<ConfirmedBid>
	{

	}
	public class ConfirmedBidService : IConfirmedBidService
	{
		private readonly IConfirmedBidRepository confirmedBidRepository;

		public ConfirmedBidService(IConfirmedBidRepository confirmedBidRepository)
		{
			this.confirmedBidRepository = confirmedBidRepository;
		}
		public  async Task<ConfirmedBid> Add(ConfirmedBid entity)
		{
			try
			{
				var id = await confirmedBidRepository.Add(entity);

				var result = await confirmedBidRepository.GetById(id.ToString());
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
