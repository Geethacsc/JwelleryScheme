using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using gold;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void reg_Click(object sender, EventArgs e)
    {
        string role = selectRole.SelectedItem.Value;
        string uId=userId.Value.Trim();
        string password=pwd.Value.Trim();
        string cpassword=cpwd.Value.Trim();

        if (uId.Length==0)
        {
            usrErr.Text = "Enter User ID";
            usrErr.Visible = true;
            return;
        }
        else if (uId.Length <12 || uId.Length>20)
        {
            usrErr.Text = "User Id length should be between 12 to 20";
            usrErr.Visible = true;
            return;
        }
        else if (password.Length==0)
        {
            pwdErr.Text = "Enter Password";
            pwdErr.Visible = true;
            return;
        }
        else if (password.Length < 12 || password.Length > 20)
        {
            usrErr.Visible=false;
            pwdErr.Text = "Password length should be between 12 to 20";
            pwdErr.Visible = true;
            return;
        }
        else if (cpassword.Length==0)
        {
            pwdErr.Visible = false;
            cpwdErr.Text = "Confirm Password";
            cpwdErr.Visible = true;
            return;
        }

        else if (!cpassword.Equals(password))
        {
            cpwdErr.Text = "Confirm Password Should be Same as Password";
            cpwdErr.Visible = true;
            return;
        }

        else if (role.Equals(""))
        {
            roleErr.Text = "Select the User Role";
            roleErr.Visible = true;
            return;
        }
        else
        {
            usrErr.Visible = false;
            pwdErr.Visible = false;
            cpwd.Visible = false;
            roleErr.Visible = false;

            try
            {
                int count = SchemeDB.register(uId, cpassword, role);
                if (count > 0)
                {
                    MessageBox.Show("User Registered Successfully");
                    Response.Redirect("Login.aspx");
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
    protected void log_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}