<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AddPublisher.aspx.vb" Inherits="AddPublisher" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 212px">
    <form id="form1" runat="server" style="text-align:center; background-color:cadetblue">
        <h1>
            <u>Enter a new Publisher</u><br />
        </h1>
        Name: <asp:TextBox ID="tb_Name" runat="server" Width="168px"></asp:TextBox>
        <br />
        City:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tb_City" runat="server" Width="167px"></asp:TextBox>
        
        <p>
            <asp:Button ID="Button1" runat="server" style="margin-left: 0px" Text="Submit" />
        </p>
        <p>
            <asp:Label ID="greet" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
