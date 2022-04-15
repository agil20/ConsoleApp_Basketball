using DataAcces.Interface;
using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositers
{
    public class GroupsRepository : IRepository<Groups>
    {
        public bool Create(Groups entity)
        {
            try
            {
                DataAcces.DataConnect.Groups.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Groups entitiy)
        {
            try
            {
                DataAcces.DataConnect.Groups.Remove(entitiy);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Groups> GetAll(Predicate<Groups> filter = null)
        {
            try
            {
                return DataAcces.DataConnect.Groups.FindAll(filter);
           
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Groups GetOne(Predicate<Groups> filter = null)
        {
            try
            {
               return  DataAcces.DataConnect.Groups.Find(filter);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Groups entitiy)
        {
            try
            {
                Groups IsExist = GetOne(g => g.Id == entitiy.Id);
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
