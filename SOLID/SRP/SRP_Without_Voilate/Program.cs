using SOLID.SRP.SRP_Voilate_Ex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.SRP_Without_Voilate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Here this program voilate SRP because SRP state that class | module | function etc.. have only one reason to change or onlt have single responsibility to do
               but in our case class CalorieTracker have two reason or two responsibility one is calculate calorie tracker and 2 is log or ping the user when exceed colorie
               so it's voilate SRP, If i have to change log message or change way to calulate colaries we can do two things on one class | module...
            */
            CalorieTrack calorieTracker = new CalorieTrack(2430);

            calorieTracker.StartCalorieTracker(300);
            calorieTracker.StartCalorieTracker(500);
            calorieTracker.StartCalorieTracker(1000);
            calorieTracker.StartCalorieTracker(700);
        }

        
    }
}
