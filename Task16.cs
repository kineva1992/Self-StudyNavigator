using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
    /// <summary>
    /// Создайте три класса: Воин, Воин_в_легких_доспехах и Воин_в_тяжелых_доспехах. 
    /// У всех них есть свойство – Количество_жизней, а также метод Получить_урон, 
    /// который принимает в качестве аргумента значение получаемого урона. Реализуйте этот метод по-разному для всех типов,
    /// установив различные коэффициенты в зависимости от типа доспехов в формуле вычета здоровья.
    /// </summary>
    class Warior
    {
        public string Name { get; set; }
        public double LifeCount { get; set; }

        public Warior(string name)
        {
            Name = name;
            LifeCount = 10000;
        }

        public virtual void GetDamage(double damage)
        {

            LifeCount = damage >= LifeCount ? 0 : LifeCount -= damage;
        }

    }
    //Воин в легких доспухах
    class WarriorInLightArmour : Warior
    {
        public WarriorInLightArmour(string name) : base(name)
        {

        }

        public override void GetDamage(double damage)
        {
            damage = Math.Round(damage * 0.85);
            base.GetDamage(damage);
        }

    }

    class WarriorInHeavyArmor : Warior
    {
        public WarriorInHeavyArmor(string name) : base(name)
        {

        }

        public override void GetDamage(double damage)
        {
            damage = Math.Round(damage * 0.7);
            base.GetDamage(damage);
        }
    }
    class Task16
    {
    }
    /// <summary>
    /// Создайте класс Employee (Сотрудник).
    /// Определите в нем:
    /// свойства ФИО, часовая ставка, сумма отработанных за месяц часов;
    /// метод для расчета суммы заработной платы (часы* ставка)
    /// Создайте класс Manager (Руководитель), наследуемый от Employee.
    /// Определите в нем свойство – коэффициент надбавки за выполнение ключевых показателей (KPI).
    /// Переопределите в нем метод для расчета заработной платы(часы* ставка * коэффициент * KPI).
    /// </summary>
   public class Employees
    { 
        public string FIO { get; set; }
        public double HourlyRate { get; set; }
        public double SumHourseOfMount { get; set; }

        public Employees()
        {
            FIO = "";
            HourlyRate = 0;
            SumHourseOfMount = 0;
        }
        public Employees(string fio, double hourlyRate, double sumHourseOfMount)
        {
            FIO = fio;
            HourlyRate = hourlyRate;
            SumHourseOfMount = sumHourseOfMount;
        }

        public virtual double GetSumOfTheMount(double hourlyRate, double sumHourseOfMount)
        {
            return hourlyRate * sumHourseOfMount;
        }
    }

    public class Manager : Employees
    {
        public double KPI { get; set; }
        public Manager()
        {
            FIO = "";
            HourlyRate = 0;
            SumHourseOfMount = 0;
        }

        public Manager(string fio, double hourlyRate, double sumHourseOfMount, double kpi) : base(fio, hourlyRate, sumHourseOfMount)
        {
            KPI = kpi;
            FIO = fio;
            HourlyRate = hourlyRate;
            SumHourseOfMount = sumHourseOfMount;
        }

        public double GetSumOfTheMount(double hourlyRate, double sumHourseOfMount, double kpi)
        {
            return base.GetSumOfTheMount(hourlyRate, sumHourseOfMount) * kpi;
        }

    }

    /*
     https://metanit.com/sharp/questions/2.11.php
     Вопрос 1
    Какое ключевое слово применяется для переопределения виртуальных методов и свойств: override.

    Вопрос 2
    Что будет выведено на консоль в результате выполнения следующей программы и почему: 
    Создаеться экземпляр класса Employee 
    хоть и инициализируеться класс родитель Person, с помощью него мы получаем доступ к классу Employee, задаем значения для свойств Name и Company
    После чего обращаемся к переопеределенному метоту Display() и вызывем его. После чего на консоль выводить надписть "Employee Sam".

    Вопрос 3
Что будет выведено на консоль в результате выполнения следующей программы и почему: Manager Bob.
    Мы создаем экземпляр класса Manager, у нас храниться на экземпляр класса Manager в переменной person, далее мы обращаемся к классу Employee,
    но ссылка на экземпляр класса Manager всё так же ссылаеться на класс Manager. По этому мы видим надпись "Manager Bob".

    Вопрос 4
Что будет выведено на консоль в результате выполнения следующей программы и почему: Ошибка компиляции, потому что переопределяей метод должен иметь тот же модификатор доступа что и родительский.

    Вопрос 5
Для чего нужен модификатор sealed? 
    Для запрета переопередения или запрета наследования. 

    Вопрос 6
Что будет выведено на консоль в результате выполнения следующей программы и почему? : не скомпилируеться потому что sealed запрещает переоперелять метод.

     */
}

