using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleBarterApp.Web.Controllers
{
    public class WebHomeController : Controller
    {
        // GET: WebHome
        public ActionResult Index()
        {
            return View();
        }      
    }
}