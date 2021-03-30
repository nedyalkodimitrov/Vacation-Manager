using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp3.Models
{
    public partial class Vacation
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime QueryCreation { get; set; }
        public bool HalfDayVacation { get; set; }
        public bool Approved { get; set; }
        public int Applicant { get; set; }
        public string ReasonForAbsence { get; set; }

        public virtual User ApplicantNavigation { get; set; }
    }
}
