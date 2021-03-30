using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacantionManager2.Models
{
    public enum RolesTypes
    {
        [Description("CEO")] CEO = 1,
        [Description("Developer")] Developer = 2,
        [Description("Team Lead")] TeamLead = 3,
        [Description("Unnsigned")] Unnsigned = 4
    }
    public class CreateRoleViewModel
    {
        [Required]
        public RolesTypes RoleName { get; set; }
    }
}
