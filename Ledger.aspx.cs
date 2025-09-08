using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using gold;

public partial class Ledger : System.Web.UI.Page
{

    public DataTable transTb;
    public List<TransactionDetails> transList;
    public DataTable accountDT = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        String accountNo = Request.QueryString["accountNo"];
        if (accountNo != null)
        {
            DataTable accountDetails = SchemeDB.getAccountDetails(accountNo);
            accountDT.Merge(accountDetails);
        }
        else
        {
            ArrayList account = (ArrayList)Session["account"];
            foreach (String act in account)
            {
                DataTable accountDetails = SchemeDB.getAccountDetails(act);
                accountDT.Merge(accountDetails);
            }
        }
        LedgerListRepeater.DataSource = accountDT.CreateDataReader();
        LedgerListRepeater.DataBind();

        //name.Text = accountDetails.Rows[0][0].ToString();
        //mobile.Text=accountDetails.Rows[0][1].ToString();
        //accountId.Text = accountDetails.Rows[0][2].ToString();
        //inst.Text = accountDetails.Rows[0][3].ToString();
        //totAmt.Text = accountDetails.Rows[0][4].ToString();
        //totWgt.Text = accountDetails.Rows[0][5].ToString();
        //scheme.Text = accountDetails.Rows[0][6].ToString();
    }

    protected void transactionDetails_Click(object sender, EventArgs e)
    {   
    }

    protected void LedgerListRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName.Equals("Trans"))
        {
            Repeater transRepeater = e.Item.FindControl("transRepeater") as Repeater;
            System.Web.UI.WebControls.Label account = e.Item.FindControl("accountId") as System.Web.UI.WebControls.Label;

            transRepeater.DataSource = SchemeDB.GetTransactionDetails(account.Text);
            transRepeater.DataBind();
        }

       
    }
}