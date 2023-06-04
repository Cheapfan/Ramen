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
            string errMessageUsername;
            string errMessageEmail;
            string errMessageRole;
            string errMessageGender;
            string errMessagePassword;
            string errMessageConfirmPassword;

            if (username == "") errMessageUsername = "Username must be filled";
            else if (username.Length < 5 || username.Length > 15 || username.All( c => Char.IsLetter(c) || c == ' ')) errMessageUsername = "Username length must be between 5 and 15 and alphabet with space only" ;

            if (email == "") errMessageEmail = "Email must be filled";
            else if (!email.EndsWith(".com")) errMessageEmail = "Email must end with '.com' ";

            if (roleId == 0) errMessageRole = "Role must be choosen";

            if (gender == null) errMessageGender = "Gender must be choosen";

            if (password == "") errMessagePassword = "Password must be filled";
            else if (password != confirmPassword) errMessagePassword = "Must be the same with confirm password";

            if (confirmPassword == "") errMessageConfirmPassword = "Confirm password must be filled";
            else if (confirmPassword != password) errMessageConfirmPassword = "Must be the same with confirm password";



            return UserHandler.addUser(username, email, roleId, gender, password);
        }
    }
}