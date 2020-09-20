using FreelancersProject.Application.Services.Bases;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Repositories.Concretes;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Services
{

	public interface ISkillService : IBaseServices<Skill>
	{
		Task<IEnumerable<Skill>> GetProjectSkills(Guid id);
		Task<IEnumerable<Skill>> GetFreelancerSkill(int id);
	}
	public class SkillService : ISkillService
	{
		private readonly ISkillRepository skillRepository;

		public SkillService(ISkillRepository skillRepository)
		{
			this.skillRepository = skillRepository;
		}

		
		public Task<Skill> Add(Skill entity)
		{
			throw new NotImplementedException();
		}

		

		public Task<string> Delete(string id)
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
				var result = await skillRepository.GetAll();
				return result;
			}
			catch (Exception ex)
			{

				throw new RestException(HttpStatusCode.NotFound, ex.Message);
			}
		}

		public Task<Skill> GetById(string id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Skill>> GetFreelancerSkill(int id)
		{
			try
			{
				var result = await skillRepository.GetSkillsOfFreelancer(id);
				return result;
			}
			catch (Exception ex)
			{

				throw new RestException(HttpStatusCode.NotFound, ex.Message);
			}
		}

		public async Task<IEnumerable<Skill>> GetProjectSkills(Guid id)
		{
			try
			{
				var result = await skillRepository.GetSkillsOfProject(id);
				return result;
			}
			catch (Exception ex)
			{

				throw new RestException(HttpStatusCode.NotFound, ex.Message);
			}
		}

		public Task<Skill> Update(Skill entity)
		{
			throw new NotImplementedException();
		}
	}
}
