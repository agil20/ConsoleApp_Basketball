using Entites.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Interface
{
 public interface IRepository<T> where T : IEntity
    {
        bool Create(T entitiy);
        bool Delete(T entitiy);
        bool Update(T entitiy);
        T GetOne(Predicate<T>filter=null);
        List<T> GetAll(Predicate<T> filter = null);



    }
}
