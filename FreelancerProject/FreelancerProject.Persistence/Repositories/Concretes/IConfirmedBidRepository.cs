using Dapper;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.Infratructure;
using FreelancersProject.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FreelancersProject.Persistence.Repositories.Concretes
{
	public interface IConfirmedBidRepository : IRepository<ConfirmedBid>
	{
	}

	public class ConfirmedBidRepository : IConfirmedBidRepository
	{
		private readonly IUnitOfWork unitOfWork;

		private string AddSql = $@"insert into ConfirmedBids ([BidId],[DeadlineDate],[ConfirmedDate]) OUTPUT Inserted.Id
												values	(@{nameof(ConfirmedBid.BidId)},
                                                        @{nameof(ConfirmedBid.DeadlineDate)},
								   					 @{nameof(ConfirmedBid.DeadlineDate)})";
		private string GetProjectById = "select * from ConfirmedBids where Id=@Id";
		public ConfirmedBidRepository(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}
		public async  Task<Guid> Add(ConfirmedBid entity)
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

		public Task<IEnumerable<ConfirmedBid>> Find(Expression<Func<ConfirmedBid, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<ConfirmedBid>> GetAll()
		{
			throw new NotImplementedException();
		}

		public async Task<ConfirmedBid> GetById(string id)
		{
			try
			{
				var result = await unitOfWork.GetConnection().QueryFirstAsync<ConfirmedBid>(GetProjectById, new { Id = id }, unitOfWork.GetTransaction());
				return result;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public Task Update(ConfirmedBid entity)
		{
			throw new NotImplementedException();
		}
	}
}
