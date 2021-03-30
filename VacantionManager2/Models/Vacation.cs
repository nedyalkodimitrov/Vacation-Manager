using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ConsoleApp3.Models
{
    [Table("Vacation")]
    public partial class Vacation
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime QueryCreation { get; set; }
        public bool HalfDayVacation { get; set; }
        public bool Approved { get; set; }
        public int Applicant { get; set; }
        [Required]
        public string ReasonForAbsence { get; set; }

        [ForeignKey(nameof(Applicant))]
        [InverseProperty(nameof(User.Vacations))]
        public virtual User ApplicantNavigation { get; set; }
    }
}
