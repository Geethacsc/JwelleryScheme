using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using gold;

public partial class OnlineTransactions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String accountNo = Request.QueryString["accountNo"];
        OTransRepeater.DataSource = SchemeDB.getOnlineTransactions(accountNo);
        OTransRepeater.DataBind();
    }
}