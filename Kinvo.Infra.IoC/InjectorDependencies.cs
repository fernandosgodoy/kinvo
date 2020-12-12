using Kinvo.Application.Interfaces;
using Kinvo.Application.Services;
using Kinvo.Domain.Entities;
using Kinvo.Domain.Interfaces.Repositories;
using Kinvo.Domain.Interfaces.Services;
using Kinvo.Domain.Services;
using Kinvo.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Kinvo.Infra.IoC
{
    public class InjectorDependencies
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            //Aplicação
            serviceCollection.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
            serviceCollection.AddScoped<IProdutoApp, ProdutoApp>();

            //Dominio
            serviceCollection.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            serviceCollection.AddScoped<IProdutoService, ProdutoService>();

            //Repositorio
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));
            serviceCollection.AddScoped<IProdutoRepository, ProdutoRepository>();

        }
    }
}
