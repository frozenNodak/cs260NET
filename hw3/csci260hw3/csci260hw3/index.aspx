<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="csci260hw3.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="home" runat="server">
        <div style="margin:0 auto 0 auto; width:750px; height: 499px;"> 
            <asp:Panel ID="BookstoreTitle" runat="server" BackColor="#3399FF" BorderColor="Black" BorderStyle="Inset" BorderWidth="3px" Height="25px" HorizontalAlign="Center">
                David&#39;s Bookstore</asp:Panel>
        
            <asp:Menu ID="Menu1" runat="server" BackColor="#3399FF" BorderStyle="Solid" OnMenuItemClick="Menu1_MenuItemClick" Orientation="Horizontal" StaticMenuItemStyle-HorizontalPadding = "30" Width="744px" ForeColor="Black">
                <Items>
                    <asp:MenuItem Text="Home" Value="Home" NavigateUrl="~/index.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Add Publisher" Value="Add Publisher" NavigateUrl="~/AddPublisher.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Add Author" Value="Add Author"></asp:MenuItem>
                    <asp:MenuItem Text="Add Royalties" Value="Add Royalties"></asp:MenuItem>
                    <asp:MenuItem Text="Search " Value="Search "></asp:MenuItem>
                </Items>
                <StaticMenuItemStyle HorizontalPadding="20px" />
            </asp:Menu>
            <br />
        </div>
    </form>
</body>
</html>
