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
        public string AtivoSigla { get; set; }
        public int? Qtde { get; set; }
        public string Instituicao { get; set; }
        public decimal PrecoCompra { get; set; }
        public DateTime DataInicio { get; set; }
        public decimal TaxaCorretagem { get; set; }
        public decimal? TaxaAnual { get; set; }

    }
}
