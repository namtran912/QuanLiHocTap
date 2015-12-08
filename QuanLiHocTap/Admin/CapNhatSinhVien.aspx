<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="CapNhatSinhVien.aspx.cs" Inherits="QuanLiHocTap.CapNhatSinhVien" %>
<%@ Register src="~/WUC/Admin/Menu_Admin.ascx" tagname="Menu_Admin" tagprefix="uc1" %>
<%@ Register src="~/WUC/Admin/CapNhatSinhVien.ascx" tagname="CapNhatSinhVien" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <uc1:Menu_Admin ID="Menu_Admin1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc2:CapNhatSinhVien ID="CapNhatSinhVien1" runat="server" />
</asp:Content>
