<%@ Page Title="Page One" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Page1.aspx.vb" Inherits="Master_DetailsPages2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="webform1">
    <tr>
    <td>
    <h2>Page 1 = My favorite fruit</h2>
<p />
<asp:DropDownList ID="ddlFruitList"
runat="server">
    <asp:ListItem Value="Apple"></asp:ListItem>
    <asp:ListItem Value="Banana"></asp:ListItem>
    <asp:ListItem Value="Pear"></asp:ListItem>
    <asp:ListItem Value="Peach"></asp:ListItem>
    <asp:ListItem Value="Grape"></asp:ListItem>
</asp:DropDownList>
<p />
<asp:Button ID="btnSelect"
runat="server"
Text="Select" />
&nbsp;
<asp:Label ID="lblAnswer"
runat="server">
</asp:Label>
    </td>
    </tr>
    </table>
</asp:Content>
