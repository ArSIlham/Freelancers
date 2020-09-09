using FreelancersProject.Application.Services.Bases;
using FreelancersProject.Domain.Bases;
using FreelancersProject.Domain.Owner;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Infratructure;
using FreelancersProject.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Services.Owner
{

    public interface IOwnerService : IBaseServices<OwnerModel>
    {

    }
    public class OwnerService : IOwnerService
{
    private readonly IOwnerRepository productRepository;
    private readonly IUnitOfWork unitOfWork;

    public OwnerService(IOwnerRepository productRepository, IUnitOfWork unitOfWork)
    {
        this.productRepository = productRepository;
        this.unitOfWork = unitOfWork;
    }
    public async Task<OwnerModel> Add(OwnerModel entity)
    {

        try
        {
            var addedId = await productRepository.Add(entity);

            var result = await productRepository.GetById(addedId.ToString());
            return result;
        }
        catch (Exception ex)
        {
            throw new RestException(System.Net.HttpStatusCode.NotFound, ex.Message);
        }

    }

    public async Task<string> Delete(string id)
    {

        try
        {
            await productRepository.Delete(id);
            return "OK";
        }
        catch (Exception ex)
        {
            throw new RestException(System.Net.HttpStatusCode.NotFound, ex.Message);
        }

    }

    public async Task<IEnumerable<OwnerModel>> Find(Expression<Func<OwnerModel, bool>> predicate)
    {

        try
        {
            var result = await productRepository.Find(predicate);
            return result;
        }
        catch (Exception ex)
        {

            throw new RestException(System.Net.HttpStatusCode.NotFound, ex.Message);
        }

    }

    public async Task<IEnumerable<OwnerModel>> GetAll()
    {

        try
        {
            var result = await productRepository.GetAll();
            return result;
        }
        catch (Exception ex)
        {
            throw new RestException(System.Net.HttpStatusCode.NotFound, ex.Message);
        }

    }

    public async Task<ListResult<OwnerModel>> GetAllPaging(int offset, int limit)
    {

        try
        {
            var result = await productRepository.GetAllPaging(offset, limit);
            return result;
        }
        catch (Exception ex)
        {

            throw new RestException(System.Net.HttpStatusCode.NotFound, ex.Message);
        }

    }

    public async Task<OwnerModel> GetById(string id)
    {

        try
        {
            var result = await productRepository.GetById(id);
            return result;
        }
        catch (Exception ex)
        {

            throw new RestException(System.Net.HttpStatusCode.NotFound, ex.Message);
        }

    }

    public async Task<OwnerModel> Update(OwnerModel entity)
    {
            return entity;
        //try
        //{
        //    if (entity.Password == string.Empty)
        //        throw new Exception("Id can not be null");

        //    await productRepository.Update(entity);
        //    var product = await productRepository.GetById(entity.Id.ToString());
        //    return product;
        //}
        //catch (Exception ex)
        //{
        //    throw new RestException(System.Net.HttpStatusCode.NotFound, ex.Message);
        //}

    }
}
}
