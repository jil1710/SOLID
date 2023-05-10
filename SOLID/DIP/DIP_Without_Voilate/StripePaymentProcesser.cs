using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.DIP_Without_Voilate
{
    internal class StripePaymentProcesser
    {
        private string? _user;
        private Stripe? _stripe;
        public StripePaymentProcesser(string user)
        {
            _user = user;
            _stripe = new Stripe(_user);
        }

        public void Pay(decimal amount)
        {
            _stripe?.MakePayment(amount);
        }
    }
}
