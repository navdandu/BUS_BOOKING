<%@ Page Title="" Language="C#" MasterPageFile="~/Adminmaster.Master" AutoEventWireup="true" CodeBehind="UpdateDpoints.aspx.cs" Inherits="presentationlayer.UpdateDpoints" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style9 {
        width: 161px;
    }
    .auto-style10 {
        width: 161px;
        font-size: x-large;
    }
    .auto-style11 {
        width: 161px;
        height: 34px;
    }
    .auto-style12 {
        height: 34px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style10"><strong>Did</strong></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style10"><strong>Dname</strong></td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style11"></td>
        <td class="auto-style12">
            <asp:Button ID="Button1" runat="server" BackColor="Black" BorderColor="Black" ForeColor="Red" OnClick="Button1_Click" Text="UPDATE" />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" BackColor="Black" ForeColor="Red" OnClick="Button2_Click" Text="CANCEL" />
        </td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
