using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.ISP_Without_Voilate
{
    public class Parrot : IBird, IFlyable
    {
        public void Eat()
        {
            Console.WriteLine("Parrot can eat!");
        }

        public void Fly()
        {
            Console.WriteLine("Parrot can fly!");
        }

        public void MakeSound()
        {
            Console.WriteLine("Parrot can make sound!");
        }

        public void Sleep()
        {
            Console.WriteLine("Parrot can sleep!");
        }
    }
}
