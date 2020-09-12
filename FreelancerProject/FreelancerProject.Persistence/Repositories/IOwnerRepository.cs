using Dapper;
using FreelancersProject.Domain.Bases;
using FreelancersProject.Domain.Owner;
using FreelancersProject.Persistence.Infratructure;
using FreelancersProject.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreelancersProject.Persistence.Repositories
{
    public interface IOwnerRepository : IRepository<OwnerModel>
    {

    }
    public class OwnersRepository : IOwnerRepository
    {
        private readonly IUnitOfWork unitOfWork;
        
        public OwnersRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        private string AddSql = $@"insert into [User] (Email, Password, ImageUrl
                                    ,Projects ,Country, Skils, Roles)
                                    OUTPUT Inserted.Id
                                    values(@{nameof(OwnerModel.Email)},
                                    @{nameof(OwnerModel.Password)},
                                    @{nameof(OwnerModel.ImageUrl)},
                                    @{nameof(OwnerModel.Projects)},
                                    @{nameof(OwnerModel.Country)},
                                    @{nameof(OwnerModel.Skils)},
                                    @{nameof(OwnerModel.Roles)})";
        private string DeleteSql = $@"delete [User] where [User].Id=@id";


        private string UpdateSql = "";

        private string GetByIdSql = "select * from [User] where Id=@id;";
        private const string GetAllSql = "select * from [User]";
        public async Task<Guid> Add(OwnerModel entity)
        {
            try
            {
                var id = await unitOfWork.GetConnection().QuerySingleAsync<int>(AddSql, entity, unitOfWork.GetTransaction());
                //return id;
                return new Guid();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Delete(string id)
        {
            var param = new
            {
                id
            };
            try
            {
                await unitOfWork.GetConnection().QueryAsync(DeleteSql, param, unitOfWork.GetTransaction());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<IEnumerable<OwnerModel>> Find(Expression<Func<OwnerModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OwnerModel>> GetAll()
        {
            try
            {
                var result = await unitOfWork.GetConnection().QueryAsync<OwnerModel>(GetAllSql, null, unitOfWork.GetTransaction());
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<ListResult<OwnerModel>> GetAllPaging(int offset, int limit)
        {
            throw new NotImplementedException();
        }

        public async Task<OwnerModel> GetById(string id)
        {
            var param = new
            {
                id
            };
            try
            {
                var result = await unitOfWork.GetConnection()
                    .QuerySingleAsync<OwnerModel>(GetByIdSql, param, unitOfWork.GetTransaction());
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Update(OwnerModel entity)
        {
            try
            {
                await unitOfWork.GetConnection().QueryAsync(UpdateSql, entity, unitOfWork.GetTransaction());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
