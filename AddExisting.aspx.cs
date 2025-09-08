using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using gold;

public partial class AddExisting : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String accountNo=SchemeDB.addExisting(groupCode.Value, regno.Value);
        ArrayList account = (ArrayList)Session["account"];

        if (account == null)
        {
            account = new ArrayList();
        }
        if (accountNo != null)
        {
            account.Add(accountNo);
            Session["account"] = account;
            Response.Redirect("home.aspx");
        }
        MessageBox.Show(account.ToArray().ToString());
    }
}