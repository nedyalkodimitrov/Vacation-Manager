using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.Models

{

    public enum VacationType
    {
        None,
        Payed,
        NotPayed,
        Hospital
    }       
        public class Vacation
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime QueryCreationDate { get; set; }
        public bool HalfDayVacation { get; set; }
        public bool IsApproved { get; set; }
        public int ApplicantId { get; set; }
        public virtual User Applicant { get; set; }
        public VacationType Type { get; set; }
    }
}
