using Kinvo.Application.DTO;
using Kinvo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kinvo.Application.Interfaces
{
    public interface IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : BaseEntity
        where TEntidadeDTO : DTOBase
    {
        int Incluir(TEntidadeDTO entidade);
        void Excluir(int id);
        void Excluir(TEntidadeDTO entidade);
        void Alterar(TEntidadeDTO entidade);
        TEntidadeDTO SelecionarPorId(int id);
        IEnumerable<TEntidadeDTO> SelecionarTodos();
    }
}
