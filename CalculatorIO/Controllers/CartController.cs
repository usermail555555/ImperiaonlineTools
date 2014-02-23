using Microsoft.AspNet.Identity;
using CalculatorIO.Models;
using ImperiaonlineToolsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CalculatorIO.Controllers
{
    public class CartController : Controller
    {
        
        public ActionResult AddToCart(Product product)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            ApplicationUser user = userManager.FindByNameAsync(User.Identity.Name).Result;
            List<Product> products = new List<Product>();
            user.UserCart.Products.Add(product);
            foreach (var item in user.UserCart.Products)
            {
                products.Add(item);
            }
            return View(products);
        }
	}
}