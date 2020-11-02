<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FormView.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FormView ID="FormView1" runat="server" AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Both">
                <EditItemTemplate>
                    EmpID:
                    <asp:TextBox ID="EmpIDTextBox" runat="server" Text='<%# Bind("EmpID") %>' />
                    <br />
                    EmpName:
                    <asp:TextBox ID="EmpNameTextBox" runat="server" Text='<%# Bind("EmpName") %>' />
                    <br />
                    EmpDesignation:
                    <asp:TextBox ID="EmpDesignationTextBox" runat="server" Text='<%# Bind("EmpDesignation") %>' />
                    <br />
                    EmpSalary:
                    <asp:TextBox ID="EmpSalaryTextBox" runat="server" Text='<%# Bind("EmpSalary") %>' />
                    <br />
                    EmpMblNo:
                    <asp:TextBox ID="EmpMblNoTextBox" runat="server" Text='<%# Bind("EmpMblNo") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <EditRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <InsertItemTemplate>
                    EmpID:
                    <asp:TextBox ID="EmpIDTextBox" runat="server" Text='<%# Bind("EmpID") %>' />
                    <br />
                    EmpName:
                    <asp:TextBox ID="EmpNameTextBox" runat="server" Text='<%# Bind("EmpName") %>' />
                    <br />
                    EmpDesignation:
                    <asp:TextBox ID="EmpDesignationTextBox" runat="server" Text='<%# Bind("EmpDesignation") %>' />
                    <br />
                    EmpSalary:
                    <asp:TextBox ID="EmpSalaryTextBox" runat="server" Text='<%# Bind("EmpSalary") %>' />
                    <br />
                    EmpMblNo:
                    <asp:TextBox ID="EmpMblNoTextBox" runat="server" Text='<%# Bind("EmpMblNo") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    EmpID:
                    <asp:Label ID="EmpIDLabel" runat="server" Text='<%# Bind("EmpID") %>' />
                    <br />
                    EmpName:
                    <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Bind("EmpName") %>' />
                    <br />
                    EmpDesignation:
                    <asp:Label ID="EmpDesignationLabel" runat="server" Text='<%# Bind("EmpDesignation") %>' />
                    <br />
                    EmpSalary:
                    <asp:Label ID="EmpSalaryLabel" runat="server" Text='<%# Bind("EmpSalary") %>' />
                    <br />
                    EmpMblNo:
                    <asp:Label ID="EmpMblNoLabel" runat="server" Text='<%# Bind("EmpMblNo") %>' />
                    <br />

                </ItemTemplate>
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
            </asp:FormView>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [EmployeeTable]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
