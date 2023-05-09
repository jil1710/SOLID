using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.LSP_Without_Voilate
{
    internal class Car : TransportWithEngine
    {
        public double Price = 600000;

        public override void SetEngineType(string engineType)
        {
            if (engineType.Equals("Petrol"))
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
