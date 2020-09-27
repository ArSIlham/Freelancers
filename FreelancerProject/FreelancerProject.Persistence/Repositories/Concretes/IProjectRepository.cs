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
	public interface IProjectRepository : IRepository<Project>
	{
		//GetProjectBySkill(int skillId)
		//GetProjectByPrice(int price)
		//GetProjectByCountry(Guid countryId)
		//GetProjectByStatus(string status)
		//GetProjectByOwnerId(Guid ownerId)
		Task AddSkillsToProject(List<ProjectSkill> projectSkills);

		Task<IEnumerable<Project>> GetProjectByOwnerId(int ownerId);
		Task<IEnumerable<Project>> GetFreelancermyProject(string id);

	}

	public class ProjectRepository : IProjectRepository
	{

		public ProjectRepository(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public string AddSql = $@"insert into [Projects](Title, Description, MinPrice, MaxPrice,OwnerId,CreateDate,Status) 
			                      OUTPUT Inserted.Id
			                      values(@{ nameof(Project.Title)},
                                         @{ nameof(Project.Description)},
                                         @{ nameof(Project.MinPrice)},
                                         @{ nameof(Project.MaxPrice)},
                                         @{ nameof(Project.OwnerId)},
                                         @{ nameof(Project.CreateDate)}, 
                                         @{ nameof(Project.Status)})";

		private string DeleteSql = "delete from Projects where Id=@Id";
		private string UpdateSql = "update Projects set Title=@Title,Descriprion=@Description, MinPrice=@MinPrice, MaxPrice=@MaxPrice, Status=@Status where Id=@Id";
		private string GetAllSql = @"select AU.UserName,P.* from ApplicationUser as AU inner join ApplicationUserRole as AUR
on AU.Id = AUR.UserId
inner join ApplicationRole as AR
on AR.Id = AUR.RoleId
inner join Projects as P 
on p.OwnerId = AU.Id
";
		private string GetProjectByOwnerIdSql = "select * from Projects where OwnerId=@OwnerId";
		private string GetProjectByStatusSql = "select * from Projects where Status=@status";
		private string GetProjectByCountrySql = "select * from Projects where CountryId=@countryId";
		private string GetProjectByPriceSql = "select * from Projects where MinPrice>@price and maxPrice<@price";

		private string GetFreelancerMyProject = @"select Projects.* from ApplicationUser inner join BidRequests ON ApplicationUser.Id = BidRequests.FreelancerId
inner join Projects on Projects.Id = BidRequests.ProjectId where ApplicationUser.Id = @id";
		private string GetProjectById = "select * from Projects where Id=@Id";
		private string AddSkillProjectSkill = "insert into ProjectSkills (ProjectId, SkillId)  values(@projectId, @skillId)";
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

		public async Task Delete(string id)
		{
			try
			{
				var result = await unitOfWork.GetConnection().ExecuteAsync(DeleteSql, new {Id=id }, unitOfWork.GetTransaction());
				
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public Task<IEnumerable<Project>> Find(Expression<Func<Project, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Project>> GetAll()
		{
			try
			{
				var result = await unitOfWork.GetConnection().QueryAsync<Project>(GetAllSql, null, unitOfWork.GetTransaction());
				return result;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public async Task<Project> GetById(string id)
		{
			try
			{
				var result = await unitOfWork.GetConnection().QueryFirstAsync<Project>(GetProjectById, new { Id = id }, unitOfWork.GetTransaction());
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

		public async Task AddSkillsToProject(List<ProjectSkill> projectSkills)
		{
			try
			{


				await unitOfWork.GetConnection().ExecuteAsync(AddSkillProjectSkill, projectSkills, unitOfWork.GetTransaction());


			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public async Task<IEnumerable<Project>> GetProjectByOwnerId(int ownerId)
		{
			try
			{
				var result = await unitOfWork.GetConnection().QueryAsync<Project>(GetProjectByOwnerIdSql, new { OwnerId = ownerId.ToString() }, unitOfWork.GetTransaction());
				return result as IEnumerable<Project>;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public async Task<IEnumerable<Project>> GetFreelancermyProject(string id)
		{
			try
			{
				var result = await unitOfWork.GetConnection().QueryAsync<Project>(GetFreelancerMyProject, new { Id = id }, unitOfWork.GetTransaction());
				return result as IEnumerable<Project>;
			}
			catch (Exception ex)
			{

				throw ex;
			}

		}
	}
}
