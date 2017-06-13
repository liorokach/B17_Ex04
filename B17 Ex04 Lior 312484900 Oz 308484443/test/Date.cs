using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Date : Interfaces.IMethod
     {
        public void RunMethod()
        {
               Console.WriteLine(string.Format("The date is: {0}", DateTime.Today.ToString("dd-MM-yyyy")));
          }
    }
}
