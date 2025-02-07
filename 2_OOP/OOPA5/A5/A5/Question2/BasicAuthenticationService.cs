using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static A5.Question2.IAuthenticationService;

namespace A5.Question2
{
    internal class BasicAuthenticationService: IAuthenticationService
    {
        
        public string? UserName { get; set; }
        public int Password { get; set; }
        public Roles Role { get; set; }


        public BasicAuthenticationService(string? userName, int password, Roles role)
        {
            UserName = userName;
            Password = password;
            Role = role;

        }
        public bool AuthenticateUser(string? userName, int password)
        {
            if (userName == UserName && password == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AuthorizeUser(string? userName, Roles role)
        {
            if (userName == UserName && role == Role )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
