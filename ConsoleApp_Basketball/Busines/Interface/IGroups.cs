using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
  public interface IGroups
    {
        Groups Create(Groups groups);
        Groups Update(int id, Groups groups);
        Groups Delete(int id);
        Groups GetGroups(int id);
        List<Groups> GetAll();

    }
}
