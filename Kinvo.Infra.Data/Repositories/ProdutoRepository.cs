using Kinvo.Domain.Entities;
using Kinvo.Domain.Interfaces.Repositories;
using Kinvo.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kinvo.Infra.Data.Repositories
{
    public class ProdutoRepository
        : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ProdutoContext contexto) : base(contexto)
        {
        }
    }
}
