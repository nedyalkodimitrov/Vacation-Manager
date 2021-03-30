using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ConsoleApp3.Models
{
    public partial class Team
    {
        public Team()
        {
            Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        public int? ProjectId { get; set; }
        public int? TeamLead { get; set; }

        [ForeignKey(nameof(ProjectId))]
        [InverseProperty("Teams")]
        public virtual Project Project { get; set; }
        [ForeignKey(nameof(TeamLead))]
        [InverseProperty(nameof(User.Teams))]
        public virtual User TeamLeadNavigation { get; set; }
        [InverseProperty(nameof(User.Team))]
        public virtual ICollection<User> Users { get; set; }
    }
}
