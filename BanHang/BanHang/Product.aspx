<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="BanHang.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
     <div class="grid-container">
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
            <ItemTemplate>
                <div class="grid-item">
                    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("MaSP") %>' OnClick="LinkButton1_Click">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/images/"+Eval("Hinh") %>' Heigh="50%" Width="50%" />
                    </asp:LinkButton>

                    <br />
                    Tên sản phẩm:<%# Eval("TenSP") %>
                <br />
                    Đơn giá: <%# Eval("Gia") %>
                </div>
            </ItemTemplate>

        </asp:DataList>
    </div>
</asp:Content>
