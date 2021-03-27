<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="BanHang.ProductDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <%-- <h1>Chi tiết sản phẩm</h1>
    <asp:DataList ID="DataList1" runat="server">
         <ItemTemplate>
               <div class="product">
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/images/"+Eval("Hinh") %>' Width="200px"/>
                    <div class="product_content">
                        <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("TenSP") %>'></asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" Text='<%# Eval("MoTa") %>'></asp:LinkButton>
                        <asp:LinkButton ID="LinkButton3" runat="server" Text='<%# Eval("Gia") %>'></asp:LinkButton>
                        
                        <form class="form-inline my-2 my-lg-0">
                            <h4>Số lượng: </h4>
                            <asp:TextBox class="form-control mr-sm-2" min="1" max="50" style="width: 80px" ID="TextBox1" runat="server" type="number"></asp:TextBox>
                            <asp:Button ID="Button1" runat="server" class="btn btn-primary my-2 my-sm-0" type="submit" text="Mua hàng" CommandArgument='<%# Eval("MaSP") %>' OnClick="Button1_Click"/>
                         </form>
                        <asp:LinkButton ID="LinkButton4" runat="server" CommandArgument='<%# Eval("MaSP") %>' OnClick="LinkButton1_Click">
                                Giỏ hàng
                        </asp:LinkButton>
                    </div>                
                </div>
            </ItemTemplate>
    </asp:DataList>--%>
     <asp:DataList ID="DataList1" runat="server">
         <ItemTemplate>
               <div class="grid-item">
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/images/"+Eval("Hinh") %>' Heigh ="50%" Width="50%"/><br />
                        Tên Ô tô: <%# Eval("TenSP") %>'><br />
                        Mô Tả: <%# Eval("MoTa") %>'><br />
                        Đơn giá: <%# Eval("Gia") %>'> <br />
                        <form class="form-inline my-2 my-lg-0">
                            <h4>Số lượng: </h4>
                            <asp:TextBox class="form-control mr-sm-2" min="1" max="50" style="width: 80px" ID="TextBox1" runat="server" type="number"></asp:TextBox>
                            <asp:Button ID="Button1" runat="server" class="btn btn-primary my-2 my-sm-0" type="submit" text="Mua hàng" CommandArgument='<%# Eval("MaSP") %>' OnClick="Button1_Click"/>
                         </form>
                         <asp:LinkButton ID="LinkButton4" runat="server" CommandArgument='<%# Eval("MaSP") %>' OnClick="LinkButton1_Click">
                                Giỏ hàng
                        </asp:LinkButton>
                                  
                </div>
            </ItemTemplate>
    </asp:DataList>
</asp:Content>
