<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BusTracking.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="img/icon/logo.png"/>
<!--===============================================================================================-->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
<!--===============================================================================================-->
    <link href="fonts/font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet" />
<!--===============================================================================================-->
    <link href="fonts/iconic/css/material-design-iconic-font.min.css" rel="stylesheet" />
<!--===============================================================================================-->
    <link href="vendor/animate/animate.css" rel="stylesheet" />
<!--===============================================================================================-->	
    <link href="vendor/css-hamburgers/hamburgers.min.css" rel="stylesheet" />
<!--===============================================================================================-->
    <link href="vendor/animsition/css/animsition.min.css" rel="stylesheet" />
<!--===============================================================================================-->
    <link href="vendor/select2/select2.min.css" rel="stylesheet" />
<!--===============================================================================================-->	
    <link href="vendor/daterangepicker/daterangepicker.css" rel="stylesheet" />
<!--===============================================================================================-->
    <link href="css/util.css" rel="stylesheet" />
    <link href="css/main.css" rel="stylesheet" />
<!--===============================================================================================-->
</head>
<body>
    <div class="limiter">
		<div class="container-login100" style="background-image: url(img/bg-01.jpg);">
			<div class="wrap-login100">
				<form id="form1" runat="server" class="login100-form validate-form">
					<span class="login100-form-logo">
						<img src="img/logo/favicon1.png" alt="" width="130"/>
					</span>

					<span class="login100-form-title p-b-34 p-t-27">
						Đăng nhập
                        <hr />
                        <li/><a href="index.aspx">Trang chủ</a></li>
					        
					</span>
                     <div class="wrap-input100 validate-input" data-validate = "Enter username">
						
                         <asp:TextBox ID="TextBox1" runat="server" class="input100" type="text" name="username" placeholder="Username"></asp:TextBox>
						<span class="focus-input100" data-placeholder="&#xf207;"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Enter password">
						
                        <asp:TextBox ID="TextBox2" runat="server" class="input100" type="password" name="pass" placeholder="Password"></asp:TextBox>
						<span class="focus-input100" data-placeholder="&#xf191;"></span>
					</div>

					<div class="contact100-form-checkbox">
						<input class="input-checkbox100" id="ckb1" type="checkbox" name="remember-me"/>
						<label class="label-checkbox100" for="ckb1">
							Nhớ tài khoản.
						</label>
                        
					</div>
                    <div>
                        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                    </div>

					<div class="container-login100-form-btn">
                        <asp:Button ID="Button1" runat="server" class="login100-form-btn" Text="Đăng nhập" OnClick="Button1_Click1" />
					</div>
				</form>
			</div>
		</div>
	</div>
	

	<div id="dropDownSelect1"></div>
	
<!--===============================================================================================-->
    <script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
    <script src="vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
    <script src="vendor/bootstrap/js/popper.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
    <script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
    <script src="vendor/daterangepicker/moment.min.js"></script>
    <script src="vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
    <script src="vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
    <script src="js/main.js"></script>

</body>
</html>
