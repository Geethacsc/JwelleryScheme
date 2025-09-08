<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        th,td
        {
            text-align:left;
        }
        .auto-style1 {
            height: 39px;
        }
    </style>
</head>
<body>
    <center><h2>Login to Your Account</h2>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="logerror" runat="server" ForeColor="Red" Text="Invalid Credentials!" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <th>User ID :</th>
                <td>
                    <input id="userId" runat="server"  type="text" />
                </td>
            </tr>
            <tr>
                <th>Password :</th>
                <td>
                    <input id="pwd" runat="server" type="password" />
                </td>
            </tr>
            <br />
            <tr>
                <td>
                    <asp:Button ID="log" runat="server" OnClick="Login_Click" Text="Login" />
                </td>
            </tr>
            <br/>
            <tr>
                <td>don't have an account?</td>
                <td>
                    <asp:Button ID="register" runat="server" OnClick="Register_Click" Text="Register" />
                </td>
            </tr>
        </table>
    </form>
    </center>
</body>
</html>
