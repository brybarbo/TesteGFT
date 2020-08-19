using Bryan.TesteGFT.ApplicationService.Interfaces;
using Api.Common.WebServer.Server;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

namespace Bryan.TesteGFT.ApplicationService.Services
{
    public abstract class BaseAppService : IBaseAppService
    {
        protected BaseAppService(IHttpContextAccessor contextAccessor)
        {
            var headerUserId = contextAccessor.HttpContext?.Request.Headers["UserId"].FirstOrDefault();

            if (headerUserId != null)
                CurrentUser = new UserContext { Id = Guid.Parse(headerUserId) };
        }

        public UserContext CurrentUser { get; set; }
    }
}