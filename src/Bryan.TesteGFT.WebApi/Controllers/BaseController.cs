using Microsoft.AspNetCore.Mvc;

namespace Bryan.TesteGFT.CI.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public class BaseController : Controller
    {
    }
}