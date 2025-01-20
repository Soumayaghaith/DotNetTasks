using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5.Question2
{
    internal interface IAuthenticationService
    {
        enum Roles { SysAdmin, User, Manager, VP}
        public Roles Role { get; set; }

        public bool AuthenticateUser(string? userName, int password);
        public bool AuthorizeUser(string? userName,Roles role);
    }
}
