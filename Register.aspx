<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

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
        #reg {
            height: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <h2>REGISTER USER</h2>
            <table>
                <tr>
                    <th>Enter User ID :</th>
                    <td>
                        <input id="userId" runat="server" type="text" />
                    </td>
                    <td>
                        <asp:Label ID="usrErr" ForeColor="Red" runat="server" Text="" Visible="false" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <th>Set Password :</th>
                    <td>
                        <input id="pwd" runat="server" type="password" />
                    </td>
                    <td>
                        <asp:Label ID="pwdErr" ForeColor="Red" runat="server" Text="" Visible="false"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <th>Confirm Password :</th>
                    <td>
                        <input id="cpwd" runat="server" type="password" />
                    </td>
                    <td>
                        <asp:Label ID="cpwdErr" ForeColor="Red" runat="server" Text="" Visible="false"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <th>Role :</th>
                    <td>
                        <asp:DropDownList ID="selectRole" runat="server">
                            <asp:ListItem Value="">Select</asp:ListItem>
                            <asp:ListItem Value="ADMIN">Admin</asp:ListItem>
                            <asp:ListItem Value="USER">User</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label ID="roleErr" ForeColor="Red" runat="server" Text="" Visible="false"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="reg" runat="server" Text="Register" OnClick="reg_Click"/>
                    </td>
                </tr>
                <tr>
                    <td>Already have a account?</td>
                    <td>
                        <asp:Button ID="log" runat="server" Text="Login" OnClick="log_Click"/>
                    </td>
                </tr>
            </table>
        </center>
    </form>
</body>
</html>
