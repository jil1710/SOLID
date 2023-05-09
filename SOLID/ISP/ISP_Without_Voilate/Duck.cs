using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.ISP_Without_Voilate
{
    public class Duck : IBird,ISwimable
    {
        public void Eat()
        {
            Console.WriteLine("Duck can eat!");
        }

        public void Swim()
        {
            Console.WriteLine("Duck can fly!");
        }

        public void MakeSound()
        {
            Console.WriteLine("Duck can make sound!");
        }

        public void Sleep()
        {
            Console.WriteLine("Duck can sleep!");
        }
    }
}
