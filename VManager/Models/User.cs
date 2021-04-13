using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VManager.Models;

namespace VManager.Models
{

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Vacation> Vacations { get; set; } = new List<Vacation>();
        public bool IsLeader { get; set; }
    }
}
