<%@ Page Language="VB" AutoEventWireup="false" CodeFile="LinkAuthPub.aspx.vb" Inherits="LinkAuthPub" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Link Authors and Publishers</title>
    <style type="text/css">
        
        ul {
            list-style-type: none;
            margin: 0;
            padding: 0;
            overflow: hidden;
            background-color: #333;
        }

        li {
            float: left;
        }

        li a {
                display: block;
                color: white;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
        }

        li a:hover {
            background-color: #111;
        }
    </style>
</head>
<body style="height: 212px; background-color: cadetblue; text-align: center">
    <h1 style="font:bold 60px arial">
        <u>DAVID'S BOOKSTORE</u><br />
    </h1>
    <ul>
        <li><a href="Home.aspx">Home</a></li>
        <li><a href="AddRoyalties.aspx">All Royalties</a></li>
        <li><a href="AddAuthor.aspx">Add Authors</a></li>
        <li><a href="AddPublisher.aspx">Add Publishers</a></li>
        <li><a  class="active" href="LinkAuthPub.aspx">Link Authors & Publishers</a></li>
    </ul>
    <form id="form1" runat="server" style="text-align:center; background-color:cadetblue" font-size="X-Large">
        <h1>
            Link a Author and Publisher<br />
        </h1>
        Author: 
        <asp:DropDownList ID="ddl_Authors" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="AID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT [Name], [AID] FROM [Authors]"></asp:SqlDataSource>
        <br />
        Publisher:&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddl_Publishers" runat="server" DataSourceID="SqlDataSource3" DataTextField="Name" DataValueField="PID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT [Name], [PID] FROM [Publishers]"></asp:SqlDataSource>
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
