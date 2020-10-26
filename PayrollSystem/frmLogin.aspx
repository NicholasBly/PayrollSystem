<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="PayrollSystem.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            width: 462px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
    <div>
    
    </div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" />
            <div class="auto-style1">
                <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/frmMain.aspx" OnAuthenticate="Login1_Authenticate" TitleText="Please enter your UserName and Password in order to log in to the system.">
                </asp:Login>
            </div>
        </div>
    </form>
</body>
</html>
