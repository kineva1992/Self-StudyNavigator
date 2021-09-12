using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
    public class Gay
    {
        public string Name;
        public int? CountChildred;

        public Gay(string name, int? countChildred)
        {
            this.Name = name;
            this.CountChildred = countChildred;
        }

        public void GetChildre()
        {
            Console.WriteLine(this.CountChildred == null ? $"No data about {this.Name}'s children" : 
                (this.CountChildred == 0 ? $"{this.Name} has no children" : $"{this.Name} has {this.CountChildred} children"));
        }
    }
   
    class Task14
    {
        public static void CountChildren(string name, int? count)
        {
            if (count == null)
            {
                Console.WriteLine("{0} Неизвестное количесво детей", name);
            }
            else
            {
                Console.WriteLine("{0}: Количество детей - {1}", name, count);
            }
        }

        /*
        1. Что означает значение null? Эквивалентно ли оно арифметическому нулю?
        1)тип null обзачат что переменная не имеет значения.
        2) Нет, число 0 это конкретное значение, а тип null означает что переменная не имеет значения.

        2. Какой из вариантов объявления переменной Nullable-типа правильный?
        Nullable<int> age = 10;
        int? age = 10;
        Оба выражения эквивалетные.

        3. Как проверить переменную на null?
        с помощью оператора объединения со значение null "??"

        4. Опишите, как работает оператор «??». Для чего его можно использовать?
        Оператор принимает 2 переменных, одна из них должна иметь тип Nullable. 
        например: 
        int? a = null
        int b = 13
        a ?? b
        Если в левой части (a) выражения у типа Nullable значение null то возвращаеться значение из правой части выражения.

        5. Необходимо преобразовать переменную типа int? к типу int. Как сделать это безопасно?
        явное приобразование
        Пример 1:
        int? a = null;
        int b = (int)a;

        Пример 2:
        int? a = null;
        int b = a.Value;
         */
    }
}
