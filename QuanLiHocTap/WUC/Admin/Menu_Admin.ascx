<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu_Admin.ascx.cs" Inherits="QuanLiHocTap.WUC.Menu_Admin" %>
<style type="text/css">

    .auto-style1 {
        width: 100%;
    }
</style>
<table class="auto-style1">
    <tr>
        <td>
            <asp:HyperLink ID="HyperLink_CapNhatSV" runat="server" NavigateUrl="~/Admin/CapNhatSinhVien.aspx">Cập nhật sinh viên</asp:HyperLink>

        </td>
    </tr>
    <tr>
        <td>
            <asp:HyperLink ID="HyperLink_CapNhatDiemSV" runat="server" NavigateUrl="~/Admin/CapNhatDiem.aspx">Cập nhật điểm sinh viên</asp:HyperLink>
        </td>
    </tr>
    </table>



