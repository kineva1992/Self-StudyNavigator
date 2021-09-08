using System;
using System.Collections.Generic;
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
        int man = Math.Max(a, Math.Max(b,c));
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
            long int t1 = 0, t2 = 0, t;
            for(int i = 0; i < n; i++)
            {
                t = (t1 + t2) % 1000000000;
                t1 = t2;
                t2 = t;
            }
            return t2;
        }
    }
}
