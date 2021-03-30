using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp3.Models
{
    public partial class Team
    {
        public Team()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ProjectId { get; set; }
        public int? TeamLead { get; set; }

        public virtual Project Project { get; set; }
        public virtual User TeamLeadNavigation { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
