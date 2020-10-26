using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollSystem
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            // create dsUser object dsUserLogin
            dsUser dsUserLogin;
            // create SecurityLevel string
            string SecurityLevel;
            // Verify login info
            dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.accdb"),
            Login1.UserName, Login1.Password);
            // fail auth where logincount is less than 1
            if (dsUserLogin.tblUserLogin.Count < 1)
            {
                e.Authenticated = false;

                // Send incorrect login information after failed attempt
                if (clsBusinessLayer.SendEmail("Nicholas319@verizon.net",
                "testmail@pay-mon.com", "", "", "Login Incorrect",
                "The login failed for UserName: " + Login1.UserName +
                " Password: " + Login1.Password))
                {
                    Login1.FailureText = Login1.FailureText +
                    " Your incorrect login information was sent to testmail@pay-mon.com";
                }

                return;
            }
            // set Security level string as security level from user login table
            SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();
            // security level switch to give security level status of user
            switch (SecurityLevel)
            {
                case "A":
                    // Add your comments here
                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                    Session["SecurityLevel"] = "A";
                    break;
                case "U":
                    // Add your comments here
                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                    Session["SecurityLevel"] = "U";
                    break;
                default:
                    e.Authenticated = false;
                    break;
            }
        }
    }
}