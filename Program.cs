﻿using System;
using System.Collections.Generic;

namespace Self_StudyNavigator
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Start Task3
            ////Task1
            //Console.WriteLine("Введите 2 целых числа");

            //int numberOne = int.Parse(Console.ReadLine());
            //int numberSecond = int.Parse(Console.ReadLine());

            //Task3.ReturnValue(numberOne, numberSecond);

            ////Task 2
            //Task3.SecondTask();
            ////End Task 3

            //Start Task 4
            //Task4.Task2(1, 2, 3, 4);
            //End Task 4

            //Start Task 5
            //Task5.PrintIsMultiple(2);

            //End Task 5

            // Start task 6 List

            //List<string> Seasons = new List<string> { "Spring", "Summer", "Autumn", "Winter" };
            //Console.WriteLine(Seasons[1]);

            //Seasons.Remove("Summer");
            //Seasons.IndexOf("Winter");
            //Console.WriteLine(Seasons.IndexOf("Summer"));
            //End task 6 

            //Start task8 

            //Task8 task8 = new Task8();
            //List<int> ListInts = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int maxValue;
            //int minValue;
            //task8.MaxAndMinValue(ListInts,out maxValue,out minValue);
            //Console.WriteLine(maxValue);
            //Console.WriteLine(minValue);

            //End task8 
            //Start task9
            //Car car = new Car();
            //car.Name = "Honda";
            //Console.WriteLine(car.Name);
            //End task9

            //Start task11
            Notification notification = new Notification("them",2);
            //End task11

            //Start task13
            //State state1 = new State(); // Структура State
            //State state2 = new State();
            //state2.x = 1;
            //state2.y = 2;
            //state1 = state2;
            //state2.x = 5; // state1.x=1 по-прежнему
            //Console.WriteLine(state1.x); // 1
            //Console.WriteLine(state2.x); // 5

            //Country country1 = new Country(); // Класс Country
            //Country country2 = new Country();
            //country2.x = 1;
            //country2.y = 4;
            //country1 = country2;
            //country2.x = 7; // теперь и country1.x = 7, так как обе ссылки и country1 и country2 
            //                // указывают на один объект в хипе
            //Console.WriteLine(country1.x); // 7
            //Console.WriteLine(country2.x); // 7

            //State state1 = new State();
            //State state2 = new State();

            //state2.country = new Country();
            //state2.country.x = 5;
            //state1 = state2;
            //state2.country.x = 8; // теперь и state1.country.x=8, так как state1.country и state2.country
            //                      // указывают на один объект в хипе
            //Console.WriteLine(state1.country.x); // 8
            //Console.WriteLine(state2.country.x); // 8


            //Edn task13

        }

        static void ChangePerson(Persons persons)
        {
            //Сработает
            persons.Name = "Alice";
            //Сработает только в рамках данного метода.
            persons = new Persons {Name = "Bill", Age = 45 };
            Console.WriteLine(persons.Name); // Bill
        }
    }
}
