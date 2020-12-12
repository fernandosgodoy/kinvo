using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kinvo.Application.DTO;
using Kinvo.Application.Interfaces;
using Kinvo.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kinvo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController 
        : BaseController<Produto, ProdutoDTO>
    {
        public ProdutoController(IAppBase<Produto, ProdutoDTO> app)
            : base(app)
        {
        }
    }
}