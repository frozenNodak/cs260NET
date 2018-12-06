<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AuthorInfo.aspx.vb" Inherits="AuthorInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Authors Information</title>
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
    <ul id="adminTab" runat="server">
        <<li><a href="AdminHome.aspx">Home</a></li>
        <li><a href="AddAuthor.aspx">Add Authors</a></li>
        <li><a href="AddBook.aspx">Add Books</a></li>
        <li><a href="ListOfAll.aspx">List Everything</a></li>
        <li><a href="SearchBooks.aspx">Search</a></li>
        <li><a href="Login.aspx">Logout</a></li>
    </ul>
    <ul id="custTab" runat="server">
        <li><a href="Home.aspx">Home</a></li>
        <li><a href="SearchBooks.aspx">Search Books</a></li>
        <li><a href="CustInfo.aspx">My Account</a></li>
        <li><a href="Login.aspx">Logout</a></li>
    </ul>
    <form id="form1" runat="server" style="text-align: center; font-size:x-large">
        <h1>
            <u>Authors Information</u><br />
        </h1>
        Name:<asp:Label ID="Name" runat="server" Text="" Font-Size="X-Large"></asp:Label>&nbsp;
        ID:<asp:Label ID="ID" runat="server" Text="" Font-Size="X-Large"></asp:Label>&nbsp;
        <asp:Table ID="tb_books" runat="server" HorizontalAlign="Center" Font-Size="X-Large">
            <asp:TableRow>
                <asp:TableHeaderCell>&nbsp;&nbsp;&nbsp;&nbsp;Books Written&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableHeaderCell>
            </asp:TableRow>
        </asp:Table>

        <p>
            <asp:Label ID="message" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
