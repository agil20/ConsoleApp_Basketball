using DataAcces.Interface;
using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositers
{
    public class PlayerRepository : IRepository<Player>
    {
        public bool Create(Player entity)
        {
            try
            {
                DataAcces.DataConnect.Players.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Player entitiy)
        {
            try
            {
                DataAcces.DataConnect.Players.Remove(entitiy);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Player> GetAll(Predicate<Player> filter = null)
        {
            try
            {
                return filter == null ? DataAcces.DataConnect.Players.FindAll(filter) : DataAcces.DataConnect.Players.FindAll(filter);


            }
            catch (Exception)
            {

                throw;
            }
        }

        public Player GetOne(Predicate<Player> filter = null)
        {
            try
            {
                return filter == null ? DataAcces.DataConnect.Players[0] : DataAcces.DataConnect.Players.Find(filter);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Player entitiy)
        {
            try
            {
                Player IsExist = GetOne(g => g.Id == entitiy.Id);
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
