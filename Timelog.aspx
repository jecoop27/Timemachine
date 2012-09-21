<%@ Page Title="" Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeFile="Timelog.aspx.cs" Inherits="Timelog" %>
<%@ MasterType VirtualPath="~/Master.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_Head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_Body" Runat="Server">
    <asp:DropDownList ID="ddlClasses" runat="server">
    </asp:DropDownList>
    <asp:DropDownList ID="ddlStudents" runat="server">
    </asp:DropDownList>
    <asp:DropDownList ID="ddlProjects" runat="server">
    </asp:DropDownList>
    <asp:DropDownList ID="ddlWeek" runat="server">
    </asp:DropDownList>
    <asp:GridView ID="gvTimeLog" runat="server">
    </asp:GridView>
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_Foot" Runat="Server">
</asp:Content>

