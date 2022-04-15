using System;

namespace Utilities.Helper
{
    public class Natification
    {
      
        public static void Print(ConsoleColor color,string mesagge)
        { Console.ForegroundColor = color; Console.WriteLine(mesagge); 
            Console.ResetColor();

          

        }
      public  enum Myoption
        {
            /* Natification.Print(ConsoleColor.Green, "1.Create Player\n" +
                    "2.Update Player\n" +
                    "3.Remove Player\n" +
                    "4.Get All Player");*/
            Create,Update,Remove,GetAll,Getone
        }
       
    }
}
