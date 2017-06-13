using System;

namespace Ex04.Menus.Test
{
    public class LettersCounting : Interfaces.IMethod
    {
          public void RunMethod()
          {
               int count = 0;
               Console.WriteLine("Please enter a sentence:");
               string str = Console.ReadLine();
               foreach (char ch in str)
               {
                    if ((ch >= 'A' && ch <= 'z'))
                    {
                         count++;
                    }
               }
               Console.WriteLine("Number of chars in your string is: {0}", count.ToString());
          }
    }
}
