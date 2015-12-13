<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.ascx.cs" Inherits="QuanLiHocTap.Login" %>
<p>
                <asp:Label ID="Label_MSSVDN" runat="server" Text="Mã số sinh viên:"></asp:Label>
            &nbsp;&nbsp;
                <asp:TextBox ID="TextBox_MSSV" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
                <asp:Label ID="Label_MatKhauDN" runat="server" Text="Mật khẩu:"></asp:Label>
            &nbsp;&nbsp;
                <asp:TextBox ID="TextBox_MatKhau" runat="server" style="margin-left: 0px" TextMode="Password"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button_DangNhap" runat="server" Text="Đăng nhập" OnClick="Button_DangNhap_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button_DangKy" runat="server" Text="Đăng ký" OnClick="Button_DangKy_Click" Width="98px" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;
    <asp:Label ID="Label_MSSV" runat="server"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button_DangXuat" runat="server" OnClick="Button_DangXuat_Click" Text="Đăng xuất" Width="98px" />
        </p>



