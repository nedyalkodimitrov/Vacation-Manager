using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacantionManager2.Models
{
    public class UserApplication
    {

        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string Family { get; set; }
        [Display(Name = "Role")]
        public RolesTypes Role { get; set; }
        /*[Required]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }*/
        //public int TeamId { get; set; }
        //public virtual Teams Team {get;set;}
    }
}
