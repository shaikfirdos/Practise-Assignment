<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataList.aspx.cs" Inherits="datalist.DataList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
                    StudentID:
                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("StudentID")%>' /><br />
                    StudentName:
                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("StudentName")%>' /><br />
                    StudentEmailId:
                    <asp:Label ID="Label3" runat="server" Text='<%#Eval(" StudentEmailId")%>' /><br />
                     StudentMblNo:
                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("  StudentMblNo")%>' /><br />
                    StudentGender:
                    <asp:Label ID="Label5" runat="server" Text='<%#Eval("StudentGender")%>' /><br />
                     StudentCity:
                    <asp:Label ID="Label6" runat="server" Text='<%#Eval("StudentCity")%>' /><br />
                     StudentAddress:
                    <asp:Label ID="Label7" runat="server" Text='<%#Eval("StudentAddress")%>' /><br />
                     StudentImg:
                    <asp:Label ID="Label8" runat="server" Text='<%#Eval("StudentImg")%>' /><br />
                    <asp:Image ID="img1" runat="server" Width="100px" Height="100px" ImageUrl='<%"~/a5.jpg/" + Eval("StudentImg") %>' />
                    <br />
                    <br />
                </ItemTemplate>
            </asp:DataList>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [StudentTable]"></asp:SqlDataSource>
    </form>
</body>
</html>
