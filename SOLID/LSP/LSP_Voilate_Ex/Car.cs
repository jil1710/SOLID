using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.LSP_Voilate_Ex
{
    internal class Car : Transportation
    {
        public double Price { get; set; } = 600000;

        public override void SetEngineType(string enginetype)
        {
            if (enginetype.Equals("Petrol"))
            {
                Price += 50000;
            }
            else
            {
                Price += 100000;
            }
        }
    }
}
