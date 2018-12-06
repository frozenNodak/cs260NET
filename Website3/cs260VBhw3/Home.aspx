<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="Home" %>

<!DOCTYPE html>

<head runat="server">
    <title>Home</title>
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
        <li><a  class="active" href="Home.aspx">Home</a></li>
        <li><a href="AddRoyalties.aspx">All Royalties</a></li>
        <li><a href="AddAuthor.aspx">Add Authors</a></li>
        <li><a href="AddPublisher.aspx">Add Publishers</a></li>
        <li><a href="LinkAuthPub.aspx">Link Authors & Publishers</a></li>
    </ul>
    <form id="form1" runat="server" style="text-align:center;" font-size="X-Large">
        <h1>
            <u>Welcome</u><br />
        </h1>
        <asp:Button ID="Button1" runat="server" Text="Clear System" />
    </form>
</body>
</html>
