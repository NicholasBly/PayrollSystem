<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSalaryCalculator.aspx.cs" Inherits="PayrollSystem.frmSalaryCalculator" %>

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
        Annual Hours:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAnnualHours" runat="server"></asp:TextBox>
        <p>
            Pay Rate&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnCalculateSalary" runat="server" OnClick="btnCalculateSalary_Click" Text="Calculate Salary" />
        <p>
            <asp:Label ID="lblAnnualSalary" runat="server" Text="$"></asp:Label>
        </p>
    </form>
</body>
</html>
