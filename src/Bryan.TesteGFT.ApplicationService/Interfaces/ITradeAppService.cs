using Bryan.TesteGFT.ApplicationService.ViewModels;
using Bryan.TesteGFT.Domain;
using System.Collections.Generic;

namespace Bryan.TesteGFT.ApplicationService.Interfaces
{
    public interface ITradeAppService
    {
        IEnumerable<TradeCategoryViewModel> GetAll(IEnumerable<ITrade> lstTrade);
    }
}