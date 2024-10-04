<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="LOGIN.AdminHome" %>

<!DOCTYPE html>

  <html xmlns="http://www.w3.org/1999/xhtml">
      <head runat="server">
    <title>Leave Requests Table</title>


    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 20px;
        }
        table {
            width: 100%;
            border-collapse: collapse;
            margin: 20px 0;
            background: white;
        }
        h2 {
             color: #4CAF50;
             margin-bottom: 20px
            
        }
        th, td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }
        th {
            background-color: #f2f2f2;
        }
        tr:hover {
            background-color: #f1f1f1;
        }
    </style>

 </head>

<body>
    <div class="container">
        <h2>Leave Requests</h2>
        <table>
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Leave Type</th>
                    <th>Start Date</th>
                    <th>End Date</th>
                    <th>Reason</th>
                    <th>Status</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>2</td>
                    <td>Kumar</td>
                    <td>sick</td>
                    <td>18-09-2002</td>
                    <td>23-09-2003</td>
                    <td>sick</td>
                    <td>Approved</td>
                </tr>
                <tr>
                    <td>23</td>
                    <td>Murugaesan</td>
                    <td>Permission</td>
                    <td>18-09-2002</td>
                    <td>23-09-2003</td>
                    <td>permission</td>
                    <td>Rejected</td>
                </tr>
                <tr>
                    <td>22</td>
                    <td>Rajan</td>
                    <td>Casual</td>
                    <td>18-09-2002</td>
                    <td>23-09-2003</td>
                    <td>Casual</td>
                    <td>Approved</td>
                </tr>
            </tbody>
        </table>
    </div>
</body>
</html>

    
