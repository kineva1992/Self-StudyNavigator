
using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
   class Task6
    {
        
        string[] daysOfTheWeek = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        
        
        /* Напишите код, в котором:
        1. Создайте одномерный массив, содержащий
        наименования дней недели.
        2. Выведите в консоль значение 5 элемента и длину
        массива.*/
        
        //Start task array
        
        public void ReturnFiveElementsDaysOfTheWeekArray()
        {
        Console.WriteLine(daysOfTheWeek[4]);
        }
        
        public void ReturnLengthArrayDaysOfTheWeekArray()
        {
        Console.WriteLine(daysOfTheWeek.Length);
        }
        //End task Array

    }

    class Programs
    {
        static void Mains(string[] args)
        {
            //Инициализация дженерик метода List
            List<string> Seasons = new List<string> { "Spring", "Summer", "Autumn", "Winter" };
            //Вывод на консоль второго метода т.к счёт начинается с нуля.
            Console.WriteLine(Seasons[1]);
            //Удаление элемента Summer
            Seasons.Remove("Summer");
            //Проверка на существование элемента Winter
            Seasons.IndexOf("Winter");
            //Проверка на наличение элемента Summer: -1 элемент отсутствует
            Console.WriteLine(Seasons.IndexOf("Summer"));

        }
    }

    /*
    Контрольные вопросы
    1. Как при объявлении массива сразу заполнить его нужными значениями?
    В фигурных скобках в конце пример string[] nameArray = new string[] {"abc", "cba", "qwerty"};
    2. Какая размерность у объявленного ниже массива?
    int[,] somearray = new int[3, 4];

    Масив являет многомерным, если быть точнее двумерным, вместительностью 3 и 4 элемета соответственно
    3. Вернёт ли такой код ошибку?
    int[] numbers = new int[5];
    numbers[5] = 5;
    Да, т.к указан инденкс массива выходящий за его рамки.
    4. Как создать список List?
    1)Подключить пространсво имен: using System.Collections.Generic;
    2) Объявить его List<T> nameList = new List<T>();
    5. Как обратиться к элементу списка зная индекс элемента? Можно ли записать в этот элемент списка
    новое значение?
    Пример: 
    1)List<string> Seasons = new List<string> { "Spring", "Summer", "Autumn", "Winter" };
    Seasons[1];
    2)Да, с помощью метода Insert(index, value);
    6. Чем отличаются методы Add и Insert при работе со списками?
    Add - Добавляет в конец списка
    Inser - вставляет на указанное место
     */
}
