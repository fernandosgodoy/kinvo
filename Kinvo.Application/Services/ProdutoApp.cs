using AutoMapper;
using Kinvo.Application.DTO;
using Kinvo.Application.Interfaces;
using Kinvo.Domain.Entities;
using Kinvo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kinvo.Application.Services
{
    public class ProdutoApp
        : ServicoAppBase<Produto, ProdutoDTO>, IProdutoApp
    {

        public ProdutoApp(IMapper mapper, IProdutoService service)
            : base(mapper, service)
        { }

    }
}
