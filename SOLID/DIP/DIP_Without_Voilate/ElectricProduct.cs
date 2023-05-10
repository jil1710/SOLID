using SOLID.DIP.DIP_Voilate_Ex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.DIP_Without_Voilate
{
    internal class ElectricProduct
    {
        private StripePaymentProcesser? _stripe;
        public ElectricProduct(string user)
        {
            _stripe = new StripePaymentProcesser(user);
        }

        public void PurchaseLaptop(int quantity)
        {
            decimal Price = 57000;
            _stripe?.Pay(quantity * Price);
        }

        public void PurchaseMobile(int quantity)
        {
            decimal Price = 17000;
            _stripe?.Pay(quantity * Price);
        }
    }
}
