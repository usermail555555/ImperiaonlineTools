using ImperiaonlineToolsModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorIO.Controllers
{
    public class PayPalMvcController : Controller
    {
        //
        // GET: /PayPal/
        public class PayPalController : Controller
        {
            public ActionResult RedirectFromPaypal()
            {
                return View();
            }
            public ActionResult CancelFromPaypal()
            {
                return View();
            }
            public ActionResult NotifyFromPaypal()
            {
                return View();
            }
            //public ActionResult ValidateCommand(string product, string totalPrice)
            //{
            //    return View();
            //}

            //[Authorize(Roles="Customers")]
            public ActionResult ValidateCommand(string product, string totalPrice)
            {
                bool useSandbox = Convert.ToBoolean(ConfigurationManager.AppSettings["IsSandbox"]);
                var paypal = new PayPalModel(useSandbox);
                paypal.item_name = product;
                paypal.amount = totalPrice;
                return View(paypal);
            }
        }
	}
}