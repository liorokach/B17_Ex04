using System;
using System.Collections.Generic;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
     using StaticMethods;
     public class DelegateTest
     {
          public static void Run()
          {
               ActionItem time = new ActionItem("Show Time");
               time.HasSelected += new selectedEvent(StaticMethods.ShowTime);
               ActionItem date = new ActionItem("Show Date");
               date.HasSelected += new selectedEvent(StaticMethods.ShowDate);
               ActionItem version = new ActionItem("Display Version");
               version.HasSelected += new selectedEvent(StaticMethods.DisplayVersion);
               ActionItem spaces = new ActionItem("Count Spaces");
               spaces.HasSelected += new selectedEvent(StaticMethods.CountSpaces);
               ActionItem chars = new ActionItem("Chars Count");
               chars.HasSelected += new selectedEvent(StaticMethods.CountChars);
               List<MainMenu> LastSubList = StaticMethods.CreateNewList(time, date);
               MenuItem LastSub = new MenuItem("Show date/Time", LastSubList);
               List<MainMenu> LastRightSubList = StaticMethods.CreateNewList(spaces, chars);
               MenuItem ActionItem = new MenuItem("Actions", LastRightSubList);
               List<MainMenu> middleFirsSubList = StaticMethods.CreateNewList(version, ActionItem);
               MenuItem FirstItem = new MenuItem("Version And Action", middleFirsSubList);
               List<MainMenu> firstSubList = StaticMethods.CreateNewList(FirstItem, LastSub);
               MenuItem MainMenu = new MenuItem("Main Menu", firstSubList);
               MainMenu.m_backButton = "Exit";
               MainMenu.OnSelected();
          }
     }
}
