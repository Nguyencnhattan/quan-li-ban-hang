<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="BanHang.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h5>Giỏ Hàng</h5>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MaSP" HeaderText="Mã sản phẩm" />
            <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm" />
            <asp:BoundField DataField="Gia" HeaderText="Đơn giá" />
            <asp:BoundField DataField="SoLuong" HeaderText="Số lượng" />
            <asp:BoundField DataField="ThanhTien" HeaderText="Thành tiền" />
        </Columns>

    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Text="Bạn chưa đặt mua sản phẩm nào cả!!!"></asp:Label>
</asp:Content>
