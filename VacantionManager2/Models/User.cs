using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ConsoleApp3.Models
{
    [Table("User")]
    public partial class User
    {
        public User()
        {
            Teams = new HashSet<Team>();
            Vacations = new HashSet<Vacation>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Username { get; set; }
        [Required]
        [StringLength(25)]
        public string Password { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Surname { get; set; }
        public byte RoleId { get; set; }
        public int? TeamId { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty("Users")]
        public virtual Role Role { get; set; }
        [ForeignKey(nameof(TeamId))]
        [InverseProperty("Users")]
        public virtual Team Team { get; set; }
        [InverseProperty("TeamLeadNavigation")]
        public virtual ICollection<Team> Teams { get; set; }
        [InverseProperty(nameof(Vacation.ApplicantNavigation))]
        public virtual ICollection<Vacation> Vacations { get; set; }
    }
}
