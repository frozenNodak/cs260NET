<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AddBook.aspx.vb" Inherits="AddPublisher" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Publisher</title>
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
        <li><a href="AdminHome.aspx">Home</a></li>
        <li><a href="AddAuthor.aspx">Add Authors</a></li>
        <li><a href="AddBook.aspx">Add Books</a></li>
        <li><a href="ListOfAll.aspx">List Everything</a></li>
        <li><a href="SearchBooks.aspx">Search</a></li>
        <li><a href="Login.aspx">Logout</a></li>
    </ul>
    <form id="form1" runat="server" style="text-align:center;" font-size="X-Large">
        <h1>
            <u>Enter a new Book</u><br />
        </h1>
        Title: <asp:TextBox ID="tb_Title" runat="server" Width="168px"></asp:TextBox>
        <br />
        ISBN: <asp:TextBox ID="tb_isbn" runat="server" Width="168px"></asp:TextBox>
        <br />
        Price:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tb_price" runat="server" Width="167px"></asp:TextBox>
        <br />
        Written By:<asp:DropDownList ID="ddl_Authors" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="AID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString4 %>" ProviderName="<%$ ConnectionStrings:ConnectionString4.ProviderName %>" SelectCommand="SELECT [Name], [AID] FROM [Authors]"></asp:SqlDataSource>
&nbsp;<p>
            <asp:Button ID="btn_submit" runat="server" style="margin-left: 0px" Text="Submit" />
        </p>
        <p>
            <asp:Label ID="greet" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
