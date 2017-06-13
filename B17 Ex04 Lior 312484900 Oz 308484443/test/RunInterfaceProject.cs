using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
     using StaticMethods;
    public class RunInterfaceProject
    {
        public static void Run()
        {
            Date i_Date = new Date();
            ActionItem i_CmpDate = new ActionItem("Show Date", i_Date);
            Time i_Time = new Time();
            ActionItem i_ShowTime = new ActionItem("Show Time", i_Time);
            List<MainMenu> i_LastSubList = CreateNewList(i_ShowTime, i_CmpDate);
            MenuItem i_LastSub = new MenuItem("Show date/Time", i_LastSubList);

            SpacesCounting i_CmpCountSpaces = new SpacesCounting();
            LettersCounting i_CmpCountChars = new LettersCounting();
            ActionItem i_CountSpaces = new ActionItem("Count Spaces", i_CmpCountSpaces);
            ActionItem i_CountLetters = new ActionItem("Chars Count", i_CmpCountChars);
            List<MainMenu> i_LastRightSubList = CreateNewList(i_CountSpaces, i_CountLetters);
            MenuItem i_ActionItem = new MenuItem("Actions", i_LastRightSubList);

            Version version = new Version();
            ActionItem i_CmpVersion = new ActionItem("Show Version", version);

            List<MainMenu> i_middleFirsSubList = CreateNewList(i_CmpVersion, i_ActionItem);
            MenuItem i_FirstItem = new MenuItem("Version And Action", i_middleFirsSubList);

            List<MainMenu> i_firstSubList = CreateNewList(i_FirstItem, i_LastSub);
            MenuItem m_MainMenu = new MenuItem("Main Menu", i_firstSubList);
            m_MainMenu.m_backButton = "Exit";
            m_MainMenu.Show();
        }

        public static List<MainMenu> CreateNewList(MainMenu i_Obj1, MainMenu i_Obj2)
        {
            List<MainMenu> i_MenuItem = new List<MainMenu>();
            i_MenuItem.Add(i_Obj1);
            i_MenuItem.Add(i_Obj2);

            return i_MenuItem;
        }
    }
}
