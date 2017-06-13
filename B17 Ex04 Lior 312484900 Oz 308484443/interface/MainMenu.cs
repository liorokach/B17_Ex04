using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
     public abstract class MainMenu
     {
          private string m_title;
          public string m_backButton = "Exit";
          private MenuItem m_backMenu;

          public abstract void OnSelected();

          public abstract void Show();

          public virtual void Add(MainMenu item)
          {
          }

          public MenuItem Back
          {
               get
               {
                    return m_backMenu;
               }

               set
               {
                    m_backMenu = value;
               }
          }

          public string Title
          {
               get
               {
                    return m_title;
               }

               set
               {
                    m_title = value;
               }
          }
     }
}
