using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VacantionManager2.Models
{
    public class UserRoleViewModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public bool HasSelectedRole { get; set; }

    }
}
