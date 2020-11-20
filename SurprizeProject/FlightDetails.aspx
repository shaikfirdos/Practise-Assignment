<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlightDetails.aspx.cs" Inherits="PractideProject.FlightDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 467px;
        }
        .auto-style2 {
            width: 820px;
        }
        .auto-style3 {
            width: 46%;
        }
        .auto-style5 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style5">
        <div>
            <table class="auto-style3">
                <caption>Find Your Source</caption>
                <tr>
                    <td class="auto-style1">FlightId</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">FlightNumber</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">FlightName</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Source</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Destination</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <div class="auto-style5">
            <br />
            <asp:Button ID="Button1" runat="server" Text="Data-Added" Width="74px" OnClick="Button1_Click" />
       &nbsp;&nbsp;
           <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Button2_Click" />
        &nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Login" Width="63px" OnClick="Button3_Click" />
        </div>
             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [FlightTable1]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
