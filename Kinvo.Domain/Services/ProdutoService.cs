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
    public class ProdutoService
        : ServiceBase<Produto>, IProdutoService
    {
        public ProdutoService(IRepository<Produto> repositorio)
            : base(repositorio)
        {
        }
    }
}
