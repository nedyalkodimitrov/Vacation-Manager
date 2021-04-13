using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.ViewModels
{
    public class UserGroupInfoViewModel
    {
        public int Id { get; set; }
        public bool IsLeader { get; set; }
        public int TeamId { get; set; }
    }
}
