<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPersonnelVerified.aspx.cs" Inherits="PayrollSystem.frmPersonnelVerified" %>

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
        <asp:Panel ID="Panel1" runat="server" Height="250px" Width="650px">
            <asp:Label ID="Label1" runat="server" Text="Information to Submit"></asp:Label>
            <asp:TextBox ID="txtVerifiedInfo" runat="server" Height="80px" TextMode="MultiLine" Width="400px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnViewPersonnel" runat="server" OnClick="btnViewPersonnel_Click" Text="View Personnel" />
        </asp:Panel>
    </form>
</body>
</html>
