using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Authendication
{
    public class Auth {
        public string  SigIn(string username, string password)
        {
            string msg = "";
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                msg = "Provide username and password";
            }
            else
            {
                if (username == "Suresh" && password == "Suresh@123")
                {
                    msg = "Sigin success";
                }
                else
                {
                    msg = "sigin faild";
                }
            }
            return msg;
        }
    }
}
