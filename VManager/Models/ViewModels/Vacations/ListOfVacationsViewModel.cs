using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.ViewModels.Vacation
{
    public class ListOfVacationsViewModel
    {
        public int Id { get; set; }

        public string ApplicantName { get; set; }

        public string Type { get; set; }

        public bool IsApproved { get; set; }

        public int TeamId { get; set; }
        public int ApplicantId { get; set; }
    }
}
