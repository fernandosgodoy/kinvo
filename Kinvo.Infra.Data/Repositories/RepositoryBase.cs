using Kinvo.Domain.Entities;
using Kinvo.Domain.Interfaces.Repositories;
using Kinvo.Infra.Data.Context;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Kinvo.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity>
        : IRepository<TEntity>
        where TEntity : BaseEntity
    {

        protected readonly ProdutoContext _context;

        public RepositoryBase(ProdutoContext contexto)
            : base()
        {
            this._context = contexto;
        }

        public int Add(TEntity entity)
        {
            _context.InitTransaction();
            var id = _context.Set<TEntity>()
                .Add(entity).Entity.Id;
            _context.SendChanges();
            return id;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToArray();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            _context.InitTransaction();
            _context.Set<TEntity>().Remove(entity);
            _context.SendChanges();
        }

        public void RemoveById(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                _context.InitTransaction();
                _context.Set<TEntity>().Remove(entity);
                _context.SendChanges();
            }
        }

        public void Update(TEntity entity)
        {
            _context.InitTransaction();
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SendChanges();
        }
    }
}
