<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AddRoyalties.aspx.vb" Inherits="AddRoyalties" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Royalties</title>
    <style type="text/css">
        .auto-style1 {
            width: 73px;
        }

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
        <li><a class="active" href="AddRoyalties.aspx">All Royalties</a></li>
        <li><a href="AddAuthor.aspx">Add Authors</a></li>
        <li><a href="AddPublisher.aspx">Add Publishers</a></li>
        <li><a href="LinkAuthPub.aspx">Link Authors & Publishers</a></li>
    </ul>
    <form id="form1" runat="server" style="text-align: center" >
        <h1>
            <u>All Royalites</u><br />
        </h1>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

        <%--<asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" Font-Size="X-Large">
            
        </asp:GridView>--%>
        <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" Font-Size="X-Large">
            <asp:TableRow>
                <asp:TableHeaderCell>&nbsp;&nbsp;&nbsp;&nbsp;AUTHOR (id)&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableHeaderCell>
                <asp:TableHeaderCell>&nbsp;&nbsp;&nbsp;&nbsp;PUBLISHER (id)&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableHeaderCell>
                <asp:TableHeaderCell>&nbsp;&nbsp;&nbsp;&nbsp;ROYALTY (%)&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableHeaderCell>
                <%--<asp:TableHeaderCell>&nbsp;&nbsp;&nbsp;&nbsp;UPDATE&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableHeaderCell>
                <asp:TableHeaderCell>&nbsp;&nbsp;&nbsp;&nbsp;DELETE&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableHeaderCell>--%>
            </asp:TableRow>
        </asp:Table>

        <p>
            <%--<asp:Button ID="Button1" runat="server" Style="margin-left: 0px" Text="Submit" Font-Size="X-Large" />--%>
        </p>
        <p>
            <asp:Label ID="greet" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
