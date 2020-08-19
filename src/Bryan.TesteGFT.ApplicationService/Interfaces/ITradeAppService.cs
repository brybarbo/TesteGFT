using Api.Common.Repository.Contracts.Core.Entities;
using Bryan.TesteGFT.ApplicationService.ViewModels;
using System.Collections.Generic;

namespace Bryan.TesteGFT.ApplicationService.Interfaces
{
    public interface ITradeAppService
    {
        IEnumerable<TradeCategoryViewModel> GetAll(IEnumerable<ITrade> lstTrade);
    }
}