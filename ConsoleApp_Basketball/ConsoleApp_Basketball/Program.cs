using System;
using Utilities.Helper;


namespace ConsoleApp_Basketball
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int num;
            Natification.Print(ConsoleColor.Blue, "Welcome Boksetball");

            do
            {
            Enter:
                Natification.Print(ConsoleColor.Green, "1.Create Player\n" +
                 "2.Update Player\n" +
                 "3.Remove Player\n" +
                 "4.Get All Player\n" +
                 "5.Get one Player\n" +
                 "0.Quit");

                string option = Console.ReadLine();

                bool IsNum = int.TryParse(option, out num);
                if (IsNum)
                {
                    switch (num)
                    {
                        case 1:
                            string name = Console.ReadLine();
                        Entervalue: string value = Console.ReadLine();
                            bool IsValue = int.TryParse(value, out num);
                            if (IsNum)
                            {
                             


                            }
                            else
                            {
                                Natification.Print(ConsoleColor.Red, "Please note");
                                goto Entervalue;
                            }
                            break;


                    }
                }
                else
                {
                    Natification.Print(ConsoleColor.Red, "Please note");
                    goto Enter;
                }

            } while (num > 5 && num < 0);



        }


    }
}


