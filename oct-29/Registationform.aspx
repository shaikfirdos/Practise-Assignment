<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="signup1.Form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 139px;
        }
        .auto-style2 {
            width: 339px;
        }
    </style>
    <style>
        .Container{
            width:400px;
            height:300px;
            margin:100px auto;
            box-shadow:10px; 
            background-image:linear-gradient(red, yellow);
            font-family:Magneto;

        }
        .Container h1{
             text-align:center;
        }
        #Button1{
             background-image:linear-gradient(yellow,green);
        }
        .auto-style3 {
            margin-left: 68px;
        }
        .auto-style4 {
            margin-right: 4px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Container">
            <h1>RegistrationForm</h1>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">UserName</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="171px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">EmailAddress</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Email" Width="171px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Password</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="172px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">ConfirmPassword</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" Width="171px" CssClass="auto-style4"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Gender</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">City</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Please Select </asp:ListItem>
                            <asp:ListItem>Mumbai</asp:ListItem>
                            <asp:ListItem>Kolkota</asp:ListItem>
                            <asp:ListItem>Bangalore</asp:ListItem>
                            <asp:ListItem>Hyderabad</asp:ListItem>
                            <asp:ListItem>AndhraPradesh</asp:ListItem>
                            <asp:ListItem>Chennai</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
            <br />
            <br />
        <asp:Button ID="Button1" runat="server" Height="24px" OnClick="Button1_Click" Text="Register" Width="247px" CssClass="auto-style3"/>
        </div>
    </form>
</body>
</html>
