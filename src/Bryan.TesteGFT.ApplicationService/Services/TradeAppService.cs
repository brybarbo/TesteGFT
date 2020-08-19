using Bryan.TesteGFT.ApplicationService.Interfaces;
using Bryan.TesteGFT.ApplicationService.ViewModels;
using Bryan.TesteGFT.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Bryan.TesteGFT.ApplicationService.Services
{
    public class TradeAppService : ITradeAppService
    {
        public IEnumerable<TradeCategoryViewModel> GetAll(IEnumerable<ITrade> lstPortifolio)
        {
            var lstTradeCategoryViewModel = new List<TradeCategoryViewModel>();
            lstPortifolio.ToList().ForEach(delegate (ITrade item) { lstTradeCategoryViewModel.Add(new TradeCategoryViewModel(item.Value, item.ClientSector)); });
            return lstTradeCategoryViewModel;
        }
    }
}