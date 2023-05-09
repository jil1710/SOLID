using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.SRP_Without_Voilate
{
    internal class CalorieTrack
    {
        private int _maxCalorie;
        private int _currentCalorie = 0;

        public CalorieTrack(int calorie)
        {
            _maxCalorie = calorie;
        }

        public void StartCalorieTracker(int currentCalorie)
        {
            _currentCalorie += currentCalorie;
            if (_currentCalorie > _maxCalorie)
            {
                Logger.LogCalorieStatus(_maxCalorie,_currentCalorie);
            }
            else
            {
                Console.WriteLine("\nYour current calorie is " + _currentCalorie);
            }
        }
    }
}
