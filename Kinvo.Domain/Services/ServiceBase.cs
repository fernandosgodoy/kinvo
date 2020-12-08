using Kinvo.Domain.Entities;
using Kinvo.Domain.Interfaces.Repositories;
using Kinvo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinvo.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity>
        where TEntity : BaseEntity
    {

        protected readonly IRepository<TEntity> _repository;

        public TEntity Find(int id)
        {
            return _repository.GetById(id);
        }

        public int InsertItem(TEntity entity)
        {
            return _repository.Add(entity);
        }

        public IEnumerable<TEntity> ListAll()
        {
            return _repository.GetAll();
        }

        public void RemoveItem(int id)
        {
            _repository.RemoveById(id);
        }

        public void RemoveItem(TEntity entity)
        {
            _repository.Remove(entity);
        }

        public void UpdateItem(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}
