using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.ISP_Voilate_Ex
{
    internal class Program
    {
        public static void Verify(IBird bird)
        {
            bird.Sleep();
            bird.Fly();
            bird.Swim();
            bird.MakeSound();
            bird.Eat();
        }

        public static void Main(string[] args)
        {
            // Interface segregation principle simply state that client or module or class cannot be force to implement interface that they don't use..
            // Here Parrot class not need Swim() or Ostrich cannot needed Fly() or Swim() here we voilate this ISP...
            Console.WriteLine("Interface Segregation Principle Voilation Example !\n");
            Verify(new Parrot());
            Console.WriteLine("\n\n");
            Verify(new Ostrich());
        }
    }

   
}
