<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style3">
            <caption>Login Form</caption>
            <tr>
                <td class="auto-style1">Username</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
         </table>
            <div>
                   <asp:Label ID="lablstatus" runat="server" ForeColor="Navy"></asp:Label>
            </div>

            <div>
                  <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            </div>
        </div>
    </form>
</body>
</html>
