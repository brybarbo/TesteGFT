using Bryan.TesteGFT.ApplicationService.Interfaces;
using Bryan.TesteGFT.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Bryan.TesteGFT.CI.WebApi.Controllers
{
    public class TradeController : BaseController
    {
        private readonly ITradeAppService appService;

        public TradeController(ITradeAppService appService)
        {
            this.appService = appService;
        }

        [HttpGet("Category")]
        public IActionResult Get()
        {
            var lstTrade = new List<Trade>
            {
                new Trade (2000000, "Private"),
                new Trade (400000, "Public"),
                new Trade (500000, "Public"),
                new Trade (3000000, "Public")
            };

            return Ok(appService.GetAll(lstTrade).Select(p => p.Category).ToArray());
        }
    }
}