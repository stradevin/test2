using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpGet]
        public ActionResult Get_State2(string postcode)
        {

            string result = "";
            var buff_temp = "";

            if (postcode != "" && postcode != null)
            {

                buff_temp = "1111";
            }


            return Json(result, JsonRequestBehavior.AllowGet);

        }
    }
}