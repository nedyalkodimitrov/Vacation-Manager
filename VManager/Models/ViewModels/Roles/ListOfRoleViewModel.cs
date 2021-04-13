using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.ViewModels.Role
{
    public class ListOfRoleViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountOfUsersWithThisRole { get; set; }
    }
}
