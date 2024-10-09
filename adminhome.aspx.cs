using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeaveApp
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPendingRequests();
                BindLeaveHistory();
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");  
        }

        
        private void BindPendingRequests()
        {
            
            var pendingRequests = new List<dynamic>
        {
            new { ID = 100, Name = "Albert Rio", LeaveType = "Sick Leave", StartDate = DateTime.Parse("2024-10-14 00:00:00"), EndDate = DateTime.Parse("2024-10-16 00:00:00"), Reason = "Sick Leave", Status = "Pending" }
        };
            gvPendingRequests.DataSource = pendingRequests;
            gvPendingRequests.DataBind();
        }

        
        private void BindLeaveHistory()
        {
           
            var leaveHistory = new List<dynamic>
        {
            new { ID = 164, Name = "Albert", LeaveType = "Sick Leave", StartDate = DateTime.Parse("2024-10-07"), EndDate = DateTime.Parse("2024-10-10"), Status = "Rejected" },
            new { ID = 165, Name = "Aravindh", LeaveType = "Casual Leave", StartDate = DateTime.Parse("2024-10-07"), EndDate = DateTime.Parse("2024-10-10"), Status = "Approved" },
            new { ID = 166, Name = "Ananth", LeaveType = "Sick Leave", StartDate = DateTime.Parse("2024-10-07"), EndDate = DateTime.Parse("2024-10-10"), Status = "Approved" }
        };
            gvLeaveHistory.DataSource = leaveHistory;
            gvLeaveHistory.DataBind();
        }

        protected void gvPendingRequests_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            int leaveId = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Approve")
            {
               
                Response.Write("Leave request approved for ID: " + leaveId);
            }
            else if (e.CommandName == "Reject")
            {
                
                Response.Write("Leave request rejected for ID: " + leaveId);
            }


        }
    }
}
