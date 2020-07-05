<%@ Page Title="" Language="C#" MasterPageFile="~/Adminmaster.Master" AutoEventWireup="true" CodeBehind="AddFareDestination.aspx.cs" Inherits="presentationlayer.AddFareDestination" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style9 {
        width: 252px;
    }
    .auto-style10 {
        width: 190px;
    }
    .auto-style11 {
        width: 208px;
    }
    .auto-style12 {
        font-weight: bold;
        margin-left: 0px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">SELECT SERVICE NO</td>
        <td class="auto-style10">
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td class="auto-style11">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style11">SELECT STARTTIME</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">SELECT FROM PLACE</td>
        <td class="auto-style10">
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td class="auto-style11">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">SELECT TOPLACE</td>
        <td class="auto-style10">
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
        </td>
        <td class="auto-style11">SELECT REACHTIME</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">FARE</td>
        <td class="auto-style10">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style11">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
            <asp:Button ID="Button1" runat="server" BackColor="Black" CssClass="auto-style12" ForeColor="Red" Text="ADD" Width="50px" OnClick="Button1_Click" />
            </strong></td>
        <td class="auto-style11">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
