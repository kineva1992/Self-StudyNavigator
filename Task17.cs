using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
    /*
     Домашнее задание

     Создайте абстрактный класс Человек, пусть там будет свойство Имя и абстрактный метод СказатьПриветствие(), 
    от этого класса будет несколько наследников, которые представляют национальность (русский, украинец, американец...). 
    Должно получиться так, что при вызове метода СказатьПриветствие() выводилось приветствие на языке соответствующему 
    национальности (Привет, Привіт, Hi...).

     */
    
    abstract class Man
    {
         string Name{get; set;}
         string Hello{get; set;}
        
         abstract void SayHello();
    }
    
    class Russian : Man
    {
        Russian(string name, string hello)
        {
            Name = "Russian";
            Hello = hello;
        }
        
         override void SayHello()
        {
            Console.WriteLine("One {0} said {1} ", Name, Hello);
        }
    }
    
    class Ukrainian : Man
    {
        Ukrainian(string name, string hello)
        {
            Name = "Ukrainian";
            Hello = hello;
        }
        
        override void SayHello()
        {
            Console.WriteLine("One {0} said {1}"Name, Hello);
        }
    }
    
    class American : Man
    {
        Ukrainian(string name, string hello)
        {
            Name = "Ukrainian";
            Hello = hello;
        }
        
        override void SayHello()
        {
            Console.WriteLine("One {0} said {1}", Name, Hello);
        }
    }
    

    class Task17
    {
    }
    
    class TvSwitch : ISwitchable 
    {
        //Включение
        void SwitchOn()
        {
            Console.WriteLie("Включить телевизор");
        }
    //Выключение
        void SwitchOff()
        {
            Console.WriteLie("Включить телевизор");
        }
    }
    
    class LaptopSwitch : ISwitchable
    {
        //Включение
        void SwitchOn()
        {
            Console.WriteLie("Включить ноутбук");
        }
        //Выключение
        void SwitchOff()
        {
            Console.WriteLie("Включить ноутбук");
        }
    }
}
