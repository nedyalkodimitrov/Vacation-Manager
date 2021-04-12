using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.Models
{
    public class Vacation
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime QueryCreationDate { get; set; }
        public bool HalfDayVacation { get; set; }
        public bool Approved { get; set; }
        public int ApplicantId { get; set; }
        public virtual User Applicant { get; set; }
        public string ReasonForAbsence { get; set; }
    }
}
