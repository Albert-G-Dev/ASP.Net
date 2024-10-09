using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeaveApp
{
    public partial class Gridtable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindLeaveData();
            }
        }
        protected void btnLeaveApplication_Click(object sender, EventArgs e)
        {
            // Navigate to the Leave Application page
            Response.Redirect("LeaveApp.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Logic to log out the user
            Session.Abandon(); // Example: clear the session
            Response.Redirect("Login.aspx"); // Redirect to the login page
        }

        private void BindLeaveData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ApplicationID");
            dt.Columns.Add("Name");
            dt.Columns.Add("LeaveType");
            dt.Columns.Add("StartDate", typeof(DateTime));
            dt.Columns.Add("EndDate", typeof(DateTime));
            dt.Columns.Add("Reason");
            dt.Columns.Add("Status");

            
            dt.Rows.Add("174", "Anwar", "Sick Leave", DateTime.Parse("07-10-2024"), DateTime.Parse("10-10-2024"), "Sick Leave", "Rejected");
            dt.Rows.Add("175", "Ramar ", "Casual Leave", DateTime.Parse("07-10-2024"), DateTime.Parse("10-10-2024"), "Casual Leave", "Approved");
            dt.Rows.Add("179", "Rajesh", "Sick Leave", DateTime.Parse("14-10-2024"), DateTime.Parse("16-10-2024"), "Sick Leave", "Pending");
            dt.Rows.Add("185", "Murugan", "Sick Leave", DateTime.Parse("07-10-2024"), DateTime.Parse("10-10-2024"), "Sick", "Approved");

            LeaveGridView.DataSource = dt;
            LeaveGridView.DataBind();
        }
    }
}
