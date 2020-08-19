using Bryan.TesteGFT.Integration.Tests.Factories.Interface;
using Bryan.TesteGFT.Integration.Tests.IntegrationTests;
using Autofac;

namespace Bryan.TesteGFT.Integration.Tests.InjectionModules
{
    public class IoCModuleIntegrationTest : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(BaseControllerTest).Assembly)
                .Where(c => c.IsAssignableTo<IBaseIntegrationTestFactory>())
                .AsSelf();
        }
    }
}