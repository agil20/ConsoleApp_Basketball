using Business.Services;
using Entites.Models;
using System;
using System.Collections.Generic;
using Utilities.Helper;



namespace ConsoleApp_Basketball
{
    internal class Program
    {


        static void Main(string[] args)
        {
            PlayerService playerService = new PlayerService();


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
                                Natification.Print(ConsoleColor.White, "Enter name");
                                string name = Console.ReadLine();
                            Entervalue:
                                Natification.Print(ConsoleColor.White, "Enter value");
                                string value = Console.ReadLine();
                                int Value;
                                bool IsValue = int.TryParse(value, out Value);
                                if (IsValue)
                                {
                                    Player player = new Player
                                    {
                                        Name = name,
                                        Value = Value
                                    };

                                    playerService.Create(player);
                                    Natification.Print(ConsoleColor.Green, $"{player.Name} added");


                                }
                                else
                                {
                                    Natification.Print(ConsoleColor.Red, "Please note");
                                    goto Entervalue;
                                }
                                break;
                            case 2:
                                Natification.Print(ConsoleColor.Yellow, "New Player Enter");
                                Natification.Print(ConsoleColor.Yellow, "Enter Name");
                                string name1 = Console.ReadLine();
                            Entervalue1:
                                Natification.Print(ConsoleColor.Yellow, "Enter Value");
                                string value1 = Console.ReadLine();
                                int Value1;
                                bool IsValue1 = int.TryParse(value1, out Value1);
                                if (IsValue1)
                                {
                                id: Natification.Print(ConsoleColor.White, "id Enter");
                                    string id1 = Console.ReadLine();
                                    int id;
                                    bool IsId1 = int.TryParse(id1, out id);
                                    if (IsId1)
                                    {   Player player=new Player { Name = name1, Value = Value1 };
                                        playerService.Update(id, player);
                                        Natification.Print(ConsoleColor.Green, $"{player.Name} added");

                                    }
                                    else
                                    {
                                        Natification.Print(ConsoleColor.Red, "Please note");
                                        goto id;
                                    }

                                    break;




                                }
                                else
                                {
                                    Natification.Print(ConsoleColor.Red, "Please note");
                                    goto Entervalue1;
                                }
                       
                            case 3:

                                Natification.Print(ConsoleColor.Cyan, "Enter the player ID you want to delete ");

                            delete: string id2 = Console.ReadLine();
                                int Id3;
                                bool IsExist2 = int.TryParse(id2, out Id3);
                                if (IsExist2)
                                {
                                    playerService.Delete(Id3);

                                }
                                else
                                {
                                    Natification.Print(ConsoleColor.Red, "Please note");
                                    goto delete;

                                }
                                break;
                                case 4:

                            List<Player> list = playerService.GetAll();

                                foreach (var item in list)
                                {
                                    Console.WriteLine(item.Name);
                                }

                                break;
                            case 5:
                             getplayer:   Natification.Print(ConsoleColor.Cyan, "Enter id");
                                string payerid=Console.ReadLine();
                                int id5;
                                bool IsExist5 = int.TryParse(payerid, out id5);
                                if (IsExist5)
                                {
                                    Console.WriteLine(playerService.GetPlayer(id5).Name);

                                }
                                else
                                {
                                    Natification.Print(ConsoleColor.Red, "Please note");
                                    goto getplayer;

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

            } while (true);

        }


    }
}


