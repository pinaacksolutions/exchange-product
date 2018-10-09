using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleBarterApp.Web.Controllers
{
    public class HomeBuilt1Controller : Controller
    {
        // GET: HomeBuilt1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PrivacyPolicy()
        {
            return View("PrivacyPolicy");
        }
        public ActionResult WebListingProduct()
        {
            return View("WebListingProduct");
        }
        public ActionResult Login()
        {
            return View("Login");
        }
        public ActionResult SignUp()
        {
            return View("SignUp");
        }
        public ActionResult ProductDetails()
        {
            return View("ProductDetails");
        }
        public ActionResult Dashboard()
        {
            return View("Dashboard");
        }
        public ActionResult MessageHistory()
        {
            return View("MessageHistory");
        }
        public ActionResult UserProfile()
        {
            return View("UserProfile");
        }
        public ActionResult AddProduct()
        {
            return View("AddProduct");
        }
        public ActionResult About()
        {
            return View("About");
        }
        public ActionResult SafetyTips()
        {
            return View("SafetyTips");
        }
        public ActionResult FAQ()
        {
            return View("FAQ");
        }
        public ActionResult Notification()
        {
            return View("Notification");
        }
        public ActionResult IndentityVerification()
        {
            return View("IndentityVerification");
        }
        public ActionResult NewDashBoard()
        {
            return View("NewDashBoard");
        }
        public ActionResult NewMessageHistory()
        {
            return View("NewMessageHistory");
        }
        public ActionResult NewMessageHistory1()
        {
            return View("NewMessageHistory1");
        }
        public ActionResult ProductDetail()
        {
            return View("ProductDetail");
        }
        
        // By Mayank
        public ActionResult NewIndex()
        {
            return View();
        }
        //public ActionResult ResetPassword()
        //{
        //    return View();
        //}

    }
}