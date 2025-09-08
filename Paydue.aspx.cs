using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using gold;

public partial class paydue : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        ArrayList account = (ArrayList)Session["account"];
        DataTable accountDT=new DataTable();
        foreach(String accountNo in account)
        {
            DataTable accountDetails = new DataTable();
            accountDetails=SchemeDB.getSchemeDetails(accountNo);
            accountDetails.TableName = accountNo;
            accountDT.Merge(accountDetails);
        }
        
        AccountListRepeater.DataSource = accountDT.CreateDataReader();
        AccountListRepeater.DataBind();
        //Pay.Text = accountDetails.Rows[0][6].ToString();

        //if (Pay.Text.Equals("Pay"))
        //{
        //    Pay.Enabled=true;
        //}
        //Session["amount"] = accountDetails.Rows[0][2].ToString();
        //Session["paystatus"]=accountDetails.Rows[0][6].ToString();
    }


    protected void AccountListRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        System.Web.UI.WebControls.Label account = e.Item.FindControl("act") as System.Web.UI.WebControls.Label;
        if (e.CommandName.Equals("Ledger"))
        {
            Response.Redirect("Ledger.aspx?accountNo=" + account.Text);
        }

        if (e.CommandName.Equals("Pay"))
        {
            System.Web.UI.WebControls.Label amt = e.Item.FindControl("amt") as System.Web.UI.WebControls.Label;
            Session["amount"] = amt.Text;
            System.Web.UI.WebControls.Button status = e.Item.FindControl("Pay") as System.Web.UI.WebControls.Button;
            Session["paystatus"] = status.Text;
            Response.Redirect("OnlinePay.aspx?accountNo="+account.Text);
        }

        if (e.CommandName.Equals("Home"))
        {
            Response.Redirect("Home.aspx");

        }
        
    }
}