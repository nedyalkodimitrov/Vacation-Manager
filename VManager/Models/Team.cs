using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.Models
{
    
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProjectId {get;set;}
        public virtual Project Project {get;set;}
        public virtual ICollection<User> Users {get;set;}
        public int LeaderId { get; set; }
    }
}
