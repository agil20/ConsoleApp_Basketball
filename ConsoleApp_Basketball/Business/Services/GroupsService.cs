using Business.Interface;
using Business.Repositers;
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
        public GroupsService(GroupsRepository groupsRepository)
        {
            _groupsRepository = groupsRepository;
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
              
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Groups GetPlayer(string name)
        {
            throw new NotImplementedException();
        }

        public Groups Update(int id, Groups groups)
        {
            throw new NotImplementedException();
        }
    }
}
