<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="quanlynhanvien.aspx.cs" Inherits="BusTracking.quanlynhansu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quản lý nhân viên</title>
    
    <!--===============================================================================================-->	
    <link rel="shorcut icon" href="img/icon/logo.png"/>
    <!--===============================================================================================-->	
    <link href="css/maicons.css" rel="stylesheet" />
    <!--===============================================================================================-->	
    <link href="vender/animate/animate.css" rel="stylesheet" />
    <!--===============================================================================================-->	
    <link href="css/bootstrap.css" rel="stylesheet" />
    <!--===============================================================================================-->	
    <link href="css/bustracking.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 84%;
        }
        .auto-style2 {
            height: 29px;
        }
        .auto-style3 {
            height: 29px;
            width: 197px;
        }
        .auto-style4 {
            width: 197px;
        }
        .auto-style5 {
            width: 1157px;
        }
        .auto-style6 {
            width: 803px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark navbar-floating">
            <div class="container">
                <a class="navbar-brand" href="index2.aspx">
                    <img src="img/logo/favicon1-light.png" alt="" width="130"/>
                </a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarToggler" aria-controls="navbarToggler" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
                </button>
  
                <div class="collapse navbar-collapse" id="navbarToggler">
                    <ul class="navbar-nav ml-auto mt-2 mt-lg-0">
                        <li class="nav-item active">
                            <asp:HyperLink ID="HyperLink1" runat="server" class="nav-link" NavigateUrl="~/quanlynhanvien.aspx">Quản lý nhân viên</asp:HyperLink>
                        </li>
                        <li class="nav-item active">
                            <asp:HyperLink ID="HyperLink2" runat="server" class="nav-link" NavigateUrl="~/Quanlytaixe.aspx">Quản lý tài xế</asp:HyperLink>
                        </li>
                        <li class="nav-item active">
                            <asp:HyperLink ID="HyperLink5" runat="server" class="nav-link" NavigateUrl="~/Quanly_TuyenXe.aspx">Quản lý tuyến xe</asp:HyperLink>
                        </li>
                        <li class="nav-item active">
                            <asp:HyperLink ID="HyperLink3" runat="server" class="nav-link" NavigateUrl="~/Quanlydonvi.aspx">Quản lý đơn vị</asp:HyperLink>
                        </li>
                        <li class="nav-item active">
                            <asp:HyperLink ID="HyperLink4" runat="server" class="nav-link" NavigateUrl="~/Quanly_Xe.aspx">Quản lý xe</asp:HyperLink>
                        </li>
                        <li class="nav-item active">
                            <asp:HyperLink ID="HyperLink6" runat="server" class="nav-link" NavigateUrl="~/Quanly_ve.aspx">Quản lý Vé</asp:HyperLink>
                        </li>
                   </ul>
                   <div class="ml-auto my-2 my-lg-0">
                       <asp:Button ID="Button2" runat="server" class="btn btn-primary rounded-pill" Text="Thoát" OnClick="Button2_Click" />
                   </div>
                </div>
            </div>
        </nav>

        <main class="bg-light">

        <div class="page-hero-section bg-image hero-mini" style="background-image: url(img/hero_minii.png);">
            <div class="hero-caption">
                <div class="container fg-white h-100">
                    <div class="row justify-content-center align-items-center text-center h-100">
                        <div class="col-lg-6">
                            <h3 class="mb-4 fw-medium">QUẢN LÝ NHÂN VIÊN</h3>
                            <nav aria-label="breadcrumb">
                                <ol class="breadcrumb breadcrumb-dark justify-content-center bg-transparent">
                                    <li class="breadcrumb-item"><a href="index2.aspx">Trang chủ</a></li>
                                    <li class="breadcrumb-item active" aria-current="page">QLNV</li>
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
                            <h5 class="mb-4 fw-medium">Bảng quản lý tài khoản</h5>
                            <hr>
                            <table class="auto-style1">
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label10" runat="server" Text="Mã tài khoản"></asp:Label>
                                    </td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="TextBox_mtk" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label3" runat="server" Text="Ngày tháng năm sinh"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox_ngaythangns" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label11" runat="server" Text="Tên tài khoản"></asp:Label>
                                    </td>
                                    <td class="auto-style4">
                                        <asp:TextBox ID="TextBox_tentk" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label4" runat="server" Text="Số điện thoại"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox_sdt" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label12" runat="server" Text="Mật khẩu"></asp:Label>
                                    </td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="TextBox_mk" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label5" runat="server" Text="Chức vụ"></asp:Label>
                                    </td>
                                    <td class="auto-style2">
                                        <asp:TextBox ID="TextBox_chucvu" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text="Tên đầy đủ"></asp:Label>
                                    </td>
                                    <td class="auto-style4">
                                        <asp:TextBox ID="TextBox_tendaydu" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <table>
                                <td class="auto-style5">
                                    <center class="auto-style6">
                                        <asp:Button ID="Button_them" runat="server" class="btn btn-primary rounded-pill" Text="Thêm" OnClick="Button_them_Click" />
                                        <asp:Button ID="Button1" runat="server" class="btn btn-primary rounded-pill" Text="Xóa" OnClick="Button1_Click" />

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
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="1133px">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="MaTaiKhoan" HeaderText="Mã tài khoản" />
                                    <asp:BoundField DataField="TenTaiKhoan" HeaderText="Tên tài khoản" />
                                    <asp:BoundField DataField="MatKhau" HeaderText="Mật khẩu" />
                                    <asp:BoundField DataField="TenDayDu" HeaderText="Tên đầy đủ" />
                                    <asp:BoundField DataField="NgayThangNamSinh" HeaderText="Ngày tháng năm sinh" />
                                    <asp:BoundField DataField="SoDienThoai" HeaderText="Số điện thoại" />
                                    <asp:BoundField DataField="ChucVu" HeaderText="Chức vụ" />
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


        <div class="page-footer-section bg-dark fg-white">
            <div class="container">
                <div class="page-footer-section bg-dark fg-white">
                    <p class="d-inline-block ml-2"><center>Copyright &copy; 2020 BusTracking</center></p>
                </div>
            </div>
        </div>

        <script src="js/jquery-3.5.1.min.js"></script>
        <script src="js/bustracking.js"></script>
        <script src="js/bootstrap.bundle.min.js"></script>
        <script src="vender/owl-carousel/js/owl.carousel.min.js"></script>
        <script src="vender/wow/wow.min.js"></script>
    </form>
</body>
</html>
