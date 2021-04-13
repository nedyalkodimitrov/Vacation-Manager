using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VManager.Models;

namespace VManager.ViewModels.Teams
{
    public class TeamDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProjectName { get; set; }
        public string Leader { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
