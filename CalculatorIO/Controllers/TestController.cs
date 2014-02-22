using ImperiaonlineToolsDb.DAL;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImperiaonlineToolsModels;

namespace CalculatorIO.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult GetProduct()
        {
            
            ImperiaonlineToolsContext db = new ImperiaonlineToolsContext();
            var products = from p in db.Products
                           select p;
            var productModels = new List<Product>();
            foreach (var item in products)
            {
                productModels.Add(item);
            }
            return View(productModels);
        }
	}
}