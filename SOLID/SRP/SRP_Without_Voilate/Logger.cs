using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.SRP_Without_Voilate
{
    internal class Logger
    {
        public static void LogCalorieStatus(int _maxCalorie , int _currentCalorie)
        {
            // Here we seperate Log Method so in future we have to change the way to log the user we can easily do just by changing here
            // You can mail, sms, etc...
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nAlert! Calorie Exceed From {_maxCalorie} by {Math.Abs(_maxCalorie - _currentCalorie)}... Take Care & Maintain Calories !!");
            Console.ResetColor();
        }
    }
}
