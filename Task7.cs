using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
    class Task7
    {
       //Задача 1. Вывести на экран 20 элементов последовательности 1, 4, 7, 10, 13…
        
        public static void PlusThreeCycle(int start)
        {
            int[] M = new int[20];
            M[0] = 1;

            for (int i = 0; i < M.Length; i++)
            {
                if (i == 19)
                {
                    Console.WriteLine(M[i]);
                    break;
                }
                M[i + 1] = M[i] + 3;
                Console.WriteLine(M[i]);
            } 
        }
        
       // Задача 2. Напишите программу, которая будет «спрашивать» правильный пароль, до тех пор, пока он не будет введен. Правильный пароль пусть будет «root».
            
        public static void PrintRoot(string inputName)
        {
           do
            {
               if(inputName == "root")
               {
                   Console.WriteLine("Верынй пароль");
                   break;
               }
               else
                Console.WriteLine("Не верный пароль");
            }
            while(inputName == "root");
        }
        
        //Задача 3. Дано два массива одинаковой длины (по 10 элементов). 
        //Создайте третий массив, который будет отображать сумму первых двух массивов. Первый элемент третьего массива равен сумме первых элементов двух первых массивов и так далее.
        
        int[] arr1 = new int[10];
        int[] arr2 = new int[10];
        
        public void ReturnThreeArray()
        {
                int[] arr3 = new int[10];
            for(int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = i + 10;
                arr2[i] = i + 5;
                arr3[i] = arr1[i] + arr2[i];
                    Console.WriteLine(arr3[i]);
            }
        }
        
        /*Создайте одномерный массив, содержащий
        наименования 7 дней недели. Переберите созданный
        массив с помощью цикла for, выводя значения элементов
        в консоль.*/
        string[] daysOfTheWeek = new string[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
        public void PrintDaysOfTheWeek()
        {
            string[] daysOfTheWeek = new string[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
            foreach(var days in daysOfTheWeek)
            {
            Console.WriteLine(days);
            }
        }
        
         public void PrintDaysOfTheWeek2()
        {
            string[] daysOfTheWeek = new string[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
            for (int i = 0; i < daysOfTheWeek.Length; i++)
            {
                if (i % 2 == 0) 
                { 
                    Console.WriteLine(daysOfTheWeek[i]);
                    continue;
                }
            }
        }

        /*
        Дан массив:
        int[] numbers = {-4, 3, 2, -1, 0, 1, 2, 3, 4
        };
        Напишите код, в котором:
        1. Получите длину массива используя свойство Length.
        2. Переберите массив с использованием цикла while до
        нахождения элемента со значением 0. Дальнейший
        перебор прервите используя оператор break.
        3. Все положительные числа, найденные в ходе
        перебора, выводите в консоль.
         */

        public void PrintNumbers()
        {
            int[] numbers = {-4, 3, 2, -1, 0, 1, 2, 3, 4};
            int count = 0;

            while (count < numbers.Length)
            {
                if (numbers[count] == 0 || numbers[count] >= 0)
                { 
                    Console.WriteLine(numbers[count]);
                }
                count++;
            }
        }

        public void PrintDaysOfWeakForeachTask()
        {
            string[] daysOfTheWeek = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            foreach (var item in daysOfTheWeek)
            {
                if (item == "Среда")
                {
                    break;
                }
                Console.WriteLine(item);

            }
        }

        /*
        Контрольные вопросы
        1. В чем отличие циклов for и foreach?
        foreach - необходим что бы перебрать элементы списка, массива, реализованными интерфейсом IEnumerable 
        For - необходим если можно обратиться по индексу элемента.

        2. Сколько раз выполнится цикл:
        int i = 0;
        while (i < 5)
        {
        Console.WriteLine(i);
        }
        Бесконечное количество раз, потому что отсутсвуте инкримет
        3. Опишите назначение операторов break, continue. Приведите примеры использования каждого
        оператора.
        break - прирывает цикл если условие верно.
        continue - завершает итерацию цикла позволяя перейти к слудующей.
         */
    }
}
