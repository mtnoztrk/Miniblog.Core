namespace Miniblog.Core.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class AboutController : Controller
    {
        [Route("/about")]
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index() => this.View();
    }
}
