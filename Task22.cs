using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
    class Task22
    {
    }
    /*
    Контрольные вопросы
    1. Входной параметр метода имеет тип IEnumerable. Можно ли при вызове метода указать в качестве
    параметра массив (Array)?
    Да, пример ниже 
    public void ExeptionTask(int inputOne, int inputTwo, IEnumerable ts ){}
    int[] arrayExeptionTask = new int[10] { 5, 88, 1, 12, 4557, 14, 741, 46, 985, 8 };
    task21.ExeptionTask(1,2, arrayExeptionTask);

    2. Можно ли перебирать элементы коллекции IQueryable в цикле foreach?
    Да.
    3. В чем разница между коллекциями IEnumerable и IQueryable в части выборки отфильтрованных
    данных.
    IQueryable быстрее работает с колекцией в части отфильтрованных данных чем IEnumerable.

     */
}
