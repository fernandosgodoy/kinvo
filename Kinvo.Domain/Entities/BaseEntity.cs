using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinvo.Domain.Entities
{
    public class BaseEntity
    {

        public BaseEntity() { }

        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtu { get; set; }
    }
}
