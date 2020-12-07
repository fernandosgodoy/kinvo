using Kinvo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinvo.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : BaseEntity
    {
        int Add(TEntity entity);
        void RemoveById(int id);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
