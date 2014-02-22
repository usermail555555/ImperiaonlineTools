using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperiaonlineToolsModels
{
    public class Product
    {
        
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public int PayPalButtonId { get; set; }
        public virtual PayPalButton PayPalButton { get; set; }

        public Product() { }

        public Product(Product product)
        {
            this.Title = product.Title;
            this.Price = product.Price;
            this.Description = product.Description;
            this.VideoUrl = product.VideoUrl;
            this.PayPalButton = new PayPalButton(product);
        }
        
    }
}
