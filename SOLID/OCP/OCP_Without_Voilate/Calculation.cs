using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.OCP_Without_Voilate
{
    internal class Calculation
    {
        public int calculateOperation(IOperation operationType)
        {
            return operationType.Perform();
        }

        static void Main(string[] args)
        {
            /* OCP state that class or module should be open for extension but close for modification which simple implice
               that without affecting/touching the class extend feature of the module or class...
               So now even you have to add or extend the feature then you not have to touch Calculation class just simply create Division class implement
               to IOperation interface and i work fine likewise you can make code mantainable and reusable or readable...
            */  
            Calculation calculation = new Calculation();

            Addition addition = new Addition(20, 30);
            Console.WriteLine("Addition : " + calculation.calculateOperation(addition));
            Substraction substraction = new Substraction(30, 20);
            Console.WriteLine("Substraction : " + calculation.calculateOperation(substraction));
            Multiplication multiplication = new Multiplication(20, 20);
            Console.WriteLine("Multiplication : " + calculation.calculateOperation(multiplication));

        }
    }
}
