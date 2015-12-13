<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CapNhatDiem.ascx.cs" Inherits="QuanLiHocTap.WUC.CapNhatDiem" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style3 {
        width: 147px;
    }
    .auto-style26 {        width: 358px;
    }
    .auto-style9 {
        height: 25px;
    }
    .auto-style10 {
        width: 130px;
        height: 25px;
    }
    .auto-style23 {
        height: 195px;
    }
    .auto-style24 {
        width: 130px;
        height: 195px;
    }
    .auto-style27 {
        width: 388px;
        height: 25px;
    }
    .auto-style28 {
        width: 388px;
        height: 195px;
    }
    .auto-style29 {
        width: 81px;
    }
    .auto-style30 {
        width: 388px;
    }
    .auto-style32 {
        width: 130px;
    }
    </style>

<table class="auto-style1">
    <tr>
        <td colspan="3">
            <br />
            <br />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="3">
            Mã số sinh viên:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_MSSVLayDiem" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button_XuatBangDiem" runat="server" Text="Xuất bảng điểm" Width="108px" OnClick="Button_XuatBangDiem_Click" />
            <br />
        </td>
        <td>
            </td>
    </tr>
    <tr>
        <td class="auto-style26">
            <asp:Label ID="Label_BangDiemSV" runat="server" Text="Bảng điểm sinh viên:"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView_BangDiemSV" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" EnableModelValidation="True" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </td>
        <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button_Them" runat="server" Text="Thêm" Width="78px" OnClick="Button_Them_Click" style="margin-left: 0px" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button_CapNhat" runat="server" Text="Cập nhật" Width="78px" OnClick="Button_CapNhat_Click" />
            <br />
            <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button_Xoa" runat="server" Text="Xóa" Width="78px" OnClick="Button_Xoa_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </td>
        <td class="auto-style29">
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label_ThongBao" runat="server"></asp:Label>
            <br />
            <br />
            <table border="0" class="auto-style1">
                <tr>
                    <td aria-grabbed="undefined" class="auto-style27" style="border-style: double">&nbsp;&nbsp;&nbsp; Mã môn học</td>
                    <td aria-grabbed="undefined" class="auto-style9" style="border-style: double">&nbsp; Điểm</td>
                    <td aria-grabbed="undefined" class="auto-style10" style="border-style: double">&nbsp;Học kỳ</td>
                </tr>
                <tr>
                    <td aria-grabbed="undefined" class="auto-style30" style="border-style: none double double double">
                        <asp:TextBox ID="TextBox_MaMonHoc" runat="server" Height="26px" Width="102px"></asp:TextBox>
                    </td>
                    <td aria-grabbed="undefined" style="border-style: none double double double">
                        <asp:TextBox ID="TextBox_Diem" runat="server" Height="28px" style="margin-top: 0px" Width="47px"></asp:TextBox>
                    </td>
                    <td aria-grabbed="undefined" class="auto-style32" style="border-style: none double double double">
                        <asp:TextBox ID="TextBox_HocKy" runat="server" Height="28px" Width="50px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td aria-grabbed="undefined" class="auto-style28">
                    </td>
                    <td aria-grabbed="undefined" class="auto-style23">
                    </td>
                    <td aria-grabbed="undefined" class="auto-style24">
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </td>
        <td></td>
        <td>
            <asp:Label ID="Label_DanhSachMonHoc" runat="server" Text="Danh sách môn học"></asp:Label>
            <br />
&nbsp;<asp:GridView ID="GridView_DanhSachMonHoc" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" EnableModelValidation="True" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
        </td>
    </tr>
</table>


