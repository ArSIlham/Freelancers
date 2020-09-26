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
	public interface IBidRequestRepository : IRepository<BidRequest>
	{
		Task<IEnumerable<BidRequest>> GetBidRequestsByProjectId(string projectId);
	}

	public class BidRequestRepository : IBidRequestRepository
	{
		private readonly IUnitOfWork unitOfWork;
		public BidRequestRepository(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		//public Guid FreelancerId { get; set; }
		//public Guid ProjectId { get; set; }
		//public decimal BidPrice { get; set; }
		//public DateTime CreateDate { get; set; }
		//public bool IsConfirmed { get; set; }
		private string GetAllBidRequestByProjectIdSql = "select * from BidRequests where ProjectId=@ProjectId";

		private string DeleteSql = "delete BidRequests where Id=@id;";
		private string UpdateSql = "";
		private string GetBidRequestById = "select * from BidRequests where Id=@Id";
		public string AddSql = $@"insert into BidRequests (FreelancerId, ProjectId,BidPrice, CreateDate,IsConfirmed,Comment) 
			                      OUTPUT Inserted.Id
			                      values(
                                         @{ nameof(BidRequest.FreelancerId)},
                                         @{ nameof(BidRequest.ProjectId)},
                                         @{ nameof(BidRequest.BidPrice)},
                                         @{ nameof(BidRequest.CreateDate)},
                                         @{ nameof(BidRequest.IsConfirmed)}, 
                                         @{ nameof(BidRequest.Comment)})";
		public async Task<Guid> Add(BidRequest entity)
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

		public Task<IEnumerable<BidRequest>> Find(Expression<Func<BidRequest, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<BidRequest>> GetAll()
		{
			throw new NotImplementedException();
		}

		public async Task<BidRequest> GetById(string id)
		{
			try
			{
				var result = await unitOfWork.GetConnection().QueryFirstAsync<BidRequest>(GetBidRequestById, new { Id = id }, unitOfWork.GetTransaction());
				return result;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public Task Update(BidRequest entity)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<BidRequest>> GetBidRequestsByProjectId(string projectId)
		{
			try
			{
				var result = await unitOfWork.GetConnection().QueryAsync<BidRequest>(GetAllBidRequestByProjectIdSql, new { ProjectId = projectId.ToString() }, unitOfWork.GetTransaction());
				return result;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}