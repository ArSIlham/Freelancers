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
		private string AddSql = "insert into Skills ([Name]) values(@Name)";
		private string GetById = "select * from Skills where Id=@Id";
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

		public Task<IEnumerable<Skill>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Skill> GetById(string id)
		{
			throw new NotImplementedException();
		}

		public Task Update(Skill entity)
		{
			throw new NotImplementedException();
		}
	}
}
