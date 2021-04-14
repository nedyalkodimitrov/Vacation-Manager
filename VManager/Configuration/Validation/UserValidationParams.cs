using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.Configuration.Validation
{
    public static class UserValidationParams
    {
        public const int Username_Max_Length = 30;
        public const int Username_Min_Length = 5;

        public const int Password_Max_Length = 30;
        public const int Password_Min_Length = 10;

        public const int FirstName_Max_Length = 30;
        public const int Surname_Max_Length = 30;        
    }
}
