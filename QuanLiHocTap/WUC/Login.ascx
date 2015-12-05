<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="QuanLiHocTap.Login" %>
<style type="text/css">
    .auto-style1 {
        width: 85%;
    }
    .auto-style3 {
        width: 26px;
        height: 30px;
    }
    .auto-style4 {
        width: 62px;
        height: 30px;
    }
    .auto-style5 {
        width: 94px;
        height: 30px;
    }
    .auto-style6 {
        width: 25px;
        height: 30px;
    }
    .auto-style9 {
        width: 98px;
        height: 30px;
    }
    .auto-style11 {
        width: 61px;
        height: 30px;
    }
</style>

<asp:Panel ID="Panel_DangNhap" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style9">
                <asp:Label ID="Label_MSSVDN" runat="server" Text="Mã số sinh viên:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox_MSSV" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:Label ID="Label_MatKhauDN" runat="server" Text="Mật khẩu:"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox_MatKhau" runat="server" style="margin-left: 0px"></asp:TextBox>
            </td>
            <td class="auto-style6">
                <asp:Button ID="Button_DangNhap" runat="server" Text="Đăng nhập" OnClick="Button_DangNhap_Click" />
            </td>
            <td class="auto-style4">
                <asp:Button ID="Button_DangKy" runat="server" Text="Đăng ký" OnClick="Button_DangKy_Click" Width="98px" />
            </td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="Panel_DangXuat" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label_MSSV" runat="server"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button_DangXuat" runat="server" OnClick="Button_DangXuat_Click" Text="Đăng xuất" />
</asp:Panel>

