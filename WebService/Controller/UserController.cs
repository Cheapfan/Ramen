using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Handler;

namespace WebService.Controller
{
    public class UserController
    {
        public static string addUser(string username, string email, int roleId, string gender, string password, string confirmPassword)
        {
            

            return UserHandler.addUser(username, email, roleId, gender, password);
        }
    }
}