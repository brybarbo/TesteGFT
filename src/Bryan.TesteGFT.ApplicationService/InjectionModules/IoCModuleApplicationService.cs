using Bryan.TesteGFT.ApplicationService.Services;
using Autofac;
using System.Reflection;
using Module = Autofac.Module;

namespace Bryan.TesteGFT.ApplicationService.InjectionModules
{
    public class IoCModuleApplicationService : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assemblyToScan = Assembly.GetAssembly(typeof(TradeAppService));
            builder.RegisterAssemblyTypes(assemblyToScan).Where(c => c.IsClass && c.IsInNamespace("Bryan.TesteGFT.ApplicationService.Services")).AsImplementedInterfaces();
        }
    }
}
