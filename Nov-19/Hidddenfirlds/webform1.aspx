<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Hiddenfields1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Button ID="Button1" runat="server" Text="HitCount" OnClick="Button1_Click" />
            
            <asp:Button ID="Button2" runat="server" Text="Open Another Webpage" PostBackUrl="~/Getdata.aspx" Width="89px" /> <%--It is used to go another web page--%>
            <br />
            <asp:HiddenField ID="HiddenField1" runat="server" Value="0" />

             <br />

            <asp:HiddenField ID="hdnfldCurrentDateTime" runat="server" Value="0" />
            <asp:Label ID="firdos" runat="server" Text="Label"></asp:Label>

            <asp:HiddenField ID="HiddenField2" runat="server" Value="Firdos"/>
            <asp:Label ID="l1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />

        </div>
    </form>
</body>
</html>
