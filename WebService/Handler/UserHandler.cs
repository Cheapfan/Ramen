using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Repository;

namespace WebService.Handler
{
    public class UserHandler
    {
        public static string addUser(string name, string email, int roleId, string gender, string password)
        {
            return UserRepository.registerUser(name, email, roleId, gender, password);
        }
    }
}