using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.Models.ViewModels.Vacations.InputModels
{
    public class UpdateVacationInputModel
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool IsApproved { get; set; }
        public int ApplicantId { get; set; }
        public VacationType Type { get; set; }

    }
}
