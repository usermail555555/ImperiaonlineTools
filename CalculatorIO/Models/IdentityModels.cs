using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using ImperiaonlineToolsModels;

namespace CalculatorIO.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        private ICollection<Product> userProducts;
        public ApplicationUser()
            : base()
        {
            this.userProducts = new HashSet<Product>();
        }

        public virtual ICollection<Product> UserProducts
        {
            get { return this.userProducts; }
            set{ this.userProducts = value; }
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