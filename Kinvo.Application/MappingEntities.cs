using System;
using AutoMapper;
using Kinvo.Application.DTO;
using Kinvo.Domain.Entities;

namespace Kinvo.Application
{
    public class MappingEntities
        : Profile
    {
        public MappingEntities()
        {
            CreateMap<Produto, ProdutoDTO>();
            CreateMap<ProdutoDTO, Produto>();
        }

        public MappingEntities(string profileName)
            : base(profileName)
        {
        }
    }
}
