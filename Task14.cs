using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
    public class Gay
    {
        public string Name;
        public int? CountChildred;

        public Gay(string name, int? countChildred)
        {
            this.Name = name;
            this.CountChildred = countChildred;
        }

        public void GetChildre()
        {
            Console.WriteLine(this.CountChildred == null ? $"No data about {this.Name}'s children" : 
                (this.CountChildred == 0 ? $"{this.Name} has no children" : $"{this.Name} has {this.CountChildred} children"));
        }
    }
   
    class Task14
    {
        public static void CountChildren(string name, int? count)
        {
            if (count == null)
            {
                Console.WriteLine("{0} Неизвестное количесво детей", name);
            }
            else
            {
                Console.WriteLine("{0}: Количество детей - {1}", name, count);
            }
        }
    }
}
