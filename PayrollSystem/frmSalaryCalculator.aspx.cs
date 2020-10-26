using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollSystem
{
    public partial class frmSalaryCalculator : System.Web.UI.Page
    {
        double annualHours, payRate, totalSalary;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SecurityLevel"] == null) // If security level is neither A nor U
            {
                Response.Redirect("frmLogin.aspx");
            }
        }

        protected void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            if (txtAnnualHours.Text != "" && txtPayRate.Text != "")
            {
                annualHours = Convert.ToDouble(txtAnnualHours.Text);
                payRate = Convert.ToDouble(txtPayRate.Text);
                totalSalary = (annualHours * payRate);
                lblAnnualSalary.Text = "$ " + Convert.ToString(totalSalary);
            }
            else
            {
                btnCalculateSalary.Text = "Error, try again.";
                System.Threading.Thread.Sleep(1300);
                btnCalculateSalary.Text = "Calculate Salary";
            }
        }
    }
}