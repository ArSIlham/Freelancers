using FreelancersProject.Application.Services.Bases;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Services
{
	public interface IOfferProjectService : IBaseServices<OfferedProject>
	{
		Task<IEnumerable<OfferedProject>> GetOfferedProjectByOwnerId(int id);
	}
	public class OfferProjectService : IOfferProjectService
	{
		private readonly IOfferedProjectRepository offeredProjectRepository;

		public OfferProjectService(IOfferedProjectRepository offeredProjectRepository)
		{
			this.offeredProjectRepository = offeredProjectRepository;
		}
		public async Task<OfferedProject> Add(OfferedProject entity)
		{
			try
			{
				var id = await offeredProjectRepository.Add(entity);

				var result = await offeredProjectRepository.GetById(id.ToString());
				return result;
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

		public Task<IEnumerable<OfferedProject>> Find(Expression<Func<OfferedProject, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<OfferedProject>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<OfferedProject> GetById(string id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<OfferedProject>> GetOfferedProjectByOwnerId(int id)
		{
			try
			{
				var result = await offeredProjectRepository.GetOfferedProjectByOwnerId(id);
				return result;
			}
			catch (Exception ex)
			{

				throw new RestException(HttpStatusCode.NotFound, ex.Message);
			}
		}

		public Task<OfferedProject> Update(OfferedProject entity)
		{
			throw new NotImplementedException();
		}
	}
}
