using Bryan.TesteGFT.ApplicationService.ViewModels;
using Bryan.TesteGFT.Integration.Tests.Factories;
using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace Bryan.TesteGFT.Integration.Tests.IntegrationTests
{
    public class CompanyControllerTest
    {
        private readonly CompanyControllerFactory factory;

      /*  public CompanyControllerTest()
        {
            factory = new CompanyControllerFactory(BaseControllerTest.Client);
        }

        [Test]
        public async Task WhenCreate_Then_ICanFindItById()
        {
            // Act
            var viewModelCreate = await factory.Create();
            var responseGet = await factory.Get(viewModelCreate.Id);

            var viewModelGet =
                JsonConvert.DeserializeObject<CompanyViewModel>(responseGet.Result.ToString());

            // Assert
            responseGet.StatusCode.Should().Be((int)HttpStatusCode.OK);
            viewModelGet.Should().BeOfType<CompanyViewModel>();
            viewModelGet.Id.Should().NotBeEmpty();
            viewModelGet.Id.Should().Be(viewModelCreate.Id);
            viewModelGet.Name.Should().Be(viewModelCreate.Name);
        }

        [Test]
        public async Task WhenCreateAndDelete_Then_Deleted()
        {
            // Act
            var viewModelCreate = await factory.Create();
            await factory.Delete(viewModelCreate.Id);
            var responseGet = await factory.Get(viewModelCreate.Id);

            // Assert
            responseGet.StatusCode.Should().Be((int)HttpStatusCode.NoContent);
        }

        [Test]
        public async Task WhenCreateAndUpdate_Then_ICanFindItById()
        {
            // Act
            var viewModelCreate = await factory.Create();
            var viewModelUpdate = await factory.Update(viewModelCreate);
            var responseGet = await factory.Get(viewModelCreate.Id);
            var viewModelGet =
                JsonConvert.DeserializeObject<CompanyViewModel>(responseGet.Result.ToString());

            // Assert
            responseGet.StatusCode.Should().Be((int)HttpStatusCode.OK);
            viewModelGet.Should().BeOfType<CompanyViewModel>();
            viewModelGet.Id.Should().Be(viewModelUpdate.Id);
            viewModelGet.Name.Should().Be(viewModelUpdate.Name);
        }

        [Test]
        public async Task WhenCreateAndUpdateAndDelete_Then_Success()
        {
            // Act
            var viewModelCreate = await factory.Create();
            var viewModelUpdate = await factory.Update(viewModelCreate);

            var responseGet = await factory.Get(viewModelCreate.Id);
            var viewModelGet =
                JsonConvert.DeserializeObject<CompanyViewModel>(responseGet.Result.ToString());

            await factory.Delete(viewModelCreate.Id);
            var responseGetAfterDelete = await factory.Get(viewModelCreate.Id);

            // Assert
            viewModelGet.Id.Should().Be(viewModelUpdate.Id);
            viewModelGet.Name.Should().Be(viewModelUpdate.Name);

            responseGetAfterDelete.StatusCode.Should().Be((int)HttpStatusCode.NoContent);
        }
        */
    }
}