<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Paydue.aspx.cs" Inherits="paydue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
        <style>
            table
            {
                border-spacing:5px;
                table-layout: fixed;
                width:35%;
            }
            th{
                font-size:12px;
                text-align:left;
            }
            td
            {
               text-align:left;
            }
    </style>
    </head>
    <body>
        <h2>Account Details</h2>
        <div style="margin-left: 450px">
            <form id="form1" runat="server">
                <asp:Repeater ID="AccountListRepeater" runat="server" OnItemCommand="AccountListRepeater_ItemCommand">
                    <ItemTemplate>
                        <h3><asp:Label ID="scheme" runat="server" Text=<%#DataBinder.Eval(Container,"DataItem.scheme")%>></asp:Label></h3>
                        <table>
                            <tr>
                                <th>Name</th>
                                <th>Account</th>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="name" runat="server"  Text=<%#DataBinder.Eval(Container,"DataItem.name")%> ></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="act" runat="server"  Text=<%#DataBinder.Eval(Container,"DataItem.account")%>></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <th>Amount</th>
                                <th>Weight</th>
                                <th>Paid Inst</th>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="amt" runat="server"  Text=<%#DataBinder.Eval(Container,"DataItem.amount")%>></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="weight" runat="server"  Text=<%#DataBinder.Eval(Container,"DataItem.weight")%>></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="paidIns" runat="server"  Text=<%#DataBinder.Eval(Container,"DataItem.paidIns")%>></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="Ledger" runat="server" Text="Ledger" CommandName="Ledger" UseSubmitBehavior="false" />
                                </td>
                                <td>
                                    <asp:Button ID="Pay" runat="server" Text=<%#DataBinder.Eval(Container,"DataItem.status")%> Enabled='<%#DataBinder.Eval(Container,"DataItem.status").ToString().Equals("Pay")%>' CommandName="Pay" UseSubmitBehavior="false"/>
                                </td>
                                <td>
                                    <asp:Button ID="home" runat="server" Text="Home" CommandName="Home" UseSubmitBehavior="false"  />
                                </td>
                            </tr>
                        </table>
                        <br />
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# string.Format("~/OnlineTransactions.aspx?accountNo={0}",
                HttpUtility.UrlEncode(DataBinder.Eval(Container,"DataItem.account").ToString()) ) %>' >Online Transaction Details</asp:HyperLink>
                    </ItemTemplate>
                </asp:Repeater>
            </form>

        </div>
    </body>
</html>
