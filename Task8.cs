using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Self_StudyNavigator
{
    class Task8
    {
        /*
        Задача 1. Напишите функцию, которая будет менять в массиве целых чисел все элементы, которые равны указанному значению (аргумент) на противоположное значение по знаку. 
        Например, все элементы массива которые равны 5, будут меняться на -5.
        */
        public static int Sign(int ar, int arg = 5)
        {
            int arr;
            if(ar == arg)
            {
                arr = ar * -1;
                return arr;
            }
            else
                return ar;
        }
        //Задача 2. Напишите функцию, которая будет находить минимальное число из трех.
        public int ReturnMedian(int a, int b, int c)
        {
        int max = Math.Max(a, Math.Max(b,c));
        int min = Math.Min(a, Math.Min(b,c));
           return a + b + c - min - max;
        }
        /*
        Задача 3. Напишите функцию, которая будет возвращать указанный элемент ряда Фибоначчи. 
        Ряд Фибоначчи – это ряд, в котором каждый следующий элемент равен сумме двух предыдущих.
        1 1 2 3 5 8 13 21… Функция принимает порядковый номер элемента,
        и возвращает соответствующий элемент.
        */
        public static int Fib(int n)
        {
            if(n == 0) return 0;
            int t1 = 0, t2 = 0, t;
            for(int i = 0; i < n; i++)
            {
                t = (t1 + t2) % 1000000000;
                t1 = t2;
                t2 = t;
            }
            return t2;
        }

        /*
        Напишите метод, который будет принимать List,содержащий целые числа и возвращать
        минимальное и максимальные числа из
        преданного списка через два параметра с
        модификатором out.
        */

        List<int> ListInts = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public void MaxAndMinValue(List<int> inputList, out int maxValue, out int minValue)
        {
           maxValue = inputList.Max(point => ((int)point));
           minValue = inputList.Min(point => ((int)point));
        }

        /*
        Контрольные вопросы
        1. Можно ли объявить новый метод внутри метода Main?
        Нет, т.к Main является методом.

        2. Что обозначает ключевое слово void при объявлении метода?
        Метод ничего не возвращает.

        3. Можно ли объявить метод без параметров?
        Да. Например с модификатором void.

        4. Можно ли при объявлении метода указать параметры, но не указывать их тип?
        Да, если объявиь их в виде глобальных переменных.

        5. Для чего используется оператор return? Можно ли в теле метода использовать несколько операторов
        return?
        1)Оператор return используеться для того что бы вернуть что либо их метода.
        2)Можно, но при этом необходимо использовать логические инструкции if-esle, switch-case
         */
    }
}
