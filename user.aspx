<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="LOGIN.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Login</title>


     <style>
            
              body {
                   font-family: Arial, sans-serif;
                    background-color: #f9f9f9;
                }

              h1 {
                     color: #ff6a00;
                     margin-bottom: 20px;
                }

              form {
                      width: 300px;
                      margin: 40px auto;
                      padding: 30px;
                      border: 1px solid #ccc;
                      border-radius: 20px;
                      box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
               }
           

              .nav ul {
                    list-style: none;
                      margin: 0;
                    padding: 0;
                   display: flex;
               }

              .nav li {
                    margin-right: 20px;
               }

              .nav a {
                    color: #000;
                    text-decoration: none;
               }

              .nav a:hover {
                    color: #ccc;
                }
 
              label {
                    display: block;
                    margin-bottom: 10px;
                }

              input[type="text"], input[type="password"] {
                      width: 100%;
                      height: 30px;
                      padding: 10px;
                      margin-bottom: 20px;
                      border: 1px solid #ccc;
                      border-radius: 5px;
               }

              input[type="submit"] {
                       border-style: none;
               border-color: inherit;
               border-width: medium;
               width: 100%;
                       height: 30px;
                       padding: 10px;
                      background-color: #4CAF50;
                      color: #fff;
                      border-radius: 5px;
                      cursor: pointer;
               margin-left: 0px;
           }

              input[type="submit"]:hover {
                       background-color: #3e8e41;
               }

              .error {
                       color: #ff0000;
                       font-size: 12px;
                       margin-bottom: 10px;
                }

              .success {
                       color: #3e8e41;
                       font-size: 12px;
                       margin-bottom: 10px;
               }
             
          </style>
    </head>

<body>
    <form id="form1" runat="server">
        <h2>Welcome User!</h2>
    <p>This is your user dashboard.</p>
   
        <asp:Label ID="lblUsername" runat="server" Text="Username:" />
            <asp:TextBox ID="txtUsername" runat="server"/>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password:" />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" />
             <a href="LOGIN.aspx">Logout</a>

        </form>>
 </body>
</html>
