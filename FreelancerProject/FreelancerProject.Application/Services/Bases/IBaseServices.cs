using FreelancersProject.Domain.Bases;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Services.Bases
{
    public interface IBaseServices<TEntity> where TEntity : IEntity
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<ListResult<TEntity>> GetAllPaging(int offset, int limit);
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetById(string id);
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<string> Delete(string id);
    }
}
