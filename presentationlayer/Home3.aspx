<%@ Page Title="" Language="C#" MasterPageFile="~/mainmaster1.Master" AutoEventWireup="true" CodeBehind="Home3.aspx.cs" Inherits="presentationlayer.Home3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            margin-left: 186px;
            margin-right: 168px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-weight: 700; color: #000066; font-size: large">
    WELCOME TO HOMEPAGE&nbsp;&nbsp;&nbsp;</p>
    <p style="font-weight: 700; color: #000066; font-size: large">
        Fromplace&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        </asp:DropDownList>
</p>
    <p style="font-weight: 700; color: #000066; font-size: large">
        &nbsp;Toplace&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
    <p style="font-weight: 700; color: #000066; font-size: large">
        Dateofjourney&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Calendar ID="Calendar1" runat="server" CssClass="auto-style9" Height="72px" Width="140px"></asp:Calendar>
&nbsp;
</p>
    <p style="font-weight: 700; color: #000066; font-size: large">
        NoofSeats&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
&nbsp;
</p>
    <p style="font-weight: 700; color: #000066; font-size: large">
        &nbsp;</p>
    <p style="font-weight: 700; color: #000066; font-size: large">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="22px" Text="SEARCH BUS" />
</p>
    <p style="font-weight: 700; color: #000066; font-size: large">
        &nbsp;</p>
    <p style="font-weight: 700; color: #000066; font-size: large">
        &nbsp;</p>
    <p style="font-weight: 700; color: #000066; font-size: large">
        &nbsp;</p>
</asp:Content>
