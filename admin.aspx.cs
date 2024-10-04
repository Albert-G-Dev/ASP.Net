using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOGIN
{
    public partial class Admin : System.Web.UI.Page
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
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("LOGIN.aspx"); 
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection conn = new SqlConnection("YourConnectionString"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Username = @Username AND Password = @Password", conn);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    
                    Session["UserID"] = reader["UserID"];
                    Response.Redirect("LOGIN.aspx");
                }
                else
                {
                    
                    lblError.Text = "Invalid username or password";
                }

        
            }
        }
    }
}
    
