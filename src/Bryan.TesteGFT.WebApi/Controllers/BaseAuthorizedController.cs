using Microsoft.AspNetCore.Authorization;

namespace Bryan.TesteGFT.CI.WebApi.Controllers
{
    [Authorize("Bearer")]
    public class BaseAuthorizedController : BaseController
    {
    }
}