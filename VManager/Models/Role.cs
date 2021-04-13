using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VManager.Models;

namespace VManager.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsInSystem { get; set; }
        public virtual ICollection<User> Users { get; set; }  = new List<User>();

    }
}
