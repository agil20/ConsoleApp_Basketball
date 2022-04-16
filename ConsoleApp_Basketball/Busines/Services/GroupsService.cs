using Business.Interface;
using DataAcces.Repositers;
using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Groups GetPlayer(int id)
        {
            try
            {
                return _groupsRepository.GetOne(x => x.Id == id);

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public Groups Update(int id, Groups groups)
        {
            Groups groups1 = DataAcces.DataConnect.Groups.Find(x => x.Id == id);
            groups1.Name = groups.Name;

            _groupsRepository.Update(groups1);
            return groups1;

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
