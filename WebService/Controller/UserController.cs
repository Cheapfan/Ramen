using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Handler;

namespace WebService.Controller
{
    public class UserController
    {
        public static List<string> addUser(string username, string email, int roleId, string gender, string password, string confirmPassword)
        {
            string errMessageUsername="";
            string errMessageEmail="";
            string errMessageRole="";
            string errMessageGender="";
            string errMessagePassword="";
            string errMessageConfirmPassword="";
            bool isRegisterValid = true;

            if (username == "")
            {
                errMessageUsername = "Username must be filled";
                isRegisterValid = false;
            }
            else if (username.Length < 5 || username.Length > 15 || !username.All(c => Char.IsLetter(c) || c == ' '))
            {
                errMessageUsername = "Username length must be between 5 and 15 and alphabet with space only";
                isRegisterValid = false;
            }

            if (email == "")
            {
                errMessageEmail = "Email must be filled";
                isRegisterValid = false;
            }
            else if (!email.EndsWith(".com"))
            {
                errMessageEmail = "Email must end with '.com' ";
                isRegisterValid = false;
            }

            if (roleId == 0)
            {
                errMessageRole = "Role must be choosen";
                isRegisterValid = false;
            }

            if (gender == null)
            {
                errMessageGender = "Gender must be choosen";
                isRegisterValid = false;
            }

            if (password == "")
            {
                errMessagePassword = "Password must be filled";
                isRegisterValid = false;
            }

            if (confirmPassword == "")
            {
                errMessageConfirmPassword = "Confirm password must be filled";
                isRegisterValid = false;
            }
            else if (confirmPassword != password)
            {
                errMessageConfirmPassword = "Must be the same with confirm password";
                isRegisterValid = false;
            }

            List<string> output = new List<string> { errMessageUsername, errMessageEmail, errMessageRole, errMessageGender, errMessagePassword, errMessageConfirmPassword };
            if (isRegisterValid == true)
            {
                UserHandler.addUser(username, email, roleId, gender, password);
            }
            return output;
        }
    }
}