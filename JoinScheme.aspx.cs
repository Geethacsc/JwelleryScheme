using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JoinScheme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        scheme.Text = Session["join_scheme"].ToString();
    }

    protected void join_Click(object sender, EventArgs e)
    {
        ArrayList schemeData = new ArrayList();
        schemeData.Add(amt.Value);
        schemeData.Add(branch.Text);
        schemeData.Add(name.Value);
        schemeData.Add(mobile.Value);
        schemeData.Add(email.Value);
        schemeData.Add(addr.Value);

        Session["scheme_data"] = schemeData;
        Response.Redirect("OnlinePay.aspx");
    }




}