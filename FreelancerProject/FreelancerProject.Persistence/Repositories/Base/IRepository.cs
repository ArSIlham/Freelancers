using FreelancersProject.Domain.Bases;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreelancersProject.Persistence.Repositories.Base
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<ListResult<TEntity>> GetAllPaging(int offset, int limit);
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetById(string id);
        Task<int> Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(string id);

    }
}
