<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AddAuthor.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Author</title>
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
<body style="height: 212px; background-color:cadetblue; text-align: center">
    <h1 style="font:bold 60px arial">
        <u>DAVID'S BOOKSTORE</u><br />
    </h1>
    <ul>
        <li><a href="Home.aspx">Home</a></li>
        <li><a href="AddRoyalties.aspx">All Royalties</a></li>
        <li><a href="AddAuthor.aspx">Add Authors</a></li>
        <li><a  class="active" href="AddPublisher.aspx">Add Publishers</a></li>
        <li><a href="LinkAuthPub.aspx">Link Authors & Publishers</a></li>
    </ul>
    <form id="form1" runat="server" style="text-align:center;" font-size="X-Large">
        <h1>
            <u>Enter a new Author</u><br />
        </h1>
        Name: <asp:TextBox ID="tb_Name" runat="server"></asp:TextBox>
        <p>
            Sex:
            <asp:RadioButton ID="rb_Male" runat="server" GroupName="Sexes" Text="Male" />
            <asp:RadioButton ID="rb_Female" runat="server" GroupName="Sexes" Text="Female" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" style="margin-left: 0px" Text="Submit" />
        </p>
        <p>
            <asp:Label ID="greet" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
