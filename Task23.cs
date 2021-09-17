using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Self_StudyNavigator.Program;

namespace Self_StudyNavigator
{
    class Task23
    {
        public void Task1()
        {

            List<string> cities = new List<string>()
            {"Москва", "Саратов", "Кострома",
            "Сургут", "Иркутск", "Сочи" };

            var selectedCities = cities.Take(3);

            foreach (string s in selectedCities)
                Console.WriteLine(s);
        }
        
        public void Task2()
        {
            
            List<User> users = new List<User>
            {
                new User {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
                new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            var selectedUsers = users.Where(u => u.Age > 23 && u.Name.Length > 3).OrderBy(o => o.Name);

            var selectedUsers1 = from user in users
                                 where user.Age > 23
                                 where user.Name.Length > 3
                                 orderby user.Name
                                 select user;

            foreach (User item in selectedUsers)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }

        public void Task3()
        {
            List<User> users = new List<User>
            {
                new User {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
                new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            var selectedUsers = users.Where(u => u.Age > 23 && u.Name.Length > 3).Select(n => n.Name).ToList();

            var selectedUsers1 = from user in users
                                 where user.Age > 23
                                 where user.Name.Length > 3
                                 orderby user.Name
                                 select user;

            foreach (var item in selectedUsers)
            {
                Console.WriteLine($"{item}");
            }
        }
        /*
        1. Что такое LINQ?
        язык запросов для предостовления данных из разных источников

        2. Равнозначны ли конструкции, приведенные ниже?
        // Конструкция 1
        var selectedStudents = from student in students
        where student.Age > 20
        select student;
        // Конструкция 2
        var selectedStudents = students.Where(x => x.Age > 20)
        Да, конструкции эквивалентны.

        3. Дан код:
        int[] numbers = { 11, 2, 3, 4, 10, 34, 25};
        IEnumerable<int> evens = numbers.Where(i => i % 2 == 0 && i < 22);
        Попадут ли нечетные числа?
        Попадут ли в итоговую выборку числа: 10, 34?

        Попадет только числа 2,4,10 потому что 34 не соответсвует правой части условия i < 22.
         */
    }
}
