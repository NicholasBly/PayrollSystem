<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmManageUsers.aspx.cs" Inherits="PayrollSystem.frmManageUsers" %>

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
        <asp:Label ID="Label1" runat="server" Text="Manage Users"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
&nbsp;<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        Password
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        Security Level
        <asp:DropDownList ID="ddSecurityLevel" runat="server">
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>U</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add User" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Current Users:"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="UserID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" ReadOnly="True" SortExpression="UserID" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword" />
                <asp:BoundField DataField="SecurityLevel" HeaderText="SecurityLevel" SortExpression="SecurityLevel" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PayrollSystem_DBConnectionString %>" DeleteCommand="DELETE FROM [tblUserLogin] WHERE [UserID] = ?" InsertCommand="INSERT INTO [tblUserLogin] ([UserID], [UserName], [UserPassword], [SecurityLevel]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:PayrollSystem_DBConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [tblUserLogin]" UpdateCommand="UPDATE [tblUserLogin] SET [UserName] = ?, [UserPassword] = ?, [SecurityLevel] = ? WHERE [UserID] = ?">
            <DeleteParameters>
                <asp:Parameter Name="UserID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="UserID" Type="Int32" />
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="UserPassword" Type="String" />
                <asp:Parameter Name="SecurityLevel" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="UserPassword" Type="String" />
                <asp:Parameter Name="SecurityLevel" Type="String" />
                <asp:Parameter Name="UserID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:Label ID="lbMessage" runat="server"></asp:Label>
        <br />
    </form>
</body>
</html>
