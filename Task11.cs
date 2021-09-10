using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
  public class Student
  {
        private string Name;
        private int Cours;
        private bool Cholarship;

        public Student(string name, int cours)
        {
            this.Name = name;
            this.Cours = cours;
        }

        public Student(string name, int cours, bool cholarship)
        {
            this.Name = name;
            this.Cours = cours;
            this.Cholarship = cholarship;
        }
  }


    public class Notification
    {
        private string Theme;
        private string Note = " ";
        private int Priority = 1;

        public Notification()
        {
            Theme = " ";
            Note = " ";
            Priority = 1;
        }

        public Notification(string theme, int priority)
        {
            this.Theme = theme;
            this.Priority = priority;
        }

        public Notification(string theme, string note, int priority)
        {
            this.Theme = theme;
            this.Note = note;
            this.Priority = priority;
        }

       
 
    }
  class Task11
  {
        /*
         Контрольные вопросы
        1. Для чего используются конструкторы в C#?
        Для задания первоначальных значений переменных экземпляра.

        2. Можно ли не объявлять в классе конструктор?
        Да, в данном случае будет вызываться не явно созданный конструктор.

        3. В каком случае может потребоваться объявление нескольких конструкторов?
        В случае если необходимо использование только опереденного количесвта полей класса.

        4. Как внутри метода обратиться к объекту, для которого он был вызван?
        С помощью ключевого слова this

        5. Почему ключевое слово this нельзя использовать в статических методах?
        Потому что статические методы существуют только на уровни класса и не связанны с экземпляроми класса.
         */
    }
}
