using Bryan.TesteGFT.ApplicationService.Services;
using Autofac;
using System.Reflection;
using Module = Autofac.Module;
using Api.Common.WebServer.Server;

namespace Bryan.TesteGFT.Domain.InjectionModules
{
    public class IoCModuleApplicationService : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Domain Modules: Command and CommandHandlers
            builder.RegisterModule<IoCModuleDomain>();

            var assemblyToScan = Assembly.GetAssembly(typeof(BaseAppService));

            builder
                .RegisterAssemblyTypes(assemblyToScan)
                .Where(c => c.IsClass
                            && c.IsInNamespace("Bryan.TesteGFT.ApplicationService.Services")).AsImplementedInterfaces();

            builder.RegisterType<UserContext>().AsSelf();
        }
    }
}