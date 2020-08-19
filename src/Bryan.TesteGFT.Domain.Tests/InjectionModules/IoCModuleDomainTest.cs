using Api.Common.Core.Authentication;
using Api.Common.Repository.Contracts.Core.Repository;
using Bryan.TesteGFT.Domain.Tests.Factories.Interface;
using Bryan.TesteGFT.Domain.Tests.UnitTests;
using Autofac;

namespace Bryan.TesteGFT.Domain.Tests.InjectionModules
{
    public class IoCModuleDomainTest : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Test Factories
            builder.RegisterAssemblyTypes(typeof(BaseDomainTests).Assembly)
                .Where(c => c.IsAssignableTo<IBaseDomainTestFactory>())
                .AsSelf();

            var signingConfigurations = new SigningConfigurations();
            builder.RegisterInstance(signingConfigurations);

            var tokenConfigurations = new TokenConfigurations();
            builder.RegisterInstance(tokenConfigurations);

            //register all IDatabaseMigration in this assembly
            builder.RegisterAssemblyTypes(typeof(BaseDomainTests).Assembly)
                .Where(c => c.IsAssignableTo<IDatabaseMigration>())
                .AsImplementedInterfaces();
        }
    }
}