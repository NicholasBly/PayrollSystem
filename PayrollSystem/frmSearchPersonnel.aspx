<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSearchPersonnel.aspx.cs" Inherits="PayrollSystem.frmSearchPersonnel" %>

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
        <br />
        <asp:Label ID="Label1" runat="server" Text="Search for employee by last name:"></asp:Label>
        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
    </form>
</body>
</html>
