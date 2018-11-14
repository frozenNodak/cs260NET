<%@ Page Language="VB" AutoEventWireup="false" CodeFile="LinkAuthPub.aspx.vb" Inherits="LinkAuthPub" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 212px">
    <form id="form1" runat="server" style="text-align:center; background-color:cadetblue">
        <h1>
            Link a Author and Publisher<br />
        </h1>
        Author: 
        <asp:DropDownList ID="ddl_Authors" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="AID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Author %>" ProviderName="<%$ ConnectionStrings:Author.ProviderName %>" SelectCommand="SELECT [Name], [AID] FROM [Authors]"></asp:SqlDataSource>
        <br />
        Publisher:&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddl_Publishers" runat="server" DataSourceID="SqlDataSource3" DataTextField="Name" DataValueField="PID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Publisher %>" ProviderName="<%$ ConnectionStrings:Publisher.ProviderName %>" SelectCommand="SELECT [Name], [PID] FROM [Publishers]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Author %>" ProviderName="<%$ ConnectionStrings:Author.ProviderName %>" SelectCommand="SELECT [Name] FROM [Publishers]"></asp:SqlDataSource>
        <br />
        Add Royalties (optional):
        <asp:TextBox ID="tb_Royalties" runat="server"></asp:TextBox>
&nbsp;%<p>
            <asp:Button ID="Button1" runat="server" style="margin-left: 0px" Text="Submit" />
        </p>
        <p>
            <asp:Label ID="greet" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
