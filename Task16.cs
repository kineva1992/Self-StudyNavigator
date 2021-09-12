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
    class Employees
}
