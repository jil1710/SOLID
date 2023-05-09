using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.ISP_Voilate_Ex
{
    public class Parrot : IBird
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

        public void Swim()
        {
            Console.WriteLine(new NotImplementedException("Parrot cannot swim ! NO needed Swim() method to be implemented......").Message);
        }
    }
}
