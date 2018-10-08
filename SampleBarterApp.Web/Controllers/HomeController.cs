using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace SampleBarterApp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SampleBarterAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}