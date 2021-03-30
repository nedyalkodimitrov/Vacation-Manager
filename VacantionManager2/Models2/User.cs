using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp3.Models
{
    public partial class User
    {
        public User()
        {
            Teams = new HashSet<Team>();
            Vacations = new HashSet<Vacation>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte RoleId { get; set; }
        public int? TeamId { get; set; }

        public virtual Role Role { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Vacation> Vacations { get; set; }
    }
}
