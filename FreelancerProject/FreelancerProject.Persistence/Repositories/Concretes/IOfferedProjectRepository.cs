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

	public interface IOfferedProjectRepository : IRepository<OfferedProject> 
	{
		//GetOfferedProjectByFreelancerId(int freelancerId)
		Task<IEnumerable<OfferedProject>> GetOfferedProjectByOwnerId(int ownerId);
	}

	public class OfferedProjectRepository : IOfferedProjectRepository
	{
		private readonly IUnitOfWork unitOfWork;


		public OfferedProjectRepository(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}


		private string AddSql = $@"insert into OfferedProjects
                                               ([Title], 
                                               [Description], 
                                               [FreelancerId],
                                               [OwnerId],
                                               [Price],
                                               [OfferedDate],
                                               [IsAccepted],
                                               [DeadlineDayCounts],
                                               [AcceptedDate]) 
                                               OUTPUT Inserted.Id 
                                               values (@{nameof(OfferedProject.Title)},
                                               @{nameof(OfferedProject.Description)},
                                               @{nameof(OfferedProject.FreelancerId)},
                                               @{nameof(OfferedProject.OwnerId)},
                                               @{nameof(OfferedProject.Price)},
                                               @{nameof(OfferedProject.OfferedDate)},
                                               @{nameof(OfferedProject.IsAccepted)},
                                               @{nameof(OfferedProject.DeadlineDayCounts)},
                                               @{nameof(OfferedProject.AcceptedDate)})";
                                               

		private string GetProjectById = "select * from OfferedProjects where Id=@Id";

		private string GetOfferedProjectByOwnerIdSql = "select * from OfferedProjects where OwnerId=@OwnerId";
		public async Task<Guid> Add(OfferedProject entity)
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

		public Task<IEnumerable<OfferedProject>> Find(Expression<Func<OfferedProject, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<OfferedProject>> GetAll()
		{
			throw new NotImplementedException();
		}

		public async Task<OfferedProject> GetById(string id)
		{
			try
			{
				var result = await unitOfWork.GetConnection().QueryFirstAsync<OfferedProject>(GetProjectById, new { Id = id }, unitOfWork.GetTransaction());
				return result;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public Task Update(OfferedProject entity)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<OfferedProject>> GetOfferedProjectByOwnerId(int ownerId)
		{
			try
			{
				var result = await unitOfWork.GetConnection().QueryAsync<OfferedProject>(GetOfferedProjectByOwnerIdSql, new { OwnerId = ownerId.ToString() }, unitOfWork.GetTransaction());
				return result as IEnumerable<OfferedProject>;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
