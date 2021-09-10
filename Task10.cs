using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
public class TV
{
private static int ThatChannel = 0;
private bool Switch;

public bool TvOn()
{
  return Switch = true;
}

public bool TvOff()
{
  Console.WriteLine("Thank you for watching. Goodbye.");
  return Switch = false;
}
public int NextClanel()
{
  ThatChannel++;
  Console.WriteLine("Your channel is : " + ThatChannel);
  return ThatChannel;
}

public void Previous()
{
  ThatChannel--;
  if(ThatChannel >= 0)
  {
    Console.WriteLine("Your channel is : " + ThatChannel);
  }
else
  {
    ThatChannel = 99;
    Console.WriteLine("Your channel is : " + ThatChannel);
  }
}
 public int YourChannel()
        {
            ThatChannel = Int32.Parse(Console.ReadLine());
            if (ThatChannel > 0 && ThatChannel < 100)
            {
                Console.WriteLine("Your channel is : " + ThatChannel);
            }
            else
                Console.WriteLine("Incorrect number. Please try again...");
            return ThatChannel;
        }

  

}
  public class OverideFirstName
  {
    /*
    Домашнее задание
    Имеется список имен. Создайте метод, который будет выводить на экран эти имена через запятую. 
    Перегрузите этот метод так, чтобы можно было изменять разделитель – вместо запятых между именами любой символ, переданный параметром.
    */
    
    List<string> firstName = new List<string> {"Андрей","Коля", "Дима"};
    
    public void PrintList(List<string> listName)
    {
      for(int i = 0; i < listName.Count; i++)
      {
        Console.WriteLine(listName[i]);
      }
    }
    
    public void PrintList(List<string> listName, char symbol)
    {
      for(int i = 0 ; i < listName.Count; i++)
      {
        Console.WriteLine(listName[i] + symbol);
      }
    }
  }
  class Task10
  {
    /*
    Контрольные вопросы
    1. Какие особенности есть у статических методов? Чем они отличаются от простых методов?
    1)Статический метод не имеет доступа к не статическим полям класса 
    2)Метод можно обявить без инициализации класса, просто обратившить к классу и методу например SomeClass.SomeStaticMethod();
    3)Статические методы обычно обрабатывают какую-то глобальную функцию, не статические методы обычно выполняют работу-вычисления внутри класса.
    
    2. Можно ли обратиться к свойству класса без создания экземпляра?
    Да.Если он являеться статическим.
    3. Для чего применяют перегрузку методов?
    Для универсализации метода, например нам необходимо иметь много метод с разным кол-вом входных параметров и разной логикой работы, но одинаковым выходным типом данных.
    4. Чем могут (должны) отличаться перегруженные методы?
    Только количесвом и типом данных входных параметров.
    5. Могут ли перегруженные методы иметь различные типы возвращаемых значений?
    Нет.
    */
  
    
    
    
  }
}
