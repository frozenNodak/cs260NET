<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PublisherInfo.aspx.vb" Inherits="PublisherInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Royalties</title>
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
        <li><a href="LinkAuthPub.aspx">Link Authors & Publishers</a></li>
    </ul>
    <form id="form1" runat="server" style="text-align: center; font-size:x-large">
        <h1>
            <u>Publishers Information</u><br />
        </h1>
        <asp:Button ID="Button1" runat="server" Text="Delete Publisher" /></br>
        Name:<asp:Label ID="Name" runat="server" Text=""></asp:Label>&nbsp;
        ID:<asp:Label ID="ID" runat="server" Text=""></asp:Label>&nbsp; City:<asp:Label ID="City" runat="server" Text=""></asp:Label>&nbsp;
        <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" Font-Size="X-Large">
            <asp:TableRow>
                <asp:TableHeaderCell>&nbsp;&nbsp;&nbsp;&nbsp;AUTHOR&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableHeaderCell>
                <asp:TableHeaderCell>&nbsp;&nbsp;&nbsp;&nbsp;ID&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableHeaderCell>
                <asp:TableHeaderCell>&nbsp;&nbsp;&nbsp;&nbsp;ROYALTY&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableHeaderCell>
                <asp:TableHeaderCell>&nbsp;&nbsp;&nbsp;&nbsp;DELETE&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableHeaderCell>
            </asp:TableRow>
        </asp:Table>

        <p>
            <asp:Button ID="Submit" runat="server" Text="Submit" />
        </p>
        <p>
            <asp:Label ID="greet" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>

