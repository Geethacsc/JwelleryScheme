<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JoinScheme.aspx.cs" Inherits="JoinScheme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table
        {
            border-spacing:5px;
            padding:10px;
            width:50%;
        }
        td,th
        {
           text-align:left;
        }
        .auto-style1 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <asp:Label ID="scheme" runat="server" Text=""></asp:Label><br />
            <table>
                <tr>
                    <th>Name</th>
                    <td><input id="name" runat="server" type="text" /></td>
                </tr>
                <tr>
                    <th>Select Branch</th>
                    <td>
                        <asp:Dropdownlist id="branch" runat="server" AutoPostBack="true">
                            <asp:ListItem Value="">Select</asp:ListItem>
                            <asp:ListItem Value="REDHILLS">REDHILLS</asp:ListItem>
                            <asp:ListItem Value="PERAMBUR">PERAMBUR</asp:ListItem>
                        </asp:Dropdownlist>
                    </td>
                </tr>
                <tr>
                    <th>Enter Amount</th>
                    <td class="auto-style1"><input id="amt" runat="server" type="number" /></td>
                </tr>
                <tr>
                    <th>Mobile</th>
                    <td><input id="mobile" runat="server" type="number" /></td>               
                </tr>
                <tr>
                    <th>Email</th>
                    <td>
                        <input id="email" runat="server" type="email" />
                    </td>
                </tr>
                <tr>
                    <th>Address</th>
                    <td>
                        <input id="addr" runat="server" type="text" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="join" runat="server" Text="Next" OnClick="join_Click" />
                    </td>
                </tr>
            </table>
        </center>
    </form>
</body>
</html>
