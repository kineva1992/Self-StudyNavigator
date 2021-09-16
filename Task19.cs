﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Self_StudyNavigator
{

    /*
     Домашнее задание

Задача 1. Есть некий текст. Необходимо заменить в этом тексте все слова "Nikolay" на "Oleg".

Задача 2. Дан текст – «Сегодня мы с вами рассмотрели, как работать со строками в Си-шарп. 
Были описаны основные операторы и методы, которые используются для работы со строками». 
Обрежьте этот текст так, чтобы осталась только часть «Были описаны основные операторы и методы».

Задача 3. Дана строка, которая содержит имена пользователей, разделенные запятой – "Login1,LOgin2,login3,loGin4". Необходимо разбить эту строку на массив строк (чтобы отдельно были логины), и перевести их все в нижний регистр.
     */
    class Task19
    {
        public string ReturnNameOleg(string name)
        {
            return name.Replace("Nikolay", "Oleg");
        }

        public void RetrunTextTask2()
        {
            string str = "Сегодня мы с вами рассмотрели, как работать со строками в Си-шарп. Были описаны основные операторы и методы, которые используются для работы со строками». " +
                    "Обрежьте этот текст так, чтобы осталась только часть «Были описаны основные операторы и методы";

            str = str.Remove(0, str.IndexOf("Были"));
            Console.WriteLine(str.Remove(str.IndexOf(", которые")));

        }

        public void ReturnTextTask3()
        {
            string str = "Login1,LOgin2,login3,loGin4";

            string[] arrayString = str.Split(",");

            foreach (string item in arrayString)
            {
                Console.Write(str.ToLower() + ",");
            }
        }

        /*
            Напишите код, в котором:
            Сформируйте и выведите в консоль сообщение о
            сдаче аттестации: «Слушатель <ФИО> сдал
            аттестацию на <N> баллов».
            ФИО слушателя задайте в строковой переменной,
            результат аттестации в переменной типа double.
            Итоговое сообщение сформируйте с помощью
            метода String.Format, аттестационный балл при
            этом округлите до одного знака после запятой.
            */
        public static void ResultBall(string name, double resultBall)
        {
            string resultBallToString = String.Format("{0:f4}", resultBall);
            Console.WriteLine("Слушатель {0} сдал экзамен аттестацию на {1} баллов", name, resultBallToString);
        }
        /*Напишите код, в котором:
        1. Запросите пользователя ввести текст сообщения
        2. Сформируйте тему сообщения, которая должны
        содержать слово «Тема: » и первые 30 символов
        из текста.
        Учтите, что введенный пользователем текст
        сообщения может быть менее 30 символов
        3. Выведите тему в консоль.*/
        public static void ThemMessage(string them)
        {
            if (them.Length > 30)
            {
                Console.WriteLine(them.Substring(0, 30));
            }

            else
                Console.WriteLine(them.Substring(0, 30));
        }
        /*Напишите код, которые будет удалять лишние
        (двойные, тройные и т.п.) пробелы между словами
        в строке, запрашиваемой у пользователя.
        Результат выводите в консоль. Пример строки:
        «Этот текст содержит лишние пробелы».*/
        public void TrimSpaceWitchText(string textWitchSpace)
        {
            textWitchSpace = Regex.Replace(textWitchSpace, @"\s+", " ");
            Console.WriteLine(textWitchSpace);
        }

        //Напишите код, который будет находить и выводить консоль предпоследнее слово в строке
        public void ViewLastElementSting(string inputText)
        {
            string[] text1 = inputText.Split(' ');
            string lastElement = text1[text1.Length - 1];
            Console.WriteLine(lastElement);
        }

    }
}
