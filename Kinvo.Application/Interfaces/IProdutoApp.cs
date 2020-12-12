using Kinvo.Application.DTO;
using Kinvo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kinvo.Application.Interfaces
{
    public interface IProdutoApp
        : IAppBase<Produto, ProdutoDTO>
    {
    }
}
