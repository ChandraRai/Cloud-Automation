using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleAuth.Utility
{
    public static class Who
    {
        public const string Admin = "Admin";
        public const string TeadLead = "TeamLead";
        public const string Supervisor = "Supervisor";
        public const string User = "User";
        public const string AdminAndTeamLead = "Admin, TeamLead";
        public const string All = "Admin, TeamLead, User";
    }
}
