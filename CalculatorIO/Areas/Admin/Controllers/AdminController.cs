using ImperiaonlineToolsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorIO.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/CreateProduct/
        public ActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            var db = new ImperiaonlineToolsDb.DAL.ImperiaonlineToolsContext();
            Product newProduct = new Product();
            {
                newProduct.Title = product.Title;
                newProduct.Price = product.Price;
                newProduct.Description = product.Description;
                newProduct.VideoUrl = product.VideoUrl;
                newProduct.PayPalButton = new PayPalButton(product);
            }

            if (ModelState.IsValid)
            {
                
                db.Products.Add(newProduct);
                db.SaveChanges();
                return PartialView("_CreateProductOk");
            }
            else
            {
                return PartialView("_CreateProductError");
            }
        }
	}
}