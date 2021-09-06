
using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
    class Task6
    {
        
        string[] daysOfTheWeek = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        var Seasons = new List<string> {"Spring", "Summer", "Autumn", "Winter"};
        
        /* Напишите код, в котором:
        1. Создайте одномерный массив, содержащий
        наименования дней недели.
        2. Выведите в консоль значение 5 элемента и длину
        массива.*/
        
        //Start task array
        
        public static void ReturnFiveElementsDaysOfTheWeekArray()
        {
        Console.WriteLine(daysOfTheWeek[4]);
        }
        
        public static void ReturnLengthArrayDaysOfTheWeekArray()
        {
        Console.WriteLine(daysOfTheWeek.length);
        }
        //End task Array
        
        //Start task List
        
        public static void PrintSeasonsSummer()
        {
        Console.Write(Seasons[1]);
        }
        
        
        
        // End task List
        
    }
}
