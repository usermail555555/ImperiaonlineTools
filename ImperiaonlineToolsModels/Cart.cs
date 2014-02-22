using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperiaonlineToolsModels
{
    public class Cart
    {
        public int CartId { get; set; }
        private ICollection<Product> products;
        public Cart()
        {
            this.products = new HashSet<Product>();
        }
        public virtual ICollection<Product> Products
        {
            get { return this.products; }
            set { products = value; }
        }

        
    }
}
