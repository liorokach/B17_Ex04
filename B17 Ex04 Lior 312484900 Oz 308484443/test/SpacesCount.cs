using System;

namespace Ex04.Menus.Test
{
    public class SpacesCounting : Interfaces.IMethod
    {
        public void RunMethod()
          {
               int count = 0;
               Console.WriteLine("Please enter a sentence:");
               string str = Console.ReadLine();
               foreach (char ch in str)
               {
                    if (ch == ' ')
                    {
                         count++;
                    }
               }
               Console.WriteLine("Number of spaces in your string is: {0}", count.ToString());
          }
    }
}
