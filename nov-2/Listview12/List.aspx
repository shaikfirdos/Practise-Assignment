<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListView.aspx.cs" Inherits="Listview.ListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Show Data Using ListView Comtrol in Asp.net<br />
            <br />
            <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
                <AlternatingItemTemplate>
                    <tr style="background-color:#FFF8DC;">
                        <td>
                            <asp:Label ID="StudentIDLabel" runat="server" Text='<%# Eval("StudentID") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StudentNameLabel" runat="server" Text='<%# Eval("StudentName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="FatherNameLabel" runat="server" Text='<%# Eval("FatherName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StudentMblNoLabel" runat="server" Text='<%# Eval("StudentMblNo") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <tr style="background-color:#008A8C;color: #FFFFFF;">
                        <td>
                            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                        </td>
                        <td>
                            <asp:TextBox ID="StudentIDTextBox" runat="server" Text='<%# Bind("StudentID") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="StudentNameTextBox" runat="server" Text='<%# Bind("StudentName") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="FatherNameTextBox" runat="server" Text='<%# Bind("FatherName") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="StudentMblNoTextBox" runat="server" Text='<%# Bind("StudentMblNo") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                        </td>
                    </tr>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                        </td>
                        <td>
                            <asp:TextBox ID="StudentIDTextBox" runat="server" Text='<%# Bind("StudentID") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="StudentNameTextBox" runat="server" Text='<%# Bind("StudentName") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="FatherNameTextBox" runat="server" Text='<%# Bind("FatherName") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="StudentMblNoTextBox" runat="server" Text='<%# Bind("StudentMblNo") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                        </td>
                    </tr>
                </InsertItemTemplate>
                <ItemTemplate>
                    <tr style="background-color:#DCDCDC;color: #000000;">
                        <td>
                            <asp:Label ID="StudentIDLabel" runat="server" Text='<%# Eval("StudentID") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StudentNameLabel" runat="server" Text='<%# Eval("StudentName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="FatherNameLabel" runat="server" Text='<%# Eval("FatherName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StudentMblNoLabel" runat="server" Text='<%# Eval("StudentMblNo") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                        </td>
                    </tr>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                        <th runat="server">StudentID</th>
                                        <th runat="server">StudentName</th>
                                        <th runat="server">FatherName</th>
                                        <th runat="server">StudentMblNo</th>
                                        <th runat="server">City</th>
                                    </tr>
                                    <tr id="itemPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                        <td>
                            <asp:Label ID="StudentIDLabel" runat="server" Text='<%# Eval("StudentID") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StudentNameLabel" runat="server" Text='<%# Eval("StudentName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="FatherNameLabel" runat="server" Text='<%# Eval("FatherName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StudentMblNoLabel" runat="server" Text='<%# Eval("StudentMblNo") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                        </td>
                    </tr>
                </SelectedItemTemplate>
            </asp:ListView>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [ListViewTable]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
