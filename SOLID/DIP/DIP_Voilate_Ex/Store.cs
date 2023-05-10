using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.DIP_Voilate_Ex
{
    internal class ElectricStore
    {
        private Stripe? _stripe;
        public ElectricStore(string user)
        {
            _stripe = new Stripe(user); 
        }

        public void PurchaseLaptop(int quantity)
        {
            decimal Price = 57000;
            _stripe?.MakePayment(quantity * Price);
        }

        public void PurchaseMobile(int quantity)
        {
            decimal Price = 17000;
            _stripe?.MakePayment(quantity * Price);
        }
    }
}
