using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gold;

public partial class Schemes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SchemeListRepeater.DataSource = SchemeDB.getSchemeList();
        SchemeListRepeater.DataBind();
    }

    protected void SchemeList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName.Equals("Join"))
        {
            Label schemeName = e.Item.FindControl("scheme") as Label;
            Session["join_scheme"] = schemeName.Text;
            Response.Redirect("JoinScheme.aspx");
        }
    }

}