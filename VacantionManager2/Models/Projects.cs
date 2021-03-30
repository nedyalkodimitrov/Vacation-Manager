using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacantionManager2.Models
{

    public class Projects
    {
        [Key]
        public int ProjectId { get; set; }
        [Display(Name = "Project Name")]
        public string Name { get; set; }
        [Display(Name = "Project Description")]
        public string Description { get; set; }

        [Display(Name = "Project Teams")]
        public virtual ICollection<Teams> Teams { get; set; }
    }
}
