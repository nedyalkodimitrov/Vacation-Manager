using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.Models.ViewModels.Teams.InputModels
{
    public class UpdateTeamInputModel
    {
        public int Id { get; set; }
        public string NewName { get; set; }
        public virtual int ProjectId { get; set; }

    }
}
