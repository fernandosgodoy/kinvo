using Microsoft.Extensions.DependencyInjection;
using System;

namespace Kinvo.Infra.IoC
{
    public class InjectorDependencies
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            //Aplicação
            //serviceCollection.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
            //serviceCollection.AddScoped<ICondominioApp, CondominioApp>();

            //Dominio
            //serviceCollection.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            //serviceCollection.AddScoped<ICondominioService, CondominioService>();

            //Repositorio
            //serviceCollection.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));
            //serviceCollection.AddScoped<ICondominioRepository, CondominioRepository>();

        }
    }
}
