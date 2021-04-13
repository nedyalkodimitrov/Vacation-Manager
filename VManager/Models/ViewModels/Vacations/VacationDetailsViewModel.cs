using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VManager.Models;

namespace VManager.ViewModels.Vacation
{
    public class VacationDetailsViewModel
    {
        public int Id { get; set; }
        public string ApplicantUsername { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool IsApproved { get; set; }
        public VacationType Type { get; set; }
        //public int ApplicantTeamId { get; set; }

    }
}
