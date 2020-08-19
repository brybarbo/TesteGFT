using Bryan.TesteGFT.Domain.Models;
using Autofac;
using System.Reflection;
using Module = Autofac.Module;

namespace Bryan.TesteGFT.Domain.InjectionModules
{
    public class IoCModuleDomain : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assemblyToScan = Assembly.GetAssembly(typeof(UserDefinition));

            builder
                .RegisterAssemblyTypes(assemblyToScan)
                .Where(c => c.IsClass
                            && c.IsInNamespace("BBCE.Companies.Domain.CommandHandlers")).AsImplementedInterfaces();

            builder
                .RegisterAssemblyTypes(assemblyToScan)
                .Where(c => c.IsClass
                            && c.IsInNamespace("BBCE.Companies.Domain.Commands")).AsImplementedInterfaces();
        }
    }
}