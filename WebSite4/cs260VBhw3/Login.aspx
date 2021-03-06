﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
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
    <form id="form1" runat="server" style="text-align: center;" font-size="X-Large">
        <h1>
            <u>Login</u><br />
        </h1>

        Login:
        <asp:TextBox ID="tb_login" runat="server"></asp:TextBox>
        <br />
        Password:
        <asp:TextBox ID="tb_password" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="bt_login" runat="server" Text="Login" />
        &nbsp;&nbsp;
        <asp:Button ID="btn_newCust" runat="server" Text="New Customer" />

        <br />
        <br />
        <br />
        <asp:Label ID="message" runat="server" Text=""></asp:Label>

    </form>
</body>
</html>
