<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session1.aspx.cs" Inherits="WebApplication1.session1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:Label ID="Label5" runat="server" Text="Set Password" />
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" style="margin-left: 33px" Width="137px" />
           
        </div>
          <div>
            <h3>Provide Following Details</h3>
            <asp:label ID="Label1" runat="server" Text="Email" />
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Email" style="margin-left: 35px" Width="158px" OnTextChanged="TextBox1_TextChanged" />
              <br />
              <br />
              <br />
            <asp:label ID="Label2" runat="server" Text="Password" />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" style="margin-left: 9px" Width="158px" /><br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" style="margin-left: 72px" Width="154px" />
        </div>
        <p>
            <asp:Label ID="Label3" runat="server" />
            <asp:Label ID="Label4" runat="server" />
            
                     
        </p>
    </form>
</body>
</html>
