using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.LSP_Without_Voilate
{
    internal class TransportWithEngine : Transport
    {
        private string? EngineType;
        public virtual void SetEngineType(string engineType)
        {
            EngineType = engineType;
        }
    }
}
