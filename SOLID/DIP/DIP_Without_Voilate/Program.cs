using SOLID.DIP.DIP_Voilate_Ex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.DIP_Without_Voilate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here high level module|class ElectricStore depends on low level module|class Stripe which voilate DIP principle 
            // Instead it depands on Abstraction|interface
            ElectricStore electricStore = new ElectricStore("Jil Patel");
            electricStore.PurchaseLaptop(3);
            electricStore.PurchaseMobile(2);
        }
    }
}
