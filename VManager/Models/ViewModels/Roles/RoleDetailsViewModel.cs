using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.ViewModels.Role
{
    public class RoleDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<string> Usernames { get; set; } = new List<string>();
        //public bool IsSystem { get; set; }
    }
}
