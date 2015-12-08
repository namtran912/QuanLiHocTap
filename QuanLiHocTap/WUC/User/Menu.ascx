<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="QuanLiHocTap.Menu" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        height: 24px;
    }
    .auto-style3 {
        height: 23px;
    }
</style>
<table class="auto-style1">
    <tr>
        <td>
<asp:HyperLink ID="HyperLink_TraCuuDiem" runat="server" NavigateUrl="~/User/TraCuuDiem.aspx">TraCuuDiem</asp:HyperLink>

        </td>
    </tr>
    <tr>
        <td>
            <asp:HyperLink ID="HyperLink_TraCuuThuHang" runat="server" NavigateUrl="~/User/TraCuuThuHang.aspx">Tra cứu thứ hạng</asp:HyperLink>
        </td>
    </tr>
    </table>


