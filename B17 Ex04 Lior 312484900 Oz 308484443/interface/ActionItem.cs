using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Interfaces
{
    public interface IMethod
    {
        void RunMethod();
    }
    
    public class ActionItem : MainMenu
    {
        public IMethod m_method;

        public ActionItem(string i_Title, IMethod i_Method)
        {
            Title = i_Title;
            m_method = i_Method;
        }

        public override void OnSelected()
        {
            m_method.RunMethod();
        }

          public override void Show()
          {
               throw new NotImplementedException();
          }
     }
}
