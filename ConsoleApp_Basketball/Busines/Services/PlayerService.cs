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
    public class PlayerService : IPlayer
    {
        public int Count { get; set; }
        private PlayerRepository _playerRepository;
        public PlayerService ()
        {
            _playerRepository =new PlayerRepository();
        }
        public Player Create(Player player)
        {
            try
            {
                player.Id = Count;
          
                Count++; _playerRepository.Create(player);

                return player;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Player Delete(int id)
        {
            try
            {

                Player player = DataAcces.DataConnect.Players.Find(x => x.Id == id);
                _playerRepository.Delete(player);
                return player;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Player GetPlayer(string name)
        {
            try
            {
                return _playerRepository.GetOne(x => x.Name == name);

            }
            catch (Exception)
            {

                throw;
            }

        }

        public Player Update(int id, Player Player)
        {
            Player player1 = DataAcces.DataConnect.Players.Find(x => x.Id == id);
            player1.Name=Player.Name;

            _playerRepository.Update(player1);
            return player1;

        }
    }
}


