<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="TraCuuDiem.aspx.cs" Inherits="QuanLiHocTap.TraCuuDiem" %>
<%@ Register src="WUC/TraCuuDiem.ascx" tagname="TraCuuDiem" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:TraCuuDiem ID="TraCuuDiem1" runat="server" />
</asp:Content>
