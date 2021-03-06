using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Self_StudyNavigator
{
    // Упражнение 1
    //Что неправильно в следующем коде? Исправьте его:
    /*
     class Instantiator<T>
{
    public T instance;
    public Instantiator()
    {
        instance = new T();
    }
}
     */

    class Instantiator<T>
    {
        public T instance;
        public Instantiator()
        {
            instance = default(T);
        }
    }

    /*
     Упражнение 2
    Напишите обобщенный класс, который может хранить в массиве объекты любого типа. 
    Кроме того, данный класс должен иметь методы для добавления данных в массив, удаления из массива, получения элемента из массива 
    по индексу и метод, возвращающий длину массива.
    Для упрощения работы можно пересоздавать массив при каждой операции добавления и удаления
     */

    class Collection<T>
    {
        T[] data;

        //Добавлене данных
        public void Add(T item)
        {
            T[] newData = new T[data.Length + 1];
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }

            newData[data.Length] = item;
            data = newData;

        }
        public void Remove(T item)
        {
            //Находим элемент по индексу;
            int index = -1;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            //Удаляем элемент по индексу
            if (index > -1)
            {
                T[] newData = new T[data.Length - 1];
                for (int i = 0, j = 0; i < data.Length + 1; i++)
                {
                    if (i == index) continue;
                    newData[j] = data[i];
                    j++;
                }
                data = newData;
            }
        }

        //Получаем элемент массива
        public T GetData(int index)
        {
            if (index > -1 && index < data.Length)
            {
                return data[index];
            }
            else throw new IndexOutOfRangeException();
        }
        //Возвращаем длину массива
        public int Count()
        {
            return data.Length;
        }
    }

    /*
     https://metanit.com/sharp/questions/2.19.php

    Вопрос 1
    Что будет выведено на консоль в результате выполнения следующей программы и почему?
    Мы не может присвоить значение ананимным типам, т.к они доступны только для чтения.

    Вопрос 2
    Анонимные типы представляют значимый или ссылочный тип?
    Анонимные типы предсталяютсья как ссылочный тип.

    Вопрос 3
    Скомпилируется ли следующая программа? Если скомпилируется, то что будет выведено на консоль? Если не скомпилируется, то почему?
    Скомпилируться и выведиться на консоль слово Ford, потому что мы ссылаемся в переменной student на student.Name а в нём храниться ссылка на слово Fodr.

     */
     

    
    class Task18
    {
            
    }
    
}
