using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
    //Layar 0
    //Животные
    public abstract class Animal
    { 
        public int Weight { get; set; }
        public int Age { get; set; }
    }
    //Летающие
    public interface IFlying
    {
        public void Flying();
    }


    //Layar 1
    //Млекопетающие
    public class Mammul : Animal
    {
        public void FeedMilk()
        {
            Console.WriteLine("Кормить молоком");
        }
    }
    //Птицы
    public class Bird : Animal, IFlying
    {
        public void Flying()
        {
            Console.WriteLine("Птицы летают");
        }
    }
    //Layar 2

    //Собака
    public class Dog : Mammul
    {
        public void Bark()
        {
            Console.WriteLine("Лаять");
        }
    }
    //Летучии мыши
    public class Bat : Mammul, IFlying
    {
        public void Flying()
        {
            throw new NotImplementedException();
        }
    }

}
