<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="CapNhatDiem.aspx.cs" Inherits="QuanLiHocTap.CapNhatDiem" %>
<%@ Register src="~/WUC/Admin/Menu_Admin.ascx" tagname="Menu_Admin" tagprefix="uc1" %>
<%@ Register src="~/WUC/Admin/CapNhatDiem.ascx" tagname="CapNhatDiem" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <uc1:Menu_Admin ID="Menu_Admin1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc2:CapNhatDiem ID="CapNhatDiem1" runat="server" />
</asp:Content>
