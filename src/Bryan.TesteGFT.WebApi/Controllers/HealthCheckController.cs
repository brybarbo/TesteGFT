using Bryan.TesteGFT.ApplicationService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Bryan.TesteGFT.CI.WebApi.Controllers
{
    public class HealthCheckController : BaseController
    {
        private readonly ITradeAppService appService;
        private readonly ILogger<HealthCheckController> logger;

        public HealthCheckController(ITradeAppService appService,
            ILogger<HealthCheckController> logger)
        {
            this.appService = appService;
            this.logger = logger;
        }

        /// <summary>
        /// Verify system's conectivity
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await Task.Run(() =>
            {
                try
                {
                    const string message = "HealthCheck Status OK";
                    logger.LogInformation(message);
                    return Ok(message);
                }
                catch (Exception ex)
                {
                    return StatusCode((int)HttpStatusCode.InternalServerError, new { ex.Message });
                }
            });
        }
    }
}