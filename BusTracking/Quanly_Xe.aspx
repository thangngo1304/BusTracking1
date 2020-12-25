<%@ Page Title="" Language="C#" MasterPageFile="~/Quanly.Master" AutoEventWireup="true" CodeBehind="Quanly_Xe.aspx.cs" Inherits="BusTracking.Quanly_Xe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 798px;
        }
        .auto-style2 {
            width: 535px;
        }
        .auto-style3 {
            width: 545px;
        }
        .auto-style4 {
            width: 563px;
        }
        .auto-style5 {
            width: 799px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="bg-light">

        <div class="page-hero-section bg-image hero-mini" style="background-image: url(img/hero_minii.png);">
            <div class="hero-caption">
                <div class="container fg-white h-100">
                    <div class="row justify-content-center align-items-center text-center h-100">
                        <div class="col-lg-6">
                            <h3 class="mb-4 fw-medium">QUẢN LÝ XE</h3>
                            <nav aria-label="breadcrumb">
                                <ol class="breadcrumb breadcrumb-dark justify-content-center bg-transparent">
                                    <li class="breadcrumb-item"><a href="index2.aspx">Trang chủ</a></li>
                                    <li class="breadcrumb-item active" aria-current="page">QLXe</li>
                                </ol>
                            </nav>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="page-section pt-5">
            <div class="container">
                <div class="row justify-content-center">
                        <div class="card-page">
                           <h5 class="mb-4 fw-medium">Bảng quản lý xe</h5>
                           <hr>
                            <table class="auto-style1">
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label10" runat="server" Text="Mã xe:"></asp:Label>
                                    </td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="TextBox_mx" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label3" runat="server" Text="Công suất:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox_cs" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label11" runat="server" Text="Biển số:"></asp:Label>
                                    </td>
                                    <td class="auto-style4">
                                        <asp:TextBox ID="TextBox_bs" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label4" runat="server" Text="Ngày sản xuất :"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox_nsx" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label12" runat="server" Text="Loại xe:"></asp:Label>
                                    </td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="TextBox_lx" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label5" runat="server" Text="Chu kì bảo hành:"></asp:Label>
                                    </td>
                                    <td class="auto-style2">
                                        <asp:TextBox ID="TextBox_ckbh" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text="Số ghế:"></asp:Label>
                                    </td>
                                    <td class="auto-style4">
                                        <asp:TextBox ID="TextBox_sg" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text="Mã tuyến:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox_mt" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <table>
                                <td class="auto-style5">
                                    <center class="auto-style2">
                                        <asp:Button ID="Button_them" runat="server" class="btn btn-primary rounded-pill" Text="Thêm" OnClick="Button_them_Click" />
                                        <asp:Button ID="Button_xoa" runat="server" class="btn btn-primary rounded-pill" Text="Xóa" OnClick="Button_xoa_Click" />

                                        <asp:Button ID="Button_sua" runat="server" class="btn btn-primary rounded-pill" Text="Sửa" OnClick="Button_sua_Click" />
                                        <asp:Button ID="Button_ghi" runat="server" class="btn btn-primary rounded-pill" Text="Ghi" OnClick="Button_ghi_Click" />
                                        <asp:Button ID="Button_khghi" runat="server" class="btn btn-primary rounded-pill" Text="Không ghi" OnClick="Button_khghi_Click" />
                                        <br />
                                        <asp:Label ID="Label_thongbao" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                                        <asp:Button ID="Button_co" runat="server" class="btn btn-primary rounded-pill" Text="Có" OnClick="Button_co_Click" />
                                        <asp:Button ID="Button_khong" runat="server" class="btn btn-primary rounded-pill" Text="Không" OnClick="Button_khong_Click" />
                                    </center>
                                </td>
                            </table>
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="MaXe" HeaderText="Mã xe" />
                                    <asp:BoundField DataField="BienSo" HeaderText="Biển số" />
                                    <asp:BoundField DataField="LoaiXe" HeaderText="Loại xe" />
                                    <asp:BoundField DataField="SoGhe" HeaderText="Số ghế" />
                                    <asp:BoundField DataField="CongSuat" HeaderText="Công suất" />
                                    <asp:BoundField DataField="NgaySX" HeaderText="Ngày sản xuất" />
                                    <asp:BoundField DataField="ChuKiBaoHanh" HeaderText="Chu kì bảo hành" />
                                    <asp:BoundField DataField="MaTuyen" HeaderText="Mã tuyến" />
                                    <asp:CommandField SelectText="Chọn" ShowSelectButton="True" />
                                </Columns>
                                <EditRowStyle BackColor="#7C6F57" />
                                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#E3EAEB" />
                                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                                <SortedAscendingHeaderStyle BackColor="#246B61" />
                                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                                <SortedDescendingHeaderStyle BackColor="#15524A" />
                            </asp:GridView>
                        </div>
                </div>
            </div>
        </div>

        </main>
</asp:Content>
