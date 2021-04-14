using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.Models.ViewModels.Projects.InputModels
{
    public class UpdateProjectInputModel
    {
        public int Id { get; set; }
        public string NewName { get; set; }
        public string NewDescription { get; set; }
    }
}
