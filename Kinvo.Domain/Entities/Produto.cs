using Kinvo.Domain.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinvo.Domain.Entities
{
    public class Produto
        : BaseEntity
    {

        public string Nome { get; set; }
        public CategoriaProduto CategoriaProduto { get; set; }

    }
}
