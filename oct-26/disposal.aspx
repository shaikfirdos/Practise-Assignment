<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="disposal.aspx.cs" Inherits="Web1.disposal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnDisposed="LinkButton1_Disposed" OnClick="LinkButton1_Click">ASP.Net Training</asp:LinkButton><br />
        </div>
        <asp:Label ID="Label1" runat="server" />
    </form>
</body>
</html>
