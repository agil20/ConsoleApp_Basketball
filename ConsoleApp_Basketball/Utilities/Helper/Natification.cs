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
         
              Create=1,Update=2,Remove=3,GetAll=4,Getone=5,Quit=0
        }
       
    }
}
