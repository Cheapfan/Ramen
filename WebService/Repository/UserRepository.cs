using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Factory;

namespace WebService.Repository
{
    public class UserRepository
    {
        public static WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();

        public static string registerUser(string name, string email, int roleId, string gender, string password)
        {
            User newUser = UserFactory.createUser(name, email, roleId, gender, password);

            db.Users.Add(newUser);
            db.SaveChanges();

            return "SUCCESS";   
        }
    }
}