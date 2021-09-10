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
        private string Note = "";
        private int Priority = 1;

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

  }
}
