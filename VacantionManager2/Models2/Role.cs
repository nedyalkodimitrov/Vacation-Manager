using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp3.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public byte Id { get; set; }
        public string Role1 { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
