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
  class Task10
  {
  
  }
}
