<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentData.aspx.cs" Inherits="StudentDetails.StudentData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 212px;
        }
        .auto-style2 {
            width: 424px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <!--<table style="border:2px solid red; text-align:left; width:300px; padding-top:2px; background-color:lime; border-radius:8px;font-size:20px" />-->

            <asp:Repeater ID="RP1" runat="server">
                <HeaderTemplate>
                    <table style="width:200px;padding-top:0px;background-color:gold;">
                        <tr>
                            <td style="font-size:20px;text-align:center;height:48px;">
                                <asp:Label ID="lab1" runat="server" Text="Student Profile" />
                            </td>
                        </tr>
                    </table>
                   </HeaderTemplate>
                <ItemTemplate>
                    <table style="width:100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="StudentID"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;<asp:Label ID="Label9" runat="server" Text='<%#Eval("StudentID")%>'></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="StudentName"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;<asp:Label ID="Label10" runat="server" Text='<%#Eval("StudentName")%>'></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="StudentEmailID"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;<asp:Label ID="Label11" runat="server" Text='<%#Eval("StudentEmailID")%>'></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Text="StudentMblNo"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;<asp:Label ID="Label12" runat="server" Text='<%#Eval("StudentMblNo")%>'></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server" Text="StudentGender"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;<asp:Label ID="Label13" runat="server" Text='<%#Eval("StudentGender")%>'></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label6" runat="server" Text="StudentAddress"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;<asp:Label ID="Label14" runat="server" Text='<%#Eval("StudentAddress")%>'></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label7" runat="server" Text="StudentCity"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;<asp:Label ID="Label15" runat="server" Text='<%#Eval("StudentCity")%>'></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label8" runat="server" Text="StudentImg"></asp:Label>
                    </td>
                    <td rowspan="5" class="auto-style2">
                                &nbsp;
                                <asp:Image ID="Img1" runat="server" Width="100px" Height="100px" ImageUrl='<%#"~/a5.jpg/" + Eval("StudentImg") %>' />
                                <br />

                        
                        <asp:Label ID="Label16" runat="server" Text='<%#Eval("StudentImg")%>'></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
            </table>
                </ItemTemplate>
                 <FooterTemplate>
                    <table>
                        <tr>
                            <td>
                                @Developed by Firdos SK <br />

                                @2020 All the CopyRights Reserved.
                            </td>
                        </tr>
                    </table>
                </FooterTemplate>
            
         </asp:Repeater>

        </div>

    </form>
       
        <p>
            &nbsp;</p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [StudentTable]"></asp:SqlDataSource>
</body>
</html>
