<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUserActivity.aspx.cs" Inherits="PayrollSystem.frmUserActivity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/frmMain.aspx" />
        <asp:Panel ID="Panel1" runat="server">
            User Activity<br />
            <asp:GridView ID="grdUserActivity" runat="server">
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
