using Business.Services;
using Entites.Models;
using System;
using System.Collections.Generic;
using Utilities.Helper;

namespace ConsoleApp_Basketball.Controller
{
    public class GroupController
    {
        GroupsService groupsService;
        public GroupController()
        {
            groupsService = new GroupsService();
        }
        public void Create()
        {
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
        }
        public void Update()
        {
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
        }
        public void GetAll()
        {
            List<Groups> list = groupsService.GetAll();

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
        }
        public void GetOne() {
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
        }
    }
}
