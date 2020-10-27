<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookiecollection.aspx.cs" Inherits="WebApplication1.cookiecollection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Select Brand Preference" />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="iPhone" /><br />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="OnePlus" /><br />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Samsung" /><br />
            <asp:CheckBox ID="CheckBox4" runat="server" Text="Nokia" /><br />
            <asp:CheckBox ID="CheckBox5" runat="server" Text="MI" /><br />
             <asp:CheckBox ID="CheckBox6" runat="server" Text="Oppo" /><br />
             <asp:CheckBox ID="CheckBox7" runat="server" Text="Vivo" /><br />
             <asp:CheckBox ID="CheckBox8" runat="server" Text="Motrolla" /><br />
             <asp:CheckBox ID="CheckBox9" runat="server" Text="Realme" /><br />
             <asp:CheckBox ID="CheckBox10" runat="server" Text="Poco M2" /><br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="CheckOn" OnClick="Button1_Click" /><br />
        </div>
    </form>
    <p>
        <asp:Label ID="Label2" runat="server" /><br />
    </p>

    <!--Scenario : when i click the checkbox & hint on submit button, I ashould seee the cookie information-->
</body>
</html>
