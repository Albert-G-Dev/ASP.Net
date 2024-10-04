using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOGIN
{
    public partial class LOGIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                // Check if user is already logged in
                if (Session["UserID"] != null)
                {
                    Response.Redirect("LOGIN.aspx");
                }
            }
        }
        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }

        protected void btnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("User.aspx");

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            {
                using (SqlConnection conn = new SqlConnection("dbconnection")) 
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Loginpage WHERE Username = john@gmail.com AND Password = 12345", conn);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // User credentials are valid, log in
                        Session["UserID"] = reader["UserID"];
                        Response.Redirect("LOGIN.aspx");
                    }
                    else
                    {
                        // User credentials are invalid, display error message
                        lblMessage.Text = "Invalid username or password";
                    }

                }
            }
        }
    }
}            
