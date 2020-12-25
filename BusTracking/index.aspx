<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BusTracking.index" %>

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
              <li class="nav-item">
                <a class="nav-link" href="index.aspx">Trang chủ</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="login.aspx">Đăng nhập</a>
              </li>
            </ul>
      
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
      
      <!-- Clients -->
      
      
      <div class="position-realive bg-image" style="background-image: url(../assets/img/pattern_1.svg);">
      
      <div class="page-section">
        <div class="container">
          <div class="row">
            <div class="col-lg-5 py-3">
              <div class="img-place mobile-preview shadow wow zoomIn">
                <img src="img/mapDN.png" alt="">
              </div>
            </div>
            <div class="col-lg-6 py-3 mt-lg-5">
              <div class="iconic-list">
                <div class="iconic-item wow fadeInUp">
                  <div class="iconic-md iconic-text bg-warning fg-white rounded-circle">
                    <span class="mai-search"></span>
                  </div>
                  <div class="iconic-content">
                    <h3>Powerful Features</h3>
                    <p class="fs-small">Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore</p>
                  </div>
                </div>
                <div class="iconic-item wow fadeInUp">
                  <div class="iconic-md iconic-text bg-info fg-white rounded-circle">
                    <span class="mai-bus"></span>
                  </div>
                  <div class="iconic-content">
                    <h3>Fully Secured</h3>
                    <p class="fs-small">Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore</p>
                  </div>
                </div>
                <div class="iconic-item wow fadeInUp">
                  <div class="iconic-md iconic-text bg-indigo fg-white rounded-circle">
                    <span class="mai-time"></span>
                  </div>
                  <div class="iconic-content">
                    <h3>Easy Monitoring</h3>
                    <p class="fs-small">Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore</p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      
      <div class="page-section">
        <div class="container">
          <div class="row">
            <div class="col-lg-6 offset-lg-1 py-3 mt-lg-5 wow fadeInUp">
              <h1 class="mb-4">Ecommerce business opperate easilly</h1>
              <p class="mb-4">Lorem ipsum dolor, sit amet consectetur adipisicing elit. Quos, molestiae, perspiciatis laboriosam quia placeat recusandae repudiandae corrupti similique delectus, aliquam commodi possimus eveniet optio magnam quis vel. Reiciendis, fuga excepturi.</p>
              <a href="#" class="btn btn-outline-primary rounded-pill">How it works</a>
            </div>
            <div class="col-lg-5 py-3">
              <div class="img-place mobile-preview shadow wow zoomIn">
                <img src="../assets/img/app_preview_3.png" alt="">
              </div>
            </div>
          </div>
        </div>
      </div>
      
      </div>
      
      
      <div class="page-section bg-dark fg-white">
        <div class="container">
          <h1 class="text-center">Why Choose Mobster</h1>
      
          <div class="row justify-content-center mt-5">
            <div class="col-md-6 col-lg-3 py-3">
              <div class="card card-body border-0 bg-transparent text-center wow zoomIn">
                <div class="mb-3">
                  <img src="../assets/img/icons/rocket.svg" alt="">
                </div>
                <p class="fs-large">Very Fast</p>
                <p class="fs-small fg-grey">Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed</p>
              </div>
            </div>
            <div class="col-md-6 col-lg-3 py-3">
              <div class="card card-body border-0 bg-transparent text-center wow zoomIn" data-wow-delay="200ms">
                <div class="mb-3">
                  <img src="../assets/img/icons/testimony.svg" alt="">
                </div>
                <p class="fs-large">Happy Client</p>
                <p class="fs-small fg-grey">Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed</p>
              </div>
            </div>
            <div class="col-md-6 col-lg-3 py-3">
              <div class="card card-body border-0 bg-transparent text-center wow zoomIn" data-wow-delay="400ms">
                <div class="mb-3">
                  <img src="../assets/img/icons/promotion.svg" alt="">
                </div>
                <p class="fs-large">Free Ads</p>
                <p class="fs-small fg-grey">Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed</p>
              </div>
            </div>
            <div class="col-md-6 col-lg-3 py-3">
              <div class="card card-body border-0 bg-transparent text-center wow zoomIn" data-wow-delay="600ms">
                <div class="mb-3">
                  <img src="../assets/img/icons/coins.svg" alt="">
                </div>
                <p class="fs-large">Save Money</p>
                <p class="fs-small fg-grey">Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed</p>
              </div>
            </div>
            <div class="col-md-6 col-lg-3 py-3">
              <div class="card card-body border-0 bg-transparent text-center wow zoomIn" data-wow-delay="800ms">
                <div class="mb-3">
                  <img src="../assets/img/icons/support.svg" alt="">
                </div>
                <p class="fs-large">24/7 Support</p>
                <p class="fs-small fg-grey">Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed</p>
              </div>
            </div>
            <div class="col-md-6 col-lg-3 py-3">
              <div class="card card-body border-0 bg-transparent text-center wow zoomIn" data-wow-delay="1000ms">
                <div class="mb-3">
                  <img src="../assets/img/icons/laptop.svg" alt="">
                </div>
                <p class="fs-large">Full Features</p>
                <p class="fs-small fg-grey">Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed</p>
              </div>
            </div>
          </div>
        </div>
      </div>
      
      <div class="page-section bg-image" style="background-image: url(../assets/img/pattern_2.svg);">
        <div class="container">
          <div class="row justify-content-center align-items-center">
            <div class="col-lg-5 mb-5 mb-lg-0 wow fadeInUp">
              <h1 class="mb-4">Pricing Plan</h1>
              <p class="mb-5">Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolores inventore maxime ipsa eligendi quibusdam velit maiores adipisci odit, exercitationem cumque iusto at debitis reiciendis a, ipsum aliquam reprehenderit. Sed, delectus.</p>
              <a href="#" class="btn btn-gradient btn-split-icon rounded-pill">
                <span class="icon mai-call-outline"></span> Custom Plan
              </a>
            </div>
            <div class="col-lg-7">
              <div class="pricing-table">
                <div class="pricing-item active wow zoomIn">
                  <div class="pricing-header">
                    <h3>Business Plan</h3>
                    <h1 class="fw-normal">$49.00</h1>
                  </div>
                  <div class="pricing-body">
                    <ul class="theme-list">
                      <li class="list-item">Push Notification</li>
                      <li class="list-item">Unlimited Bandwith</li>
                      <li class="list-item">Realtime Database</li>
                      <li class="list-item">Monthly Backup</li>
                      <li class="list-item">24/7 Support</li>
                    </ul>
                  </div>
                  <button class="btn btn-dark">Choose Plan</button>
                </div>
                <div class="pricing-item wow zoomIn" data-wow-delay="200ms">
                  <div class="pricing-header">
                    <h3>Starter Plan</h3>
                    <h1 class="fw-normal">$24.00</h1>
                  </div>
                  <div class="pricing-body">
                    <ul class="theme-list">
                      <li class="list-item">Push Notification</li>
                      <li class="list-item">Unlimited Bandwith</li>
                      <li class="list-item">Realtime Database</li>
                      <li class="list-item">Monthly Backup</li>
                      <li class="list-item">24/7 Support</li>
                    </ul>
                  </div>
                  <button class="btn btn-dark">Choose Plan</button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      
      <div class="page-section bg-image bg-image-overlay-dark" style="background-image: url(../assets/img/bg_testimonials.jpg);">
        <div class="container fg-white">
          <div class="row">
            <div class="col-md-8 col-lg-6 offset-lg-1 wow fadeInUp">
              <h2 class="mb-5 fg-white fw-normal">Customer Stories</h2>
              <p class="fs-large font-italic">Lorem ipsum dolor, sit amet consectetur adipisicing elit. Mollitia voluptates facere explicabo! Rerum necessitatibus cum qui veritatis reprehenderit, neque sapiente consequatur atque eaque molestias, est, quod totam quo laudantium ratione.</p>
              <p class="fs-large fg-grey fw-medium mb-5">John Doe, UI Designer</p>
      
              <a href="#" class="btn btn-outline-light rounded-pill">Read Stories <span class="mai-chevron-forward"></span></a>
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
</body>
</html>
