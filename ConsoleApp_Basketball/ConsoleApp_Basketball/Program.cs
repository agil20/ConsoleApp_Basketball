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
        { GroupsService groupsService = new GroupsService();


            int num;
            do
            {
                Natification.Print(ConsoleColor.Blue, "Welcome Boksetball");
       Open:         PlayerService playerService = new PlayerService(); Natification.Print(ConsoleColor.Cyan, "1.Player\n" +
                                                   "2.Group");
            option: string option2 = Console.ReadLine();
                int Isoption;
                bool optionn = int.TryParse(option2, out Isoption);
                if (optionn)
                {
                    switch (Isoption)
                    {
                        case 1:
                            do
                            {
                                do
                                {
                                Enter:
                                    Natification.Print(ConsoleColor.Green, "1.Create Player\n" +
                                     "2.Update Player\n" +
                                     "3.Remove Player\n" +
                                     "4.Get All Player\n" +
                                     "5.Get one Player\n\n" +
                                     "0.Quit"
                                    );

                                    string option = Console.ReadLine();

                                    bool IsNum = int.TryParse(option, out num);
                                    if (IsNum)
                                    {
                                        switch (num)
                                        {
                                            case (int)Natification.Myoption.Create:
                                                Natification.Print(ConsoleColor.White, "Enter name");
                                                string name = Console.ReadLine();
                                                Natification.Print(ConsoleColor.White, "Enter Surname");
                                                string surname = Console.ReadLine();
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
                                                        Value = Value,
                                                        Surname=surname
                                                        
                                                    };

                                                    playerService.Create(player);
                                                    Natification.Print(ConsoleColor.Green, $"{player.Name}\n" +
                                                        $"{player.Surname} added");


                                                }
                                                else
                                                {
                                                    Natification.Print(ConsoleColor.Red, "Please note");
                                                    goto Entervalue;
                                                }
                                                break;
                                            case (int)Natification.Myoption.Update:
                                                Natification.Print(ConsoleColor.Yellow, "New Player Enter");
                                                Natification.Print(ConsoleColor.Yellow, "Enter Name");
                                                string name1 = Console.ReadLine();
                                                Natification.Print(ConsoleColor.Yellow, "Enter Surname");
                                                string surname1 = Console.ReadLine();
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
                                                    {
                                                        Player player = new Player { Name = name1, Value = Value1,Surname=surname1 };
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

                                            case (int)Natification.Myoption.Remove:

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
                                            case (int)Natification.Myoption.GetAll:

                                                List<Player> list = playerService.GetAll();

                                                foreach (var item in list)
                                                {
                                                    Console.WriteLine(item.Name);
                                                }

                                                break;
                                            case (int)Natification.Myoption.Getone:

                                            getplayer: Natification.Print(ConsoleColor.Cyan, "Enter id");
                                                string payerid = Console.ReadLine();
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
                                            case (int)Natification.Myoption.Quit: goto Open;
                                            default: goto Enter;

                                        }
                                    }
                                    else
                                    {
                                        Natification.Print(ConsoleColor.Red, "Please note");
                                        goto Enter;
                                    }

                                } while (num > 5 && num < 0);

                            } while (true);


                        case 2:
                            do
                            {
                                do
                                {
                                Enter:
                                    Natification.Print(ConsoleColor.Green, "1.Create Group\n" +
                                     "2.Update Group\n" +
                                     "3.Remove Group\n" +
                                     "4.Get All Group\n" +
                                     "5.Get one Group\n" +
                                     "6.Quit\n"
                                     );

                                    string option = Console.ReadLine();

                                    bool IsNum = int.TryParse(option, out num);
                                    if (IsNum)
                                    {
                                        switch (num)
                                        {
                                            case (int)Natification.Myoption.Create:
                                                Natification.Print(ConsoleColor.White, "Enter name");
                                                string name = Console.ReadLine();
                                            Entervalue:
                                                Natification.Print(ConsoleColor.White, "Enter value");
                                                string value = Console.ReadLine();
                                                int Value;
                                                bool IsValue = int.TryParse(value, out Value);
                                                if (IsValue)
                                                {
                                                    Groups groups = new Groups
                                                    {
                                                        Name = name,
                                                        Value = Value
                                                    };

                                                    groupsService.Create(groups);
                                                    Natification.Print(ConsoleColor.Green, $"{groups.Name} added");


                                                }
                                                else
                                                {
                                                    Natification.Print(ConsoleColor.Red, "Please note");
                                                    goto Entervalue;
                                                }
                                                break;
                                            case (int)Natification.Myoption.Update:
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
                                                    {
                                                        Groups groups = new Groups { Name = name1, Value = Value1 };
                                                        groupsService.Update(id, groups);
                                                        Natification.Print(ConsoleColor.Green, $"{groups.Name} added");

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

                                            case (int)Natification.Myoption.Remove:

                                                Natification.Print(ConsoleColor.Cyan, "Enter the player ID you want to delete ");

                                            delete: string id2 = Console.ReadLine();
                                                int Id3;
                                                bool IsExist2 = int.TryParse(id2, out Id3);
                                                if (IsExist2)
                                                {
                                                    groupsService.Delete(Id3);

                                                }
                                                else
                                                {
                                                    Natification.Print(ConsoleColor.Red, "Please note");
                                                    goto delete;

                                                }
                                                break;
                                            case (int)Natification.Myoption.GetAll:

                                                List<Groups> list = groupsService.GetAll();

                                                foreach (var item in list)
                                                {
                                                    Console.WriteLine(item.Name);
                                                }

                                                break;
                                            case (int)Natification.Myoption.Getone:
                                            getplayer: Natification.Print(ConsoleColor.Cyan, "Enter id");
                                                string payerid = Console.ReadLine();
                                                int id5;
                                                bool IsExist5 = int.TryParse(payerid, out id5);
                                                if (IsExist5)
                                                {
                                                    Console.WriteLine(groupsService.GetGroups(id5).Name);

                                                }
                                                else
                                                {
                                                    Natification.Print(ConsoleColor.Red, "Please note");
                                                    goto getplayer;

                                                }

                                                break;
                                            case (int)Natification.Myoption.Quit:
                                                goto Open;
                                            default: goto Enter;

                                        }
                                    }
                                    else
                                    {
                                        Natification.Print(ConsoleColor.Red, "Please note");
                                        goto Enter;
                                    }

                                } while (num > 5 && num < 0);

                            } while (true);


                        default: goto option;

                    }

                }
                else
                {

                    Natification.Print(ConsoleColor.Cyan, "Please Note");
                    goto option;

                }




            } while (true);
      
           

        }


    }
}


