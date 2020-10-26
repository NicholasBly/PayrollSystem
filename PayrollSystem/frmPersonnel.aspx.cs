using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollSystem
{
    public partial class frmPersonnel : System.Web.UI.Page
    {
        bool validatedState;
        protected void DateChecker()
        {
            try
            {
                DateTime startDate = DateTime.Parse(Request["txtStartDate"]);
                DateTime endDate = DateTime.Parse(Request["txtEndDate"]);
                if (DateTime.Compare(startDate, endDate) > 0)
                {
                    txtStartDate.BackColor = System.Drawing.Color.Yellow;
                    txtEndDate.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text = lblError.Text + "\n\nThe end date must be a later date than the start date.";
                    //The Msg text will be displayed in lblError.Text after all the error messages are concatenated
                    validatedState = false;
                    //Boolean value - test each textbox to see if the data entered is valid, if not set validState=false. 
                    //If after testing each validation rule, the validatedState value is true, then submit to frmPersonnelVerified.aspx, if not, then display error message
                }
                else
                {
                    txtStartDate.BackColor = System.Drawing.Color.White;
                    txtEndDate.BackColor = System.Drawing.Color.White;
                    validatedState = true;
                }
            }
            catch(Exception ex)
            {
                //lblError.Text = ex.ToString();
                lblError.Text = "Please Enter a Valid Date in the Format mm/dd/yy";
                txtStartDate.BackColor = System.Drawing.Color.Yellow;
                txtEndDate.BackColor = System.Drawing.Color.Yellow;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SecurityLevel"] == null) // If security level is neither A nor U
            {
                Response.Redirect("frmLogin.aspx");
            }

            // Check security level
            if (Session["SecurityLevel"] == "A")
            {
                btnSubmit.Visible = true;
                //Submit button is visible
            }
            else
            {
                btnSubmit.Visible = false;
                //Submit button is not visible
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //reset backcolor to white before it changes to yellow after re-submit
            txtFirstName.BackColor = System.Drawing.Color.White;
            txtLastName.BackColor = System.Drawing.Color.White;
            txtPayRate.BackColor = System.Drawing.Color.White;
            txtStartDate.BackColor = System.Drawing.Color.White;
            txtEndDate.BackColor = System.Drawing.Color.White;
            DateChecker(); // check date
            if (validatedState) // if date is correct
            {
                if (Request["txtFirstName"].ToString().Trim() == "")
                {
                    txtFirstName.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text = "Please Complete the Highlighted Form.";
                }
                if (Request["txtLastName"].ToString().Trim() == "")
                {
                    txtLastName.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text = "Please Complete the Highlighted Form.";
                }
                if (Request["txtPayRate"].ToString().Trim() == "")
                {
                    txtPayRate.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text = "Please Complete the Highlighted Form.";
                }
                if (Request["txtStartDate"].ToString().Trim() == "")
                {
                    txtStartDate.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text = "Please Complete the Highlighted Form.";
                }
                if (Request["txtEndDate"].ToString().Trim() == "")
                {
                    txtEndDate.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text = "Please Complete the Highlighted Form.";
                }
                else
                {
                    Session["txtFirstName"] = txtFirstName.Text; // sets session values
                    Session["txtLastName"] = txtLastName.Text;
                    Session["txtPayRate"] = txtPayRate.Text;
                    Session["txtStartDate"] = txtStartDate.Text;
                    Session["txtEndDate"] = txtEndDate.Text;
                    validatedState = true; // validation is now true
                    Response.Redirect("frmPersonnelVerified.aspx");
                }
            }
        }

        protected void btnViewPersonnel_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmViewPersonnel.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}