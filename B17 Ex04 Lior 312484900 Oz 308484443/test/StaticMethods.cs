using System;
using System.Collections.Generic;

namespace StaticMethods
{
     using Ex04.Menus.Delegates;

     public static class StaticMethods
     {
          public static void DisplayVersion()
          {
               Console.WriteLine("App version 17.2.4.0");
          }

          public static void CountSpaces()
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

          public static void CountChars()
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

          public static void ShowTime()
          {
               Console.WriteLine(string.Format("The time is: {0}", DateTime.Now.ToString("h:mm:ss tt")));
          }

          public static void ShowDate()
          {
               Console.WriteLine(string.Format("The date is: {0}", DateTime.Today.ToString("dd-MM-yyyy")));
          }

          public static List<MainMenu> CreateNewList(MainMenu i_Menu1, MainMenu i_Menu2)
          {
               List<MainMenu> i_MenuItem = new List<MainMenu>();
               i_MenuItem.Add(i_Menu1);
               i_MenuItem.Add(i_Menu2);
               return i_MenuItem;
          }
     }
}
