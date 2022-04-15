using Entites.Models;
using System;
using Utilities.Helper;
using Business;
using Business.Services;

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
                                Console.WriteLine("Enter name");
                                string name = Console.ReadLine();
                            Entervalue:
                                Console.WriteLine("Enter Value");
                                string value = Console.ReadLine();
                                int Value;
                                bool IsValue = int.TryParse(value, out Value);
                                if (IsNum)
                                {
                                    Player player = new Player();
                                    player.Name = name;
                                    player.Value = Value;
                                    
                                    
                                }
                                else
                                {
                                    Natification.Print(ConsoleColor.Red, "Please note");
                                    goto Entervalue;
                                }
                                break;
                            case 2:
                                Console.WriteLine("Update ucun id daxil edin");
                                int 
                                
                                break;


                        }
                    }
                    else
                    {
                        Natification.Print(ConsoleColor.Red, "Please note");
                        goto Enter;
                    }

                } while (num > 5 && num < 0);

            }while (true);

        }


    }
}


