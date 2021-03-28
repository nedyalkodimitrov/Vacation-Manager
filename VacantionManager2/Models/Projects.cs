using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VacantionManager2.Models
{
    /*•	име
•	описание
•	екипи, които работят по проекта
*/
    public class Projects
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Teams> Teams { get; set; }
    }
}
