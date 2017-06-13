using System;

namespace Ex04.Menus.Test
{
     public class Time : Interfaces.IMethod
     {
          public void RunMethod()
          {
               Console.WriteLine(string.Format("The time is: {0}", DateTime.Now.ToString("h:mm:ss tt")));
          }
     }
}
