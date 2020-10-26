using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollSystem
{
    public partial class frmManageUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SecurityLevel"] != null)
            {
                if (Session["SecurityLevel"].ToString() == "U")
                {
                    Response.Redirect("frmLogin.aspx");
                }
            }
            else
            {
                Response.Redirect("frmLogin.aspx");
            }
            clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), "frmManageUsers");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (clsDataLayer.SaveUser(Server.MapPath("PayrollSystem_DB.accdb"),
            txtUserName.Text, txtPassword.Text, ddSecurityLevel.SelectedValue))
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
                lbMessage.Text = "User added";
                GridView1.DataBind();
            }

            else
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
                lbMessage.Text = "User added";
            }
        }
    }
}