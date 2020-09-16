﻿using FreelancersProject.Application.Services.Bases;
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

		
		public Task<Project> Add(Project entity)
		{
			try
			{
				var id = projectRepository.Add(entity);
				
				var result = projectRepository.GetById(id.ToString());
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

		public Task<IEnumerable<Project>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Project> GetById(string id)
		{
			throw new NotImplementedException();
		}

		public Task<Project> Update(Project entity)
		{
			throw new NotImplementedException();
		}
	}
}
