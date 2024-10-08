using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeaveApp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
        
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string gender = rbtnMale.Checked ? "Male" : rbtnFemale.Checked ? "Female" : string.Empty;
            string phone = txtPhone.Text.Trim();


      
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(phone))
            {
                lblMessage.Text = "All fields are required!";
                return;
            }

            if (password != confirmPassword)
            {
                lblMessage.Text = "Passwords do not match!";
                return;
            }

            if (phone.Length != 10 || !long.TryParse(phone, out _))
            {
                lblMessage.Text = "Enter a valid 10-digit phone number!";
                return;
            }

            // Save the data (For demonstration, just showing a success message)
            lblMessage.Text = "Registration successful!";
        }

    }
}
