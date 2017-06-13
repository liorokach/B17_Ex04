namespace Ex04.Menus.Test
{
     public class Ex04
     {
          public static void Main()
          {
               RunInterfaceProject.Run();
               System.Console.WriteLine("Interface part completed, press enter to start the delegate part:");
               System.Console.ReadLine();
               DelegateTest.Run();
          }
     }
}
