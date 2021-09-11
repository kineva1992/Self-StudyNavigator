using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
    struct State
    {
        public int x;
        public int y;
        public Country country;
    }

    class Country
    {
        public int x;
        public int y;
    }

    class Persons
    {
        public string Name;
        public int Age;
        
    }
    class Task13
    {
        /*
        1. Приведите примеры значимых и ссылочных типов.
        Значимые типы: byte, sbyte, short, ushort, int, uint, long, ulong, bool, char, enum, struct
        Ссылочные типы: class, object, interface, delegate, string.
        2. Будут ли равны значения переменных x и z из примера ниже, если переменные y и z значимого типа?
        Ссылочного типа?
        var x = y;
        y = z; \\ z и y - ранее инициализированные переменные одного типа.
        Да, в обоих случаях будут одинаковые начения, потому что у нас в стеке храниться переменная с определенным значением, 
        мы присваиваем значение переменной другой переменной например x = y.
        Предположим, что у нас переменная x,y ссылочного типа, которая храниться в куче и мы хотим присвоить переменной z занчение переменной y, 
        мы ссылаемся на область памяти в которой храниться значение переменнной y, то есть мы получаем то же самое значение что у переменной y.

        3. Что будет выведено в консоль в 7 строке? Можно ли после 6 строки получить доступ к объекту,
        созданному в 5 строке?
        1. class Program
        2. {
        3. static void Main(string[] args)
        4. {
        5. Person p = new Person {name = "Tom"};
        6. p = new Person {name = "Peter"};
        7. Console.WriteLine(p.name);
        9. }
        9. }
        10.class Person
        11.{
        12. public string name;
        13.}

            Persons persons = new Persons { Name = "Tom" };
            Console.WriteLine(persons.Name);
            persons = new Persons { Name = "Peeter" };
            Console.WriteLine(persons.Name);
         */
    }
}
