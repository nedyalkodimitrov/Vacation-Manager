using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacantionManager2.Models
{
    public class Vacations
    {
        [Key]
        public int VacantionId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public int FromDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public int UntilDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public int CurrentDate { get; set; }
        public bool HalfDayVacantion { get; set; }
        public bool Approved { get; set; }
        public int ApplicantId { get; set; }
        public UserApplication Applicant { get; set; }

    }
}
