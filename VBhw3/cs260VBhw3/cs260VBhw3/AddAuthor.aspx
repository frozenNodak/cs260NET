<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AddAuthor.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 212px">
    <form id="form1" runat="server" style="text-align:center; background-color:cadetblue">
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
