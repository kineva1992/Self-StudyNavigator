using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
    class People
    {
        
        public string Name { get; set; }

        public People(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : People
    { 
    public string Company { get; set;}
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
    }

    class Auto  // легковой автомобиль
    {
        public int Seats { get; set; } // количество сидений
        public Auto()
        {
            Console.WriteLine("Auto has been created");
        }
        public Auto(int seats)
        {
            Seats = seats;
        }
    }
    class Truck : Auto      // грузовой автомобиль
    {
        public decimal Capacity { get; set; } // грузоподъемность
        public Truck(decimal capacity)
        {
            Seats = 2;
            Capacity = capacity;
            Console.WriteLine("Truck has been created");
        }
    }

    /*
    Домашнее задание:

    Создайте базовый класс Геометрическая фигура, предусмотрите в нем общие поля/свойства, например координаты центра фигуры, 
    с помощью конструктора должна быть возможность задать центр. На базе этого класса создайте два новых – Треугольник и Окружность. 
    В этих классах должны быть свои особые поля, например радиус для окружности. В оба класса добавьте метод 
    Нарисовать, в котором могла бы быть специфическая логика рисования фигуры. Создайте объекты треугольник и окружность.
     */

    class GeometryFigure
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GeometryFigure()
        {

        }
       
        public GeometryFigure(int x , int y)
        {
            X = x;
            Y = y;
        }

    }
    //Треугольник
    class Triangle : GeometryFigure
    { 
        public int Get_Square { get; set; }
        public string NameTriangle { get; set; }

        public Triangle()
        {

        }
        
        public Triangle(int x, int y , int getSquere) : base(x,y)
        {
            Get_Square = getSquere;
        }
        public void DrawingTriangle()
        {
            //Logic drawing triangle
        }
    }

    //Круг
    class Cirkle : GeometryFigure
    { 
        public int Get_Radius { get; set; }
        public string NameCirkle { get; set; }

        public Cirkle()
        {
            Get_Radius = 0;
            NameCirkle = "";
        }

        public Cirkle(int x, int y, int getRadius) : base(x,y)
        {
            Get_Radius = getRadius;
        }

        public void CirkleDrawing()
        {
            //Logic drawing cirkle
        }
    }
    //End task http://mycsharp.ru/post/28/2013_07_21_nasledovanie_v_si-sharp_konstruktor_bazovogo_klassa.html

    public class Task15
    {

        /*
        Дополните предыдущую практику.
        Напишите код, в котором:

        1. Создайте список (List) объектов типа
        «Геометрическая фигура».

        2. Добавьте в него несколько объектов,
        реализующих классы-наследники(«Окружность», «Треугольник»).

        3. Переберите список в цикле. Для каждого
        элемента определяйте принадлежность к классу-наследнику и выводите в консоль
        значение определённых в наследнике полей.
         */

        

        public static void ListClass()
        {
            List<GeometryFigure> FigureList = new List<GeometryFigure>();
            FigureList.Add(new Triangle());
            FigureList.Add(new Triangle());
            FigureList.Add(new Triangle());
            FigureList.Add(new Triangle());
            FigureList.Add(new Cirkle());
            FigureList.Add(new Cirkle());
            FigureList.Add(new Cirkle());
            FigureList.Add(new Cirkle());
            FigureList.Add(new Cirkle());

            for (int i = 0; i < FigureList.Count; i++)
            {
                int countTriangle = 1;
                int coutCirkle = 1;
                if (FigureList[i] is Triangle)
                {
                    countTriangle += i;
                    Console.WriteLine("Trangle входит в соста базового класса в {0} строке", countTriangle);
                }
                else
                {
                    coutCirkle += i;
                    Console.WriteLine("Cirkle входит в соста базового класса в {0} строке", coutCirkle);
                }
            }
        }


        /*
        Контрольные вопросы
        1. Как при объявлении класса указать что он является наследником какого-то конкретного родительского
        класса?
        пример: ChildrenClass : ParentsClass - через знак :(двоеточие).

        2. Будет ли объект класса-наследника обладать свойствами и методами объекта родительского класса?
        А наоборот?
        Да, с помощью примого приведение типов данных.
        Пример: 
        GeometryFigure geometryFigure = new Cirkle();
        Console.WriteLine(((Cirkle)geometryFigure).Get_Radius = 15);

        3. Можно ли унаследовать класс от нескольких родительских классов?
        Нет, C# не поддерживает множественное наследование.

        4. Может ли переменная с типом базового класса хранить ссылку на объект класса-наследника?
        Да. 
        Пример :GeometryFigure geometryFigure = new Cirkle();

        5. Как проверить, что в переменной находится объект нужного класса?
        с помощью ключевых слов is and as

        6. Что такое «восходящее преобразование»? «Нисходящее преобразование»? Как их выполнить? В каких
        случаях нужны такие преобразования?
        восходящее преобразование - Преобразование от класса наследника к родительскому классу или типу object.
        Нисходящее преобразование - Преобразование от родительского класса к классу наследнеку.

         */


    }

}
