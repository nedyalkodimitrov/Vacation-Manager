using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.Models.ViewModels.Vacations.InputModels
{
    public class CreateVacationInputModel
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime QueryCreationDate { get; set; }
        public VacationType Type { get; set; }

    }
}
