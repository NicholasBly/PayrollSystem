using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollSystem
{
    public partial class frmSearchPersonnel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SecurityLevel"] == null) // If security level is neither A nor U
            {
                Response.Redirect("frmLogin.aspx");
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Session["txtSearch"] = txtSearch.Text;
            Response.Redirect("frmViewPersonnel.aspx");
        }
    }
}