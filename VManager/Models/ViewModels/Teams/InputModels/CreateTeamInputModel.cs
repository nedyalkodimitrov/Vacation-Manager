using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.Models.ViewModels.Teams
{
    public class CreateTeamInputModel
    {
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual int  ProjectId { get; set; }
    }
}
