using Business.Services;
using ConsoleApp_Basketball.Controller;
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
            GroupController groupController = new GroupController();
           
            PlayerConroller playerConroller = new PlayerConroller();
            int num;
            do
            {
            option:
                Natification.Print(ConsoleColor.Blue, "Welcome Boksetball");
            Open: PlayerService playerService = new PlayerService(); Natification.Print(ConsoleColor.Cyan, "1.Player\n" +
                                                "2.Group");
            string option2 = Console.ReadLine();
              
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
                                          
                                                playerConroller.Create();
                                                break;
                                            case (int)Natification.Myoption.Update:
                                                playerConroller.Update();
                                                break;

                                            case (int)Natification.Myoption.Remove:

                                             playerConroller.Remove();
                                                break;
                                            case (int)Natification.Myoption.GetAll:

                                                playerConroller.GetAll();

                                                break;
                                            case (int)Natification.Myoption.Getone:

                                           playerConroller.GetOne();

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
                                     "0.Quit\n"
                                     );

                                    string option = Console.ReadLine();

                                    bool IsNum = int.TryParse(option, out num);
                                    if (IsNum)
                                    {
                                        switch (num)
                                        {
                                            case (int)Natification.Myoption.Create:
                                          
                                                groupController.Create();
                                                break;
                                            case (int)Natification.Myoption.Update:
                                                 groupController.Update();
                                                break;
                                            case (int)Natification.Myoption.Remove:

                                               groupController.Remove();
                                                break;
                                            case (int)Natification.Myoption.GetAll:

                                               groupController.GetAll();

                                                break;
                                            case (int)Natification.Myoption.Getone:
                                            groupController.GetOne();

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


