using FreelancersProject.Application.Services.Bases;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Infratructure;
using FreelancersProject.Persistence.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Services
{


	public interface IProjectService : IBaseServices<Project>
	{
		Task AddSkillsToProject(List<ProjectSkill> projectSkills);
		Task<IEnumerable<Project>> GetProjectByOwnerId(int id);
	}
	public class ProjectService : IProjectService
	{
		private readonly IProjectRepository projectRepository;
		private readonly IUnitOfWork unitOfWork;

		public ProjectService(IProjectRepository projectRepository, IUnitOfWork unitOfWork)
		{
			this.projectRepository = projectRepository;
			this.unitOfWork = unitOfWork;
		}

		
		public async Task<Project> Add(Project entity)
		{
			try
			{
				var id = await projectRepository.Add(entity);
				
				var result = await projectRepository.GetById(id.ToString());
				return result;
			}
			catch (Exception ex)
			{

				throw new RestException(HttpStatusCode.NotFound, ex.Message);
			}
		}

		public  async Task AddSkillsToProject(List<ProjectSkill> projectSkills)
		{
			try
			{
				await projectRepository.AddSkillsToProject(projectSkills);
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

		public Task<IEnumerable<Project>> Find(Expression<Func<Project, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Project>> GetAll()
		{
			try
			{
				var result = await projectRepository.GetAll();
				return result;
			}
			catch (Exception ex)
			{
				throw new RestException(System.Net.HttpStatusCode.NotFound, ex.Message);
			}
		}

		public async Task<Project> GetById(string id)
		{
			try
			{
<<<<<<< HEAD
				

				var result = await projectRepository.GetById(id.ToString());
=======
				var result = await projectRepository.GetById(id);
>>>>>>> 7442466b20afb19728593a2d940eaf07d52d2f53
				return result;
			}
			catch (Exception ex)
			{
<<<<<<< HEAD

				throw new RestException(HttpStatusCode.NotFound, ex.Message);
=======
				throw new RestException(System.Net.HttpStatusCode.NotFound, ex.Message);
>>>>>>> 7442466b20afb19728593a2d940eaf07d52d2f53
			}
		}

		public async  Task<IEnumerable<Project>> GetProjectByOwnerId(int id)
		{
			try
			{
				var result = await projectRepository.GetProjectByOwnerId(id);
				return result;
			}
			catch (Exception ex)
			{

				throw new RestException(HttpStatusCode.NotFound, ex.Message);
			}
		}

		public Task<Project> Update(Project entity)
		{
			throw new NotImplementedException();
		}

	}
}
