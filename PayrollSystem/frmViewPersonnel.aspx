<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmViewPersonnel.aspx.cs" Inherits="PayrollSystem.frmViewPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/frmMain.aspx" />
    
    </div>
        <asp:GridView ID="grdViewPersonnel" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
