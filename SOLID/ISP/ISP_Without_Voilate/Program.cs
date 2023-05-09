using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.ISP_Without_Voilate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface segregation principle without voilating ISP\n");
            Parrot parrot = new Parrot();
            parrot.MakeSound();
            parrot.Sleep();
            parrot.Fly();
            parrot.Eat();
            Console.WriteLine("\n\n");
            Duck duck = new Duck();
            duck.MakeSound();
            duck.Sleep();
            duck.Eat();
            duck.Swim();
        }
    }
}
