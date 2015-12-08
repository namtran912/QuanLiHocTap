<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="QuanLiHocTap.User" %>
<%@ Register src="~/WUC/User/User.ascx" tagname="User" tagprefix="uc1" %>
<%@ Register src="~/WUC/User/Menu.ascx" tagname="Menu" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <uc1:User ID="User1" runat="server" />
</asp:Content>


<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <uc2:Menu ID="Menu1" runat="server" />
</asp:Content>



