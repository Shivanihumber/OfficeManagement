using OfficeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeManagement.EF
{
    public class UserDetail
    {
        public ApplicationUser applicationUser { get; set; }
        public List<Position> Positions { get; set; }
    }

    public class UserDetailNoAdmin
    {
        public ApplicationUser applicationUser { get; set; }
        public List<String> directReportUserNames { get; set; }
        public String supervisor { get; set; }
    }
}
