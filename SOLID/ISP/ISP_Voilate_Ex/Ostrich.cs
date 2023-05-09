using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.ISP_Voilate_Ex
{
    public class Ostrich : IBird
    {
        public void Eat()
        {
            Console.WriteLine("Ostrich can eat!");
        }

        public void Fly()
        {
            Console.WriteLine(new NotImplementedException("Ostrich cannot fly ! NO needed Fly() method to be implemented......").Message);
        }

        public void MakeSound()
        {
            Console.WriteLine("Ostrich can make sound!");
        }

        public void Sleep()
        {
            Console.WriteLine("Ostrich can sleep!");
        }

        public void Swim()
        {
            Console.WriteLine(new NotImplementedException("Ostrich cannot swim ! NO needed Swim() method to be implemented......").Message);
        }
    }
}
