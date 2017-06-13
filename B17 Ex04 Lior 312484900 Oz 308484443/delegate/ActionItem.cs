
using System;

namespace Ex04.Menus.Delegates
{
     public delegate void selectedEvent();

     public class ActionItem : MainMenu
     {
          public event selectedEvent HasSelected;

          public ActionItem(string i_Name)
          {
               Title = i_Name;
          }

          public override void OnSelected()
          {
               if (HasSelected != null)
               {
                    HasSelected.Invoke();
               }
          }

          public override void Show()
          {
               throw new NotImplementedException();
          }
     }
}
