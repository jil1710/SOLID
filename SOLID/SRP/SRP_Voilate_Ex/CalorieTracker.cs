using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.SRP_Voilate_Ex
{
    internal class CalorieTracker
    {
        private int _maxCalorie;
        private int _currentCalorie = 0;

        public CalorieTracker(int calorie)
        {
            _maxCalorie = calorie;
        }

        public void StartCalorieTracker(int currentCalorie)
        {
            _currentCalorie += currentCalorie;
            if(_currentCalorie > _maxCalorie)
            {
                LogCalorieStatus();
            }
            else
            {
                Console.WriteLine("\nYour current calorie is " + _currentCalorie);
            }
        }

        public void LogCalorieStatus()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nAlert! Calorie Exceed From {_maxCalorie} by {Math.Abs(_maxCalorie - _currentCalorie)}... Take Care & Maintain Calories !!");
            Console.ResetColor();
        }
    }
}
