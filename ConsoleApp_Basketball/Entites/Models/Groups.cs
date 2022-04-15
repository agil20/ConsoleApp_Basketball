using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites.Interface;

namespace Entites.Models
{
    public class Groups:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Value { get; set; }
    }
}
