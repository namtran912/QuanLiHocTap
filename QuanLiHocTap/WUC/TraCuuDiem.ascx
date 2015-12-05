<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TraCuuDiem.ascx.cs" Inherits="QuanLiHocTap.WUC.TraCuuDiem" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
<table class="auto-style1">
    <tr>
        <td>&nbsp;<asp:Label ID="Label_TraCuuTheo" runat="server" Text="Tra cứu theo:  "></asp:Label>
            <asp:DropDownList ID="DropDownList_TraCuu" runat="server" AutoPostBack="True"  OnSelectedIndexChanged="DropDownList_TraCuu_SelectedIndexChanged" Width="121px">
                <asp:ListItem Value="Tất cả">Tất cả</asp:ListItem>
                <asp:ListItem Value="Học kì">Học kì</asp:ListItem>
                <asp:ListItem Value="Chuyên ngành">Chuyên ngành</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label_HocKy" runat="server" Enabled="False" Text="Học kỳ: "></asp:Label>
            <asp:DropDownList ID="DropDownList_HocKy" runat="server" Enabled="False" Height="16px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList_HocKy_SelectedIndexChanged" Width="51px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label_ChuyenNganh" runat="server" Text="Chuyên ngành: "></asp:Label>
            <asp:DropDownList ID="DropDownList_ChuyenNganh" runat="server" Enabled="False" Height="22px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList_ChuyenNganh_SelectedIndexChanged" Width="138px">
                <asp:ListItem>Thị giác máy tính</asp:ListItem>
                <asp:ListItem>Công nghệ Tri thức</asp:ListItem>
                <asp:ListItem>Khoa học Máy tính</asp:ListItem>
                <asp:ListItem>Công nghệ Phần mềm</asp:ListItem>
                <asp:ListItem>Mạng máy tính và Viễn thông</asp:ListItem>
                <asp:ListItem>Hệ thống Thông tin</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
<asp:GridView ID="GridView_TraCuuDiem" runat="server">
</asp:GridView>

        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label_DiemTB" runat="server" Text="Điểm trung bình: "></asp:Label>
            <br />
            <asp:Label ID="Label_DiemTichLuy" runat="server" Text="Điểm tích lũy: "></asp:Label>
            <br />
            <asp:Label ID="Label_SoTC" runat="server" Text="Số tín chỉ: "></asp:Label>
        </td>
    </tr>
</table>


