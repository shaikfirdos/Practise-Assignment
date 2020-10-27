<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignment3.aspx.cs" Inherits="WebApplication1.assignment3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
                    <asp:Table ID="Table1" runat="server" CellPadding="2" CellSpacing="0" Border="1" BorderStyle="Dotted" style="width:250px;height:100px;background-color:lightpink;" /><br />
                    <tr>
                        <td style="color:deeppink">
                            <strong>FirstName :</strong> <span><%#Eval("FirstName :")%></span><br />
                             <strong>LastName :</strong> <span><%#Eval("LastName :") %></span><br />
                            <strong>Designation :</strong> <span><%#Eval("Designation :")%></span><br />
                            <strong>Loacation :</strong> <span><%#Eval("Location :")%></span><br />
                            <strong>Country :</strong> <span><%#Eval("Country :")%></span><br />
                        </td>
                    </tr>

                </ItemTemplate>
            </asp:DataList>

        </div>
    </form>
</body>
</html>
