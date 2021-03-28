using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VacantionManager2.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Family { get; set; }
        public virtual Roles Role { get; set; }
        public virtual Teams Team {get;set;}
    }
}
