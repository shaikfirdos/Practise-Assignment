<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Oncommand.aspx.cs" Inherits="Web1.Oncommand" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnCommand="LinkButton1_Command" Text="item1" CommandName="Selected" CommandArgument="1"></asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton2" runat="server" OnCommand="LinkButton2_Command" Text="item2" CommandName="Selected" CommandArgument="2"></asp:LinkButton><br />
        </div>
        <asp:Label ID="Label1" runat="server" />
    </form>
</body>
</html>
