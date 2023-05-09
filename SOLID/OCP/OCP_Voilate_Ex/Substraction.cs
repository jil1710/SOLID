using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.OCP_Voilate_Ex
{
    internal class Substraction
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int result { get; set; }

        public Substraction(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
    }
}
