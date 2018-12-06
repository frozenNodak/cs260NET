<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SearchBooks.aspx.vb" Inherits="SearchBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Books</title>
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
        <u>DAVID'S BOOKSTORE</u><br />
    </h1>
    <ul id ="adminTab" runat="server">
        <<li><a href="AdminHome.aspx">Home</a></li>
        <li><a href="AddAuthor.aspx">Add Authors</a></li>
        <li><a href="AddBook.aspx">Add Books</a></li>
        <li><a href="ListOfAll.aspx">List Everything</a></li>
        <li><a href="SearchBooks.aspx">Search</a></li>
        <li><a href="Login.aspx">Logout</a></li>
    </ul>
    <ul id ="custTab" runat="server">
        <li><a href="Home.aspx">Home</a></li>
        <li><a href="SearchBooks.aspx">Search Books</a></li>
        <li><a href="CustInfo.aspx">My Account</a></li>
        <li><a href="Login.aspx">Logout</a></li>
    </ul>
    <form id="form1" style="text-align: center" runat="server">
        <h1>
            <u>Search Books</u><br />
        </h1>

        <asp:TextBox ID="tb_search" runat="server"></asp:TextBox>
        &nbsp;
        <asp:Button ID="btn_search" runat="server" Text="Search" />&nbsp;
        <asp:RadioButton ID="rb_Title" runat="server" Text="Title" GroupName="search" Checked="true" />&nbsp;
        <asp:RadioButton ID="rb_Author" runat="server" Text="Author" GroupName="search" />&nbsp;<br />
        <asp:RadioButton ID="l10" runat="server" GroupName="search" Text="price &lt;= $10" />
        <br />
        <asp:RadioButton ID="p20" runat="server" GroupName="search" Text="$10 &lt; price &lt;= $20" />
        <br />
        <asp:RadioButton ID="p30" runat="server" GroupName="search" Text="$20 &lt; price &lt;= $30" />
        <br />
        <asp:RadioButton ID="p40" runat="server" GroupName="search" Text="$30 &lt; price &lt;= $40" />
        <br />
        <asp:RadioButton ID="o40" runat="server" GroupName="search" Text="price &lt; $40" />
&nbsp;<asp:Table ID="tbl_booksearch"  runat="server" HorizontalAlign="Center" Font-Size="X-Large">
            <asp:TableRow>
                <asp:TableHeaderCell>&nbsp;&nbsp;&nbsp;&nbsp;Title&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableHeaderCell>
                <asp:TableHeaderCell>&nbsp;&nbsp;&nbsp;&nbsp;Price&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableHeaderCell>
                <asp:TableHeaderCell>&nbsp;&nbsp;&nbsp;&nbsp;Purchase&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableHeaderCell>
                <asp:TableHeaderCell>&nbsp;&nbsp;&nbsp;&nbsp;Quantity&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableHeaderCell>
            </asp:TableRow>
        </asp:Table>

        <p>
            <asp:Button ID="btn_Purchase" runat="server" Style="margin-left: 0px" Text="Purchase" Font-Size="X-Large" />
        </p>
        <p>
            <asp:Label ID="message" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
