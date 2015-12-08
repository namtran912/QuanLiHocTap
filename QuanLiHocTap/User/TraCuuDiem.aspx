<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="TraCuuDiem.aspx.cs" Inherits="QuanLiHocTap.TraCuuDiem" %>
<%@ Register src="~/WUC/User/TraCuuDiem.ascx" tagname="TraCuuDiem" tagprefix="uc1" %>
<%@ Register src="~/WUC/User/Menu.ascx" tagname="Menu" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:TraCuuDiem ID="TraCuuDiem1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <uc2:Menu ID="Menu1" runat="server" />
</asp:Content>

