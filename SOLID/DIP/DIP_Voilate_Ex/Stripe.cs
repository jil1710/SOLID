using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.DIP_Voilate_Ex
{
    internal class Stripe
    {
        private string? User;
        private decimal Tax = 1.4m;
        public Stripe(string user) 
        {
            User = user;
        }

        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"{User} make payment of {amount * Tax} ₹ with Strip... -->> Order ID. : {Guid.NewGuid().ToString().Substring(0,12)} -->> Tax : {Tax}");
        }

    }
}
