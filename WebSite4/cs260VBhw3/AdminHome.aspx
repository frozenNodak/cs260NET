<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AdminHome.aspx.vb" Inherits="Home" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
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
    <h1 style="font: bold 60px arial">
        <u>DAVID'S BOOKSTORE </u>
        <br />
    </h1>
    <ul>
        <li><a href="AdminHome.aspx">Home</a></li>
        <li><a href="AddAuthor.aspx">Add Authors</a></li>
        <li><a href="AddBook.aspx">Add Books</a></li>
        <li><a href="ListOfAll.aspx">List Everything</a></li>
        <li><a href="SearchBooks.aspx">Search</a></li>
        <li><a href="Login.aspx">Logout</a></li>
    </ul>
    <form id="form1" runat="server" style="text-align: center;" font-size="X-Large">
        <h1>
            <u>Welcome Admin!</u><br />
        </h1>
        <asp:Button ID="btn_all" runat="server" Text="Clear ALL tables"  />
        <br />
        <br />
        <asp:Button ID="btn_author" runat="server" Text="Clear Authors"  />
        &nbsp;<asp:Button ID="btn_book" runat="server" Text="Clear Books" />
        &nbsp;<asp:Button ID="btn_cust" runat="server" Text="Clear Customers" />
        &nbsp;<asp:Button ID="btn_order" runat="server" Text="Clear Orders" />
        &nbsp;<asp:Button ID="btn_writtenby" runat="server" Text="Clear Writen By" />
    </form>
</body>
</html>
