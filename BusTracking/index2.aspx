<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index2.aspx.cs" Inherits="BusTracking.index2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BusTracking</title>
    <!--===============================================================================================-->	
    <link rel="shorcut icon" href="img/icon/logo.png" />
    <!--===============================================================================================-->	
    <link href="css/maicons.css" rel="stylesheet" />
    <!--===============================================================================================-->	
    <link href="vender/animate/animate.css" rel="stylesheet" />
    <!--===============================================================================================-->	
    <link href="css/bootstrap.css" rel="stylesheet" />
    <!--===============================================================================================-->	
    <link href="css/bustracking.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <nav class="navbar navbar-expand-lg navbar-light navbar-floating">
        <div class="container">
            <a class="navbar-brand" href="#">
            <img src="img/logo/favicon1.png" alt="" width="130">
            </a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarToggler" aria-controls="navbarToggler" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
            </button>
  
            <div class="collapse navbar-collapse" id="navbarToggler">
                <ul class="navbar-nav ml-lg-5 mt-3 mt-lg-0">
                    
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
                        <asp:HyperLink ID="HyperLink6" runat="server" class="nav-link" NavigateUrl="~/Quanly_Ve.aspx">Quản lý Vé</asp:HyperLink>
                    </li>

                </ul>
                <div class="ml-auto my-2 my-lg-0">
                    <asp:Button ID="Button1" runat="server" class="btn btn-primary rounded-pill" Text="Thoát" OnClick="Button1_Click" />
                </div>
            </div>
        </div>
    </nav>
  
    <div class="page-hero-section bg-image hero-home-1" style="background-image: url(img/bghero11.png);">
        <div class="hero-caption pt-5">
            <div class="container h-100">
                <div class="row align-items-center h-100">
                    <div class="col-lg-6 wow fadeInUp">
                        <h1 class="mb-4">BUSTRACKING</h1>
                        <p class="mb-4">Ứng dụng tra cứu vị trí xe buýt</p>
                    </div>
                    <div class="col-lg-6 d-none d-lg-block wow zoomIn">
                        <div class="img-place mobile-preview shadow floating-animate">
                            <img src="img/mapDN.png" alt="">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class="page-footer-section bg-dark fg-white">
        <p class="d-inline-block ml-2"><center>Copyright &copy; 2020 BusTracking</center></p>
    </div>

    <script src="js/jquery-3.5.1.min.js"></script>
    <script src="js/bustracking.js"></script>
    <script src="js/bootstrap.bundle.min.js"></script>
    <script src="vender/owl-carousel/js/owl.carousel.min.js"></script>
    <script src="vender/wow/wow.min.js"></script>
    </form>
</body>
</html>
