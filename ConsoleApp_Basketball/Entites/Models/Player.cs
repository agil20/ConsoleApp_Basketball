using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites.Interface;

namespace Entites.Models
{
    public class Player:IEntity
    {
        private static int _id { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
       


    }
}
