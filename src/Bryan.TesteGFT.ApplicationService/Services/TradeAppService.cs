using Api.Common.Cqrs.Core.Bus;
using Api.Common.Repository.Contracts.Core.Entities;
using Api.Common.Repository.Contracts.Core.Repository;
using AutoMapper;
using Bryan.TesteGFT.ApplicationService.Interfaces;
using Bryan.TesteGFT.ApplicationService.ViewModels;
using Bryan.TesteGFT.Domain.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bryan.TesteGFT.ApplicationService.Services
{
    public class TradeAppService : BaseAppService, ITradeAppService
    {

        public TradeAppService(IHttpContextAccessor contextAccessor) : base(contextAccessor)
        {
        }

        public IEnumerable<TradeCategoryViewModel> GetAll(IEnumerable<ITrade> lstPortifolio)
        {
            var lstTradeCategoryViewModel = new List<TradeCategoryViewModel>();

            lstPortifolio.ToList().ForEach(delegate (ITrade item)
            {
                var tradeCategoryViewModel = new TradeCategoryViewModel();
                if (item.Valor <= 1000000 && item.ClientSector.ToUpper() == "PUBLIC")
                {
                    tradeCategoryViewModel.Category = "LOWRISK";
                    lstTradeCategoryViewModel.Add(tradeCategoryViewModel);
                }
                else if (item.Valor > 1000000 && item.ClientSector.ToUpper() == "PUBLIC")
                {
                    tradeCategoryViewModel.Category = "MEDIUMRISK";
                    lstTradeCategoryViewModel.Add(tradeCategoryViewModel);
                }
                else if (item.Valor > 1000000 && item.ClientSector.ToUpper() == "PRIVATE")
                {
                    tradeCategoryViewModel.Category = "HIGHRISK";
                    lstTradeCategoryViewModel.Add(tradeCategoryViewModel);
                }
            });

            return lstTradeCategoryViewModel;
        }
    }
}