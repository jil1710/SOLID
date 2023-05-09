using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.ISP_Voilate_Ex
{
    public interface IBird
    {
        void MakeSound();
        void Sleep();
        void Eat();
        void Swim();
        void Fly();
    }
}
