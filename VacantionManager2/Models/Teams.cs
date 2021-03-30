using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacantionManager2.Models
{
    public class Teams
    {
        [Key]
        public int TeamId { get; set; }
        [Display(Name = "Team Name")]
        public string Name { get; set; }
        [Display(Name = "Team Project")]
        public Projects Project {get;set;}
        public int UserId { get; set; }
        //[Display(Name = "Team Developers")]
        public ICollection<UserApplication> Users { get; set; }

        //лидер на екипа
        
       

    }
}
