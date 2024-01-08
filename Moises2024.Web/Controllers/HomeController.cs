using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Moises2024.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : Moises2024ControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}