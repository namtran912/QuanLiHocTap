<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="TraCuuThuHang.aspx.cs" Inherits="QuanLiHocTap.TraCuuThuHang" %>
<%@ Register src="~/WUC/User/TraCuuThuHang.ascx" tagname="TraCuuThuHang" tagprefix="uc1" %>
<%@ Register src="~/WUC/User/Menu.ascx" tagname="Menu" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:TraCuuThuHang ID="TraCuuThuHang1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <uc2:Menu ID="Menu1" runat="server" />
</asp:Content>

