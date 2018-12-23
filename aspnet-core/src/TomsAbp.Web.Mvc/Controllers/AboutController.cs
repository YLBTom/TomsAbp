using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TomsAbp.Controllers;

namespace TomsAbp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : TomsAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
