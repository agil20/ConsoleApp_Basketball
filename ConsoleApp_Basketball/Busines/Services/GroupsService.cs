using Business.Interface;
using DataAcces.Repositers;
using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace Business.Services
{
    public class GroupsService : IGroups
    {
        public int Count { get; set; }
        private GroupsRepository _groupsRepository;
        public GroupsService()
        {
            _groupsRepository = new GroupsRepository();
        }
        public Groups Create(Groups groups)
        {
            try
            {
                groups.Id = Count;
                _groupsRepository.Create(groups);
                Count++;
                return groups;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Groups Delete(int id)
        {
            try
            {

           Groups groups=     DataAcces.DataConnect.Groups.Find(x => x.Id == id);
                _groupsRepository.Delete(groups);
                return groups;
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Groups GetGroups(int id)
        {
            try
            {
                Predicate<Groups> predicate = x => x.Id == id;
                Groups groups =new Groups();
                bool result = predicate(groups);
                if (result)
                {
                    return _groupsRepository.GetOne(x => x.Id == id);
                }
                else 
                {
                    Natification.Print(ConsoleColor.Red, "There is no such id");
                    return groups;
                }
              
                

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public Groups Update(int id, Groups groups)
        {
            Predicate<Groups> predicate1 = x=>x.Id == id;
            bool result = predicate1(groups);
                if (result)
            {
                Groups groups1 = DataAcces.DataConnect.Groups.Find(x => x.Id == id);
                groups1.Name = groups.Name;

                _groupsRepository.Update(groups1);
                return groups1;
            }
            else
            {
                Natification.Print(ConsoleColor.Red, "Because there is no such id, a new one was created");
                Count++;
                groups.Id = Count;
                _groupsRepository.Create(groups);
              
                return groups;

            }
           

        }

        public List<Groups> GetAll()
        {
            try
            {
                return _groupsRepository.GetAll(x => x.Id == x.Id);
            }
            catch (Exception)
            {

                throw;
            }
        }

       
    }
}
