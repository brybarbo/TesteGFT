using Api.Common.WebServer.Server;
using Bryan.TesteGFT.ApplicationService.ViewModels;
using Bryan.TesteGFT.Integration.Tests.Factories.Interface;
using FluentAssertions;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bryan.TesteGFT.Integration.Tests.Factories
{
    public class CompanyControllerFactory : IBaseIntegrationTestFactory
    {
        private const string url = "/api/v1/Company";
        private readonly HttpClient client;

        public CompanyControllerFactory(HttpClient client)
        {
            this.client = client;
        }

      
    }
}