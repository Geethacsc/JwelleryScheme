using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gold;

public partial class login : System.Web.UI.Page
{

    public static string CS = "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login_Click(object sender, EventArgs e)
    {
        try
        {
            String user = SchemeDB.login(userId.Value, pwd.Value);
            if (!user.Equals(""))
            {
                Session["user_id"] = user;
                Response.Redirect("home.aspx");
            }
        }
        catch (Exception ex)
        {
            logerror.Visible = true;
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Register_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}