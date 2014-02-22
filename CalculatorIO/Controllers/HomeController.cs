using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayPal.PayPalAPIInterfaceService.Model;

namespace CalculatorIO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Coments()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult IPN()
        //{
        //    byte[] bytes = Request.BinaryRead(Request.ContentLength);

        //    PayPal.IPNMessage message = new PayPal.IPNMessage(bytes);
        //    if (message.Validate())
        //    {
        //        return View(message.ToString());
        //        // message returned VERIFIED
        //    }
        //    else
        //    {
                
        //        // There was a problem
        //    }

        //    return null;
        //}

        public ActionResult IPN(PayPal.IPNMessage msg)
        {
            return View(msg.ToString());
        }
    }
}