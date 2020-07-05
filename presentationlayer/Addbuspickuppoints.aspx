<%@ Page Title="" Language="C#" MasterPageFile="~/Adminmaster.Master" AutoEventWireup="true" CodeBehind="Addbuspickuppoints.aspx.cs" Inherits="presentationlayer.Addbuspickuppoints" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style9 {
        width: 149px;
    }
    .auto-style10 {
        font-weight: bold;
        color: #000066;
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
        <td class="auto-style9">Select bus</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">SelectPickUpPoints</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td><strong>
            <asp:Button ID="Button1" runat="server" BackColor="Black" BorderColor="Red" CssClass="auto-style10" ForeColor="Red" Text="ADD" OnClick="Button1_Click" />
            </strong></td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
