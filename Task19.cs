using System;
using System.Collections.Generic;
using System.Text;

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


    }
}
