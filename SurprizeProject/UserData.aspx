<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserData.aspx.cs" Inherits="PractideProject.UserData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 663px;
        }
        .auto-style2 {
            width: 78%;
        }
        .auto-style3 {
            width: 877px;
        }
        .auto-style4 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table  class="auto-style2">
                <caption>RegistrationForm</caption>
                <tr>
                    <td class="auto-style1">UserName</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox1" runat="server" Width="169px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Password</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="167px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">ConfirmPassword</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="165px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Age</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox4" runat="server" Width="163px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Gender</td>
                    <td class="auto-style3">
&nbsp;&nbsp;
                        <asp:RadioButton ID="Male" runat="server" Text="Male" />
&nbsp;
                        <asp:RadioButton ID="Female" runat="server" Text="Female" />
                    </td>
                </tr>
            </table>
        </div>
        <div class="auto-style4">
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Home" Width="65px" OnClick="Button2_Click" />
            <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
&nbsp;</div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT * FROM [UserTable1]" ></asp:SqlDataSource>
    </form>
</body>
</html>
