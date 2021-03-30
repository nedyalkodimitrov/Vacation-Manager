using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ConsoleApp3.Models
{
    public partial class Project
    {
        public Project()
        {
            Teams = new HashSet<Team>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        [InverseProperty(nameof(Team.Project))]
        public virtual ICollection<Team> Teams { get; set; }
    }
}
