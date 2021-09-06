using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
   static class Task5
    {
        /*
         1) С клавиатуры вводятся два числа – количество забитых голов хозяевами и гостями в футбольном матче. 
        Вывести на экран результат игры – победили хозяева/гости/ничья.
         */
        public static void PrintResultGameSoccer(string userName, int goalToHome, int goalToGosni)
        {
            //Приветствие пользователя
            Console.WriteLine("Hello {0}", userName);

            if (goalToGosni < goalToHome)
                Console.WriteLine("Победили хозяева");
            else if (goalToGosni == goalToHome)
                Console.WriteLine("Ничья");
            else
                Console.WriteLine("Победили гости");
        }

        //2) Напишите программу, которая будет проверять число на кратность 3-м и 7-ми (это числа 21, 42, 63…). Вывести на экран соответствующее сообщение.

        private static bool IsMultiple(int inputNumber)
        {
            return inputNumber % 3 == 0 && inputNumber % 7 == 0;
        }

        public static void PrintIsMultiple(int inputPumberMultiple)
        {
           var whoIsBool =  IsMultiple(inputPumberMultiple);

            if (whoIsBool == true)
                Console.WriteLine("Кратно 3 и 7!");
            else
                Console.WriteLine("Не кратно");
        }
        /*
        1. Что должно находиться внутри круглых скобок выражения if?
        Логическое условие.
        2. Сократите код используя тернарный оператор:
        if (a)
        {
        return 25;
        }
        else
        return 0;

        a ? 25 : 0

        3. От каких фигурных скобок в примере ниже можно отказаться? Почему?
        if (a)
        {
        b++;
        return 25;
        }
        else
        {
        return 0;
        }

        От скобок else потому что в блоке выполнения логики else идёт только возвращение значения 0. Если после логического уловмия идёт более 
        1-й строки кода, необходимо использовать фигурные скорбки, потому что учитывается только первая строка. 
        4. Для чего применяется слово default в выражении switch?
        Если не одно из условий не удовлетворяет выражению.
         */

    }
}
