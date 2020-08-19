using Bryan.TesteGFT.ApplicationService.Interfaces;
using Bryan.TesteGFT.ApplicationService.ViewModels;
using Bryan.TesteGFT.Domain.Tests.Factories.Interface;
using System;
using System.Collections.Generic;

namespace Bryan.TesteGFT.Domain.Tests.Factories
{
    public class CompanyFactory : IBaseDomainTestFactory
    {
        private readonly ITradeAppService appService;

        public CompanyFactory(ITradeAppService appService)
        {
            this.appService = appService;
        }
      
        public CompanyViewModel Get(Guid id)
        {
            return appService.Get(id);
        }

        public IEnumerable<CompanyViewModel> GetAll()
        {
            return appService.GetAll();
        }

        public IEnumerable<CompanyViewModel> GetListByName(string name)
        {
            return appService.GetListByName(name);
        }
    }
}
