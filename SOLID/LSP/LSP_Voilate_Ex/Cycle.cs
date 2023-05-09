using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.LSP_Voilate_Ex
{
    internal class Cycle : Transportation
    {
        public double Price = 5000;

        // Cycle cannot have engine so it's not a point to having it here...
        public override void SetEngineType(string enginetype)
        {
            base.SetEngineType(enginetype);
        }
    }
}
