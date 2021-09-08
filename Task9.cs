using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
    class Person
    {
        public string name = "Ben";
        public int age = 18;
        public string email = "ben@gmail.com";

        public Person(string name)
        {
            this.name = name;
        }
        public Person(string name, int age) : this(name)
        {
            this.age = age;
        }
        public Person(string name, int age, string email) : this("Bob", age)
        {
            this.email = email;
        }
    }
    public class Car
    {
        public string Name;
        private string Motor;
        private int Year;
    }
    class Task9
    {

    }

    /*
    Контрольные вопросы
    1. Как определить класс на C#?
    с помощю ключевых слов [модификатор доступа] class [имя класса]
    {
    
    }
    2. В чем разница между классом и объектом?
    Класс - это обастрактный тип данных.
    Объект - экземпляр класса.
    3. Что такое поле класса?
    Поле - это переменная объявленная внутри класса.

    4. Для чего применяются «пространства имен» (namespaces)?
    В пространстве имен объявляется облатсь действия в которой доступен объект.

    5. Можно ли одном проекте создать два класса с одним именем?
    Нет, т.к будет конфликт между наименованием классов и мы сами же запутаемся в классах.
    6. Ответьте на вопросы со страницы https://metanit.com/sharp/questions/2.1.php
    7. Перечислите 5 модификаторов (уровней доступа) членов классов. Опишите эти модификаторы.
    public - доступен везде.
    private - доступен только в расках класса.
    protected - доступн в рамках класса и наследников класса.
    internal - доустпун в рамках сборки.
    protected-internal - доуступен классу наследнику одной из сборок.
     */
}
