using FreelancersProject.Domain.Concretes;
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
		public Task<int> Add(Skill entity)
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
