using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.Configuration.Validation
{
    public static class RoleValidationParams
    {
        public const int Name_Max_Length = 10;
        public const int Name_Min_Length = 3;

        public const string Ceo_Role_Name = "CEO";
        public const string TeamLead_Role_Name = "Team Lead";
        public const string Developer_Role_Name = "Developer";
        public const string Without_Role_Name = "Unassigned";

    }
}
