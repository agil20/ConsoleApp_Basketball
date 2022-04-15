using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IPlayer
    {
        Player Create(Player player);
        Player Update(int id, Player player);
        Player Delete(int id);
        Player GetPlayer(string name);



    }
}
