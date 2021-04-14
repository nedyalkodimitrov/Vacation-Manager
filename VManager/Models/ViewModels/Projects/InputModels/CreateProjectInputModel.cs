using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.Models.ViewModels.Projects.InputModels
{
    public class CreateProjectInputModel
    {
        public string Name { get; set; }
        public string Descritpion { get; set; }
        public virtual ICollection<Team> Teams { get; set; }

    }
}
