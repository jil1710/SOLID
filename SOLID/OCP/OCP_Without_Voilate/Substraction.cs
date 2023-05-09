using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.OCP_Without_Voilate
{
    internal class Substraction : IOperation
    {
        private int num1 { get; set; }
        private int num2 { get; set; }

        public Substraction(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Perform()
        {
            return num1 - num2;
        }
    }
}
