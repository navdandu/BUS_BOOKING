<%@ Page Title="" Language="C#" MasterPageFile="~/Adminmaster.Master" AutoEventWireup="true" CodeBehind="Bookseat.aspx.cs" Inherits="presentationlayer.Bookseat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style16 {
            height: 32px;
        }
        .auto-style23 {
            width: 30px;
            height: 32px;
        }
        .auto-style24 {
            width: 30px;
        }
        .auto-style32 {
            height: 37px;
        }
        .auto-style33 {
            width: 21px;
            height: 32px;
        }
        .auto-style34 {
            width: 21px;
        }
        .auto-style36 {
            width: 25px;
            height: 32px;
        }
        .auto-style37 {
            width: 25px;
        }
        .auto-style39 {
            width: 23px;
            height: 32px;
        }
        .auto-style40 {
            width: 23px;
        }
        .auto-style42 {
            width: 24px;
            height: 32px;
        }
        .auto-style43 {
            width: 24px;
        }
        .auto-style45 {
            width: 29px;
            height: 32px;
        }
        .auto-style46 {
            width: 29px;
        }
        .auto-style48 {
            width: 26px;
            height: 32px;
        }
        .auto-style49 {
            width: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style23">
                <asp:ImageButton ID="i_1" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style33">
                <asp:ImageButton ID="i_2" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style36">
                <asp:ImageButton ID="i_3" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style39">
                <asp:ImageButton ID="i_4" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style39">
                <asp:ImageButton ID="i_5" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style42">
                <asp:ImageButton ID="i_6" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style42">
                <asp:ImageButton ID="i_7" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style45">
                <asp:ImageButton ID="i_8" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style48">
                <asp:ImageButton ID="i_9" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style16">&nbsp;&nbsp;
                <asp:ImageButton ID="i_10" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SErvice no&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblsvno" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style23">
                <asp:ImageButton ID="i_11" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style33">
                <asp:ImageButton ID="i_12" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style36">
                <asp:ImageButton ID="i_13" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style39">
                <asp:ImageButton ID="i_14" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style39">
                <asp:ImageButton ID="i_15" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style42">
                <asp:ImageButton ID="i_16" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style42">
                <asp:ImageButton ID="i_17" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style45">
                <asp:ImageButton ID="i_18" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style48">
                <asp:ImageButton ID="i_19" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td>&nbsp;&nbsp;
                <asp:ImageButton ID="i_20" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fromplace&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblfromplace" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style49">&nbsp;</td>
            <td>&nbsp;&nbsp;
                <asp:ImageButton ID="i_41" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Toplace&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbltoplace" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style23">
                <asp:ImageButton ID="i_21" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style33">
                <asp:ImageButton ID="i_22" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style36">
                <asp:ImageButton ID="i_23" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style39">
                <asp:ImageButton ID="i_24" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style39">
                <asp:ImageButton ID="i_25" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style42">
                <asp:ImageButton ID="i_26" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style42">
                <asp:ImageButton ID="i_27" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style45">
                <asp:ImageButton ID="i_28" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style48">
                <asp:ImageButton ID="i_29" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td>&nbsp;&nbsp;
                <asp:ImageButton ID="i_30" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Travelagencynsme&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbltagencyname" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Button" />
            </td>
        </tr>
        <tr>
            <td class="auto-style23">
                <asp:ImageButton ID="i_31" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style33">
                <asp:ImageButton ID="i_32" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style36">
                <asp:ImageButton ID="i_33" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style39">
                <asp:ImageButton ID="i_34" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style39">
                <asp:ImageButton ID="i_35" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style42">
                <asp:ImageButton ID="i_36" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style42">
                <asp:ImageButton ID="i_37" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style45">
                <asp:ImageButton ID="i_38" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style48">
                <asp:ImageButton ID="i_39" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
            </td>
            <td class="auto-style32">&nbsp;&nbsp;
                <asp:ImageButton ID="i_40" runat="server" Height="36px" ImageUrl="~/images/new seat.jpg" Width="33px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; fare&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblfare" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style49">&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style49">&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; Departuretime&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lbldeparturetime" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style49">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style49">&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Arrivaltime&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblarrivaltime" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style49">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style49">&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SelectBoarding Point&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style49">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style49">&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Seat no&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblseatno" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
