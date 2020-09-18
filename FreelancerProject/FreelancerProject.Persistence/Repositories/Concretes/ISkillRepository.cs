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
	public interface ISkillRepository  :IRepository<Skill>
	{
		Task<IEnumerable<Skill>> GetSkillsOfProject(Guid Id);
	}

	public class SkillRepository : ISkillRepository
	{

		public SkillRepository(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}
		private string GetAllSql = "select * from Skills";
		private string DeleteSql = "delete Skills where Id=@Id";
		private string UpdateSql = "update Skills set Name=@Name where Id=@Id";
		private string AddSqlSql = "insert into Skills ([Name]) values(@Name)";
		private string GetByIdSql = "select * from Skills where Id=@Id";
		private string GetProjectSkillsSql = $@"select a.Id, a.Name from ProjectSkills as p, Skills as a 
                                                where p.SkillId=a.Id 
                                                and p.ProjectId=@projId";
		private readonly IUnitOfWork unitOfWork;

		public Task<Guid> Add(Skill entity)
		{
			throw new NotImplementedException();
		}

		public Task Delete(string id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Skill>> Find(Expression<Func<Skill, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Skill>> GetAll()
		{
			try
			{
				var result = await unitOfWork.GetConnection().QueryAsync<Skill>(GetAllSql, null, unitOfWork.GetTransaction());
				return result;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public Task<Skill> GetById(string id)
		{
			throw new NotImplementedException();
		}

		public Task Update(Skill entity)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Skill>> GetSkillsOfProject(Guid Id)
		{
			try
			{
				var result = await unitOfWork.GetConnection().QueryAsync<Skill>(GetProjectSkillsSql, new {projId=Id }, unitOfWork.GetTransaction());
				return result;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
