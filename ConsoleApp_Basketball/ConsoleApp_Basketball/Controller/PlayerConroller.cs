using Business.Services;
using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace ConsoleApp_Basketball.Controller
{
public class PlayerConroller
    {
        PlayerService playerService;
        public PlayerConroller()
        {
            playerService = new PlayerService();
        }
        public void Create()
        {
            Natification.Print(ConsoleColor.White, "Enter name");
            string name = Console.ReadLine();
            Console.Clear();
            Natification.Print(ConsoleColor.White, "Enter Surname");
            string surname = Console.ReadLine();
            Console.Clear();
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
                    Surname = surname

                };

                playerService.Create(player);
                Natification.Print(ConsoleColor.Green, $"{player.Name}\n" +
                    $"{player.Surname} added");
                Console.Clear();
            }
            else
            {
                Natification.Print(ConsoleColor.Red, "Please note");
               
                goto Entervalue;
               
            }

        }
        public void Update() {
            Natification.Print(ConsoleColor.Yellow, "New Player Enter");
           
            Natification.Print(ConsoleColor.Yellow, "Enter Name");
     
            string name1 = Console.ReadLine();
            Console.Clear();
            Natification.Print(ConsoleColor.Yellow, "Enter Surname");
           
            string surname1 = Console.ReadLine();
            Console.Clear();
        Entervalue1:
            Natification.Print(ConsoleColor.Yellow, "Enter Value");
            string value1 = Console.ReadLine();
            Console.Clear();
            int Value1;
            bool IsValue1 = int.TryParse(value1, out Value1);
            if (IsValue1)
            {
            id: Natification.Print(ConsoleColor.White, "id Enter");
                string id1 = Console.ReadLine();
                Console.Clear();
                int id;
                bool IsId1 = int.TryParse(id1, out id);
                if (IsId1)
                {
                    Player player = new Player { Name = name1, Value = Value1, Surname = surname1 };
                    playerService.Update(id, player);
                    Natification.Print(ConsoleColor.Green, $"{player.Name} added");
               
                }
                else
                {
                    Natification.Print(ConsoleColor.Red, "Please note");
                    goto id;
                }



            }
            else
            {
                Natification.Print(ConsoleColor.Red, "Please note");
                goto Entervalue1;
            }
        }
        public void Remove()
        {
            Natification.Print(ConsoleColor.Cyan, "Enter the player ID you want to delete ");

        delete: string id2 = Console.ReadLine();
            Console.Clear();
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
        }
        public void GetAll() {
            List<Player> list = playerService.GetAll();

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
        ;
        }
        public void GetOne()
        {
        getplayer: Natification.Print(ConsoleColor.Cyan, "Enter id");
            string payerid = Console.ReadLine();
            Console.Clear();
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
        }

    }
}
