using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Sample.API.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new RedirectResult("~/swagger");
        }
    }
}