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
       protected  string Name{get; set;}
       protected string Hello{get; set;}
        
         public abstract void SayHello();
    }
    
    class Russian : Man
    {
        Russian(string name, string hello)
        {
            Name = "Russian";
            Hello = hello;
        }
        
        public override void SayHello()
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

        public override void SayHello()
        {
            Console.WriteLine("One {0} said {1}",Name, Hello);
        }
    }
    
    class American : Man
    {
        American(string name, string hello)
        {
            Name = "Ukrainian";
            Hello = hello;
        }

        public override void SayHello()
        {
            Console.WriteLine("One {0} said {1}", Name, Hello);
        }
    }
    

    class Task17
    {
    }
    
   public class TvSwitch : ISwitchable 
    {
        //Включение
        public void SwitchOn()
        {
            Console.WriteLine("Включить телевизор");
        }
        //Выключение
        public void SwitchOff()
        {
            Console.WriteLine("Включить телевизор");
        }
    }
    
   public class LaptopSwitch : ISwitchable
    {
        //Включение
        public void SwitchOn()
        {
            Console.WriteLine("Включить ноутбук");
        }
        //Выключение
        public void SwitchOff()
        {
            Console.WriteLine("Включить ноутбук");
        }
    }
    
    /*
    Контрольные вопросы
    1. Для нужны абстрактные классы?
    В абстрактных классах реализуеться базовая бизнес-логика приложения. 
    Которые обязанны реализовывать классы наследники.
    
    2. Ответьте на вопросы из раздела: https://metanit.com/sharp/questions/2.12.php (4 вопроса)
    
    Вопрос 1
    Следующая программа не компилируется. В чем ошибка?
    Нельзя использовать конструктор абстрактных классов
    
    Вопрос 2
    Какие члены класса могут быть определены как абстрактные?
    Методы, свойства, индексаторы, события.
    
    Вопрос 3
    Есть ли в следующем коде ошибка? Если есть, то какая?
    Ошибок в коде нет.
    
    Вопрос 4
    Что будет выведено на консоль в результате выполнения следующей программы и почему?
    Программа не скомпилируется, потому что класс наследник должен реализовывать все абстрактные методы класса родителя.

    3. Для чего нужны интерфейсы?
    Так же как и абстрактные классы описывают базывают сущьности бизнес-лоигки приложения, но в отличии от абстрактных классов, интерфейсы поддерживают множественное наследование.
    
    4. Может ли один класс реализовывать несколько интерфейсов?
    Да, в отличии от обычных классов или абстрактных классов, язык поддерживает множественное наследование интерфейсов.
    */
}
