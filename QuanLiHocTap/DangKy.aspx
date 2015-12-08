<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="QuanLiHocTap.DangKy" %>
<%@ Register src="WUC/Dangky.ascx" tagname="Dangky" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:Dangky ID="Dangky1" runat="server" />
</asp:Content>
