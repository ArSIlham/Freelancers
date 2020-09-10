using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreelancersProject.Persistence.Repositories.Concretes
{
	public interface IProjectRepository :IRepository<Project>
	{
		//GetProjectBySkill(int skillId)
		//GetProjectByPrice(int minPrice, int maxPrice)
		//GetProjectByCountry(int CountryId)
		//GetProjectByStatus(string status)
		//GetProjectByOwnerId(int ownerId)
	}

	public class ProjectRepository : IProjectRepository
	{
		public Task<int> Add(Project entity)
		{
			throw new NotImplementedException();
		}

		public Task Delete(string id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Project>> Find(Expression<Func<Project, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Project>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Project> GetById(string id)
		{
			throw new NotImplementedException();
		}

		public Task Update(Project entity)
		{
			throw new NotImplementedException();
		}
	}
}
