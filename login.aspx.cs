using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeaveApp
{
    public partial class login : System.Web.UI.Page
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


        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Loginpage WHERE Username =@Username AND Password =@password ", conn);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // User credentials are valid, log in
                        Session["UserID"] = reader["UserID"];
                        Response.Redirect("Gridtable.aspx");
                    }
                    else
                    {
                        // User credentials are invalid, display error message
                        lblMessage.Text = "Invalid username or password";
                    }

                }
            }
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            // Redirect to the Registration page
            Response.Redirect("Register.aspx");
        }

    }
}
