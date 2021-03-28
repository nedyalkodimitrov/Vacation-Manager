using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace VacantionManager2.Models
{
    //“CEO”, “Developer”, “Team Lead” и “Unassigned”
    public enum RolesTypes
    {
        [Description("CEO")] CEO = 1,
        [Description("Developer")] Developer = 2,
        [Description("Team Lead")] TeamLead = 3,
        [Description("Unnsigned")] Unnsigned = 4
    }
  
    public class Roles
    {
        public RolesTypes Role { get; set; }
        public string UserUsername { get; set; }
        public virtual ICollection<User> Users {get;set;}
    }
}
