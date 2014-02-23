using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using ImperiaonlineToolsModels;

namespace CalculatorIO.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public Cart UserCart { get; set; }
        private ICollection<Product> products;
        public ApplicationUser()
            : base()
        {
            this.products = new HashSet<Product>();
        }

        public virtual ICollection<Product> Products
        {
            get { return this.Products; }
            set{ this.Products = value; }
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}