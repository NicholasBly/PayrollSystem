using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollSystem
{
    public partial class frmViewPersonnel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SecurityLevel"] == null) // If security level is neither A nor U
            {
                Response.Redirect("frmLogin.aspx");
            }

            // declare local variable strSearch
            string strSearch = "";

            // CHeck whether accessed page does not have a null / empty string
            if (Session["txtSearch"] != null)
            {
                strSearch = Session["txtSearch"].ToString();
            }
            if (!Page.IsPostBack)
            {
                // if string is not null, search and display matching value from table
                if (strSearch != null)
                {
                    //Declare the Dataset
                    dsPersonnel myDataSet = new dsPersonnel();
                    //Fill the dataset with shat is returned from the method.
                    myDataSet = clsDataLayer.GetPersonnel(Server.MapPath("PayrollSystem_DB.accdb"), strSearch);
                    //Set the DataGrid to the DataSource based on the table
                    grdViewPersonnel.DataSource = myDataSet.Tables["tblPersonnel"];
                    //Bind the DataGrid
                    grdViewPersonnel.DataBind();
                }
                else
                {
                    //Declare the Dataset
                    dsPersonnel myDataSet = new dsPersonnel();
                    //Fill the dataset with shat is returned from the method.
                    myDataSet = clsDataLayer.GetPersonnel(Server.MapPath("PayrollSystem_DB.accdb"));
                    //Set the DataGrid to the DataSource based on the table
                    grdViewPersonnel.DataSource = myDataSet.Tables["tblPersonnel"];
                    //Bind the DataGrid
                    grdViewPersonnel.DataBind();
                }
            }
        }
    }
}