using Api.Common.WebServer.Server;

namespace Bryan.TesteGFT.ApplicationService.Interfaces
{
    public interface IBaseAppService
    {
        UserContext CurrentUser { get; set; }
    }
}