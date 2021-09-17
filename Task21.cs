using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
    class Task21
    {
        public void ExeptionTask(int inputOne, int inputTwo, IEnumerable ts )
        {
            int[] arrayExeptionTask = new int[10] { 5, 88, 1, 12, 4557, 14, 741, 46, 985, 8 };

            try
            {
                Console.WriteLine("Введите первый номер элемента массива от 1-го до 10-и и нажмите ENTER:");
                int first = arrayExeptionTask[inputOne - 1];
                Console.WriteLine("Введите второй номер элемента массива от 1-го до 10-и и нажмите ENTER:");
                int second = arrayExeptionTask[inputTwo - 1];
                Console.WriteLine("Сумма заданных элементов равна " + (first + second) + ".");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка. Введённый номер не является числом.");
                Console.ReadKey();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка. Введённый номер находится вне границ коллекции (1-10).");
                Console.ReadKey();
            }
        }
    }

    /*
    1. Что такое «Обработка исключений»? Приведите примеры исключений.
    Это писание реакции программы на ту или иную ошибку.

    2. Для чего используется блок finally в операторе try-catch?
    Блок finally используетья для того что бы выполнить какой-то обязательный код например закрытие подключеия к базе данных.

    3. В каком случае может потребоваться генерация собственных исключений?
    Если не один из типов исключений не подходит под наши нужды.

     */
}
