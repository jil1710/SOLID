using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.LSP_Without_Voilate
{
    internal class Transport
    {
        private string? Name { get; set; }
        private double Speed { get; set; }


        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }

        public void SetSpeed(double speed)
        {
            Speed = speed;
        }
        public double GetSpeed()
        {
            return Speed;
        }
    }
}
