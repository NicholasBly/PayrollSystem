using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollSystem
{
    public partial class frmMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SecurityLevel"] == null)
            {
                Response.Redirect("frmLogin.aspx");
            }

            if (Session["SecurityLevel"] == "U")
            {
                imgbtnNewEmployee.Visible = false;
                linkbtnNewEmployee.Visible = false;
                imgbtnViewUserActivity.Visible = false;
                linkbtnViewUserActivity.Visible = false;
                imgbtnEditEmployees.Visible = false;
                linkbtnEditEmployees.Visible = false;
                imgbtnManageUsers.Visible = false;
                linkbtnManageUsers.Visible = false;
            }
            clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), "frmPersonnel");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {

        }
    }
}