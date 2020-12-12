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
    public class ServicoAppBase<TEntity, TDto>
        : IAppBase<TEntity, TDto>
        where TEntity : BaseEntity
        where TDto : DTOBase
    {

        protected readonly IServiceBase<TEntity> _service;
        protected readonly IMapper _mapper;

        public ServicoAppBase(IMapper mapper, IServiceBase<TEntity> service)
            : base()
        {
            this._service = service;
            this._mapper = mapper;
        }

        public void Alterar(TDto entity)
        {
            _service.UpdateItem(_mapper.Map<TEntity>(entity));
        }

        public void Excluir(int id)
        {
            _service.RemoveItem(id);
        }

        public void Excluir(TDto entity)
        {
            _service.RemoveItem(_mapper.Map<TEntity>(entity));
        }

        public int Incluir(TDto entity)
        {
            return _service.InsertItem(_mapper.Map<TEntity>(entity));
        }

        public TDto SelecionarPorId(int id)
        {
            return _mapper.Map<TDto>(_service.Find(id));
        }

        public IEnumerable<TDto> SelecionarTodos()
        {
            return _mapper.Map<IEnumerable<TDto>>(_service.ListAll());
        }

    }
}
