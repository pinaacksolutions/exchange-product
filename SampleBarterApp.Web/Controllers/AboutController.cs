using System.Web.Mvc;

namespace SampleBarterApp.Web.Controllers
{
    public class AboutController : SampleBarterAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}