<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1Registration.aspx.cs" Inherits="WebApplication1.WebForm1Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
    <title></title>
    <style>
        .container{
            width:400px;
            height:620px;
            background-image:linear-gradient(red, yellow);
            margin:100px auto;
            box-shadow:10px; 
            font-family:'Times New Roman';
           

        }
        .container h1{
           text-align:center;
        }
        #b1{
            background-image:linear-gradient(red, yellow,green);
           
        }
    </style>
</head>
<body id="b1">
    <form id="form1" runat="server">

         <div class="container">
             <br />
             <h1 style="color:white">Registration Form</h1>
            <asp:Label ID="Label1" runat="server" Text="UserName" ForeColor="White" />
            <asp:TextBox ID="TextBox1" runat="server" required="true" style="margin-left: 64px" Width="165px"/>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Email Address" ForeColor="White" />
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Email" required="true" style="margin-left: 39px" Width="168px" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password" ForeColor="White" />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" required="true" style="margin-left: 70px" Width="170px" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Confirm Password" ForeColor="White" />
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" required="true" style="margin-left: 10px" Width="171px" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Gender" ForeColor="White" /><br />
            <asp:RadioButton ID="rd1" runat="server" Text="Male" GroupName="Gender" ForeColor="White"/>
            <asp:RadioButton ID="rd2" runat="server" Text="Female" GroupName="Gender" ForeColor="White" />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Courses" ForeColor="White" /><br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Java" ForeColor="White" /><br />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Python" ForeColor="White" /><br />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="C Programming" ForeColor="White" /><br />
            <asp:CheckBox ID="CheckBox4" runat="server" Text="Csharp Programming" ForeColor="White" />
            <br />
            <br />
            <br />
           

            <asp:Button ID="Button1" Text="SignUp" runat="server" style="margin-left: 69px" Width="235px" OnClick="Button1_Click" ForeColor="#00ff00" /><br />
        </div>
       <p>
            <asp:Label ID="ShowCourse" runat="server" />
            <asp:Label ID="Label7" runat="server" />
            <asp:Label ID="Label8" runat="server" />
            <asp:Label ID="Label9" runat="server" />
            <asp:Label ID="Label10" runat="server" />
            <asp:Label ID="Label11" runat="server" />
       </p>
    </form>
</body>
</html>
