using Front_End.localhost;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Front_End.View
{
    public partial class Register : System.Web.UI.Page
    {
        public static WebService webService = new WebService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string gender = null;
            if (radioBtnGenderMale.Checked) gender = "Male";
            else if (radioBtnGenderFemale.Checked) gender = "Female";
            int roleId = 0;
            if (radioBtnRoleStaff.Checked) roleId = 2;
            else if (radioBtnRoleMember.Checked) roleId = 3;

            JsonConvert.DeserializeObject<String>(webService.addUser(username, email, roleId, gender, password, confirmPassword));

        }
    }
}