<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMain.aspx.cs" Inherits="PayrollSystem.frmMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" />
        <asp:Panel ID="Panel1" runat="server" Height="449px" Width="500px">
            <asp:ImageButton ID="imgbtnCalculator" runat="server" Height="60px" ImageUrl="~/Images/kisspng-symbol-green-logo-calculator-5ab08a13351539.6452699315215191232174.png" PostBackUrl="~/frmSalaryCalculator.aspx" Width="65px" />
            <asp:LinkButton ID="linkbtnCalculator" runat="server" PostBackUrl="~/frmSalaryCalculator.aspx">Annual Salary Calculator</asp:LinkButton>
            <br />
            <asp:ImageButton ID="imgbtnNewEmployee" runat="server" Height="56px" ImageUrl="~/Images/hiring-1-300x300.png" PostBackUrl="~/frmPersonnel.aspx" Width="59px" />
            <asp:LinkButton ID="linkbtnNewEmployee" runat="server" PostBackUrl="~/frmPersonnel.aspx" OnClick="LinkButton2_Click">Add New Employee</asp:LinkButton>
            <br />
            <asp:ImageButton ID="imgbtnViewUserActivity" runat="server" Height="56px" ImageUrl="~/Images/male-user-shadow_318-34042.jpg" PostBackUrl="~/frmPersonnel.aspx" Width="59px" />
            <asp:LinkButton ID="linkbtnViewUserActivity" runat="server" PostBackUrl="~/frmUserActivity.aspx">User Activity</asp:LinkButton>
            <br />
            <asp:ImageButton ID="imgbtnViewPersonnel" runat="server" Height="56px" ImageUrl="~/Images/person1.png" PostBackUrl="~/frmPersonnel.aspx" Width="59px" />
            <asp:LinkButton ID="linkbtnViewPersonnel" runat="server" OnClick="LinkButton4_Click" PostBackUrl="~/frmViewPersonnel.aspx">View Personnel</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="imgbtnSearch" runat="server" Height="53px" ImageUrl="~/Images/Feedbin-Icon-home-search.svg.png" Width="51px" />
            <asp:LinkButton ID="linkbtnSearch" runat="server" PostBackUrl="~/frmSearchPersonnel.aspx">Search Personnel</asp:LinkButton>
            <br />
            <asp:ImageButton ID="imgbtnEditEmployees" runat="server" Height="53px" ImageUrl="~/Images/hiring-1-300x300.png" Width="51px" />
            <asp:LinkButton ID="linkbtnEditEmployees" runat="server" PostBackUrl="~/frmEditPersonnel.aspx">Edit Employees</asp:LinkButton>
            <br />
            <asp:ImageButton ID="imgbtnManageUsers" runat="server" Height="53px" ImageUrl="~/Images/hiring-1-300x300.png" Width="51px" />
            <asp:LinkButton ID="linkbtnManageUsers" runat="server" PostBackUrl="~/frmManageUsers.aspx">Manage Users</asp:LinkButton>
            <br />
            <br />
        </asp:Panel>
    </form>
</body>
</html>
