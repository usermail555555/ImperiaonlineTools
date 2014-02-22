using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperiaonlineToolsModels
{
    public class PayPalButton
    {
        public int PayPalBtnId { get; set; }
        //public string Action { get; set; }
        public string Value { get; set; }
        //public string Image { get; set; }

        public PayPalButton() { }

        public PayPalButton(Product prod)
        {
            //this.Action = prod.PayPalButton.Action;
            this.Value = prod.PayPalButton.Value;
            //this.Image = prod.PayPalButton.Image;
        }
    }
}
