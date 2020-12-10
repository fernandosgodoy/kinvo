using Kinvo.Domain.Entities;
using Kinvo.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kinvo.Infra.Data.Repositories
{
    public class ProdutoRepository<T>
        : RepositoryBase<T>
        where T : BaseEntity
    {
        public ProdutoRepository(ProdutoContext contexto) : base(contexto)
        {
        }
    }
}
