using Microsoft.AspNetCore.Antiforgery;
using TomsAbp.Controllers;

namespace TomsAbp.Web.Host.Controllers
{
    public class AntiForgeryController : TomsAbpControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
