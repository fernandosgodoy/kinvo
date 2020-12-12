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
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<Entity, Dto> 
        : Controller
        where Entity : BaseEntity
        where Dto : DTOBase
    {
        readonly protected IAppBase<Entity, Dto> _app;

        public BaseController(IAppBase<Entity, Dto> app)
        {
            this._app = app;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Listar()
        {
            try
            {
                return new OkObjectResult(_app.SelecionarTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult SelecionarPorId(int id)
        {
            try
            {
                return new OkObjectResult(_app.SelecionarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Incluir([FromBody] Dto dto)
        {
            try
            {
                return new OkObjectResult(_app.Incluir(dto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] Dto dto)
        {
            try
            {
                _app.Alterar(dto);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                _app.Excluir(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}