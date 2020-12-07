using Kinvo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinvo.Domain.Interfaces.Services
{
    
    public interface IServiceBase<TEntity>
        where TEntity : BaseEntity
    {
        int InsertItem(TEntity entity);
        void RemoveItem(int id);
        void RemoveItem(TEntity entity);
        void UpdateItem(TEntity entity);
        TEntity Find(int id);
        IEnumerable<TEntity> ListAll();
    }

}
