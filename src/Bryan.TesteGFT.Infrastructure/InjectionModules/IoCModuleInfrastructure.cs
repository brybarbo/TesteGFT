using Api.Common.Cqrs.Core.Bus;
using Bryan.TesteGFT.Infrastructure.Bus;
using Autofac;
using Microsoft.AspNetCore.Http;
using System.Reflection;
using Module = Autofac.Module;
using Microsoft.EntityFrameworkCore;
using Api.Common.Repository.EFCore;

namespace Bryan.TesteGFT.Infrastructure.InjectionModules
{
    public class IoCModuleInfrastructure : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // ASP.NET HttpContext dependency
            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();

            // Infra - Repository            
            builder.RegisterType<EFCoreUnitOfWork>()
                .AsImplementedInterfaces();

            builder.RegisterGeneric(typeof(EfCoreRepository<>))
                .AsImplementedInterfaces();

            var assemblyToScan = Assembly.GetAssembly(typeof(MessageBus));
            builder
                .RegisterAssemblyTypes(assemblyToScan)
                .Where(c => c.IsClass
                            && c.IsInNamespace("BBCE.Companies.Infrastructure.Services")).AsImplementedInterfaces();
        }
    }
}