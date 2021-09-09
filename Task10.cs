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

public int Previous()
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
    
    List<string> firstName = List<string>{"Андрей","Коля","Дима"};
    
    public void PrintList(List<string> listName)
    {
      for(int i = 0; i < listName.Length; i++)
      {
        Console.WriteLine(listName[i]);
      }
    }
    
    public void PrintList(List<string> listName, char symbol)
    {
      for(int i = 0 ; i < listName.Length; i++)
      {
        Console.WriteLine(listName[i] + symbol);
      }
    }
  }
  class Task10
  {
    
  
    
    
    
  }
}
