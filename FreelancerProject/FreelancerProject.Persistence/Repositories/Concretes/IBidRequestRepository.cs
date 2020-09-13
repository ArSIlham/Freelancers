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
	public interface IBidRequestRepository: IRepository<BidRequest>
	{
		//GetBidRequestsByProjectId(int ProjectId)
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
		private string GetAllBidRequestByProjectId = "select * from BidRequests where ProjectId=@id";
		private string AddSql = "insert into BidRequests (FreelancerId, ProjectId,BidPrice, CreateDate,IsConfirmed)" +
			"values(@FreelancerId, @ProjectId,@BidPrice, @CreateDate,@IsConfirmed)";
		private string DeleteSql = "delete BidRequests where Id=@id;";
		private string UpdateSql = "";

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
