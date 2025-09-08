using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using gold;

public partial class OnlinePay : System.Web.UI.Page
{
    static string schemeName,name, schemeAdr, schemeMob, schemeEmail, schemeBranch;
    ArrayList schemeData = null;


    protected void Page_Load(object sender, EventArgs e)
    {
        schemeData = (ArrayList)Session["scheme_data"];
        schemeName = (string)Session["join_scheme"];

        if (schemeName!=null)
        {
            amt.Text = schemeData[0].ToString();
            Pay.Text = "Pay";
            Pay.Enabled = true;
        }
        //if (!IsPostBack)
        //{
        //    if (Session["join_scheme"]!=null)
        //    {
        //        amt.Text = Request.Form["amt"].ToString();
        //        Pay.Text = "Pay";
        //        Pay.Enabled = true;

        //        name = Request.Form["name"].ToString();

        //        DropDownList txtBranch = (DropDownList)(PreviousPage.FindControl("branch"));
        //        schemeBranch = txtBranch.SelectedItem.Value;


        //        schemeMob = Request.Form["mobile"].ToString();

        //        schemeEmail = Request.Form["email"].ToString();

        //        schemeAdr = Request.Form["addr"].ToString();
        //        selectTrans.SelectedIndex = 1;
        //        //Session["join_scheme"] = "";
        //    }
        else
            {
                amt.Text = Session["amount"].ToString();
                Pay.Text = Session["paystatus"].ToString();

                if (Pay.Text.Equals("Pay"))
                {
                    Pay.Enabled = true;
                }
            }
        //}
        
            
    }

    protected void Pay_Click(object sender, EventArgs e)
    {
        ArrayList account;
        if (schemeName!=null)
        {
            string typeofTrans=selectTrans.SelectedItem.Value.ToString();
            int amount = Convert.ToInt32(amt.Text);
            schemeBranch = schemeData[1].ToString();
            name=schemeData[2].ToString();
            schemeMob= schemeData[3].ToString();
            schemeEmail=schemeData[4].ToString();
            schemeAdr= schemeData[5].ToString();

            String accountNo = SchemeDB.joinScheme(schemeName, amount, schemeBranch, name, schemeMob, schemeEmail, schemeAdr, typeofTrans);

            account = (ArrayList)Session["account"];

            if (account == null)
            {
                account = new ArrayList();
            }
            if (accountNo!=null)
            {
                account.Add(accountNo);
                Session["account"] = account;
                System.Windows.Forms.MessageBox.Show("Joined Scheme Successfully");
            }
            Session["join_scheme"] = null;
        }
        else
        {
            account = (ArrayList)Session["account"];
            String transType = selectTrans.SelectedItem.Value;
            String accountNo= Request.QueryString["accountNo"];
            String res = SchemeDB.payInstallment(transType, amt.Text, accountNo);
            System.Windows.Forms.MessageBox.Show("Installment Paid Successfully");
        }
        Response.Redirect("Paydue.aspx");
    }



    protected void selectTransChanged(object sender, EventArgs e)
    {
        if (selectTrans.SelectedItem.Value.Equals("UPI"))
        {
            Label1.Visible = true;
            upi.Visible=true;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            debit.Visible = false;
            cvc.Visible = false;
            pin.Visible = false;
        }

        else if (selectTrans.SelectedItem.Value.Equals("DEBIT")){
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            debit.Visible = true;
            cvc.Visible = true;
            pin.Visible = true;
            Label1.Visible = false;
            upi.Visible = false;
        }
           
        
    }

    
}