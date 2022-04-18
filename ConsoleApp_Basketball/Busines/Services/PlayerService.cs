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
    public class PlayerService : IPlayer
    {
        public static int Count { get; set; }
        private PlayerRepository _playerRepository;
        public PlayerService ()
        {
            _playerRepository =new PlayerRepository();
        }
        public Player Create(Player player)
        {
            try
            {
                
                Count++;
                player.Id = Count;
                _playerRepository.Create(player);

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

       
        

        public Player Update(int id, Player Player)
        {
     

            try
            {   Predicate<Player> predicate = x => x.Id == id;
                bool result=predicate(Player);
                if (result)
                {
                    Player player1 = DataAcces.DataConnect.Players.Find(x => x.Id == id);
                    player1.Name = Player.Name;

                    _playerRepository.Update(player1);
                    return player1;
                }
                else
                {
                    Natification.Print(ConsoleColor.Red, "Because there is no such id, a new one was created");
                     Count++;
                    Player.Id = Count;
                    _playerRepository.Create(Player);

                    return Player;

                }

               

            }
            catch (Exception)
            {

                throw;
            }
           
           

        }

        public Player GetPlayer(int id)
        {
            try
            {
                Predicate<Player> predicate = x => x.Id == id;
               Player player = new Player();
                bool result = predicate(player);
                if (result)
                {
                    return _playerRepository.GetOne(x => x.Id == id);
                }
                else
                {
                    Natification.Print(ConsoleColor.Red, "There is no such id");
                    return player;
                }

               

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Player> GetAll()
        {
            try
            {
           return      _playerRepository.GetAll(x => x.Name == x.Name);
               

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}


