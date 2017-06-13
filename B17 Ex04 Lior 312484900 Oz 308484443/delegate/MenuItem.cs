using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
     public class MenuItem : MainMenu
     {
          private List<MainMenu> m_SubMenuItems = new List<MainMenu>();

          public MenuItem(string i_Name, List<MainMenu> i_ListOfItems)
          {
               Title = i_Name;
               m_backButton = "Back";
               m_SubMenuItems = i_ListOfItems;
               foreach (MainMenu item in m_SubMenuItems)
               {
                    item.Back = this;
               }
          }

          public override void OnSelected()
          {
               Show();
          }

          public override void Show()
          {
               int count = 0;
               Console.Clear();
               Console.WriteLine(Title);
               Console.WriteLine("===============");
               Console.WriteLine("Choose one of the following:");
               Console.WriteLine("0. {0}", m_backButton);
               foreach (MainMenu item in m_SubMenuItems)
               {
                    count++;
                    Console.WriteLine("{0}. {1}", count, item.Title);
               }

               string keyStr = Console.ReadLine();
               int keyInt;
               bool isNumber = int.TryParse(keyStr, out keyInt);
               if (!isNumber)
               {
                    throw new FormatException("Invalid! please enter a number");
               }

               if (keyInt == 0)
               {
                    if (Back != null)
                    {
                         Back.OnSelected();
                    }
               }
               else if (keyInt < 0 || keyInt > count)
               {
                    Console.WriteLine("Invalid selection");
               }
               else
               {
                    Console.Clear();
                    m_SubMenuItems[keyInt - 1].OnSelected();
               }
          }

          public override void Add(MainMenu i_item)
          {
               m_SubMenuItems.Add(i_item);
          }
     }
}
