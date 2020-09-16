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
	public interface IProjectRepository :IRepository<Project>
	{
		//GetProjectBySkill(int skillId)
		//GetProjectByPrice(int price)
		//GetProjectByCountry(Guid countryId)
		//GetProjectByStatus(string status)
		//GetProjectByOwnerId(Guid ownerId)
		Task AddSkillsToProject(List<ProjectSkill> projectSkills);
		
	}

	public class ProjectRepository : IProjectRepository
	{

		public ProjectRepository(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public string AddSql = "insert into Projects(Title, Description, MinPrice, MaxPrice,OwnerId,CreateDate,Status) " +
			"OUTPUT Inserted.Id" +
			"values (@Title, @Description,@MinPrice, @MaxPrice,@OwnerId,@CreateDate,@Status)";

		private string DeleteSql = "delete from Projects where Id=@Id";
		private string UpdateSql = "update Projects set Title=@Title,Descriprion=@Description, MinPrice=@MinPrice, MaxPrice=@MaxPrice, Status=@Status where Id=@Id";
		private string GetAllSql = "select * from Projects";
		private string GetProjectByOwnerIdSql = "select * from Projects where OwnerId=@ownerId";
		private string GetProjectByStatusSql = "select * from Projects where Status=@status";
		private string GetProjectByCountrySql = "select * from Projects where CountryId=@countryId";
		private string GetProjectByPriceSql = "select * from Projects where MinPrice>@price and maxPrice<@price";

		private string GetProjectBySkillSql = "select Projects.* from Projects as p inner join ProjectSkills as s where s.SkillId=@skillId ";
		private string GetProjectById = "select * from Projects where Id=@Id";
		private string AddSkillProjectSkill = "insert ProjectSkills (ProjectId, SkillId)  values(@projectId, @skillId)";
		private readonly IUnitOfWork unitOfWork;

		public async Task<Guid> Add(Project entity)
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

		public Task<IEnumerable<Project>> Find(Expression<Func<Project, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Project>> GetAll()
		{
			throw new NotImplementedException();
		}

		public async Task<Project> GetById(string id)
		{
			try
			{
				var result = await unitOfWork.GetConnection().QueryFirstAsync<Project>(GetProjectById, new {Id=id }, unitOfWork.GetTransaction());
				return result;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public Task Update(Project entity)
		{
			throw new NotImplementedException();
		}

		public  async Task AddSkillsToProject(List<ProjectSkill> projectSkills )
		{
			try
			{
				

				 await unitOfWork.GetConnection().QueryFirstAsync(AddSkillProjectSkill, projectSkills, unitOfWork.GetTransaction());
				
				
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
