<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPersonnel.aspx.cs" Inherits="PayrollSystem.frmPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" OnClick="ImageButton1_Click" PostBackUrl="~/frmMain.aspx" />
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="250px" HorizontalAlign="Left" Width="554px">
            First Name&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFirstName" runat="server" width="128px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First Name cannot be blank." ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            Last Name&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtLastName" runat="server" width="128px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last Name cannot be blank." ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            Pay Rate&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPayRate" runat="server" width="128px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPayRate" ErrorMessage="Pay Rate cannot be blank." ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            Start Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStartDate" runat="server" width="128px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtStartDate" ErrorMessage="Start Date must be in mm/dd/yyyy Format." ForeColor="Red" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
            <br />
            End Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEndDate" runat="server" OnTextChanged="TextBox5_TextChanged" width="128px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEndDate" ErrorMessage="End Date must be in mm/dd/yyyy Format." ForeColor="Red" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
