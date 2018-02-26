<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication7.Login" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <title></title>
    <link href="~/Content/LoginStyle.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="~/Scripts/jquery-2.1.4.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
    <script src="~/Scripts/LoginJS.js"></script>
</head>
<body>
    <%--<form id="form1" runat="server">
    </form>--%>
    <nav class="navbar navbar-default">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand">Travel Experts</a>              
            </div>
            <ul class="nav navbar-nav">
                <li class="active"><a href="MainPage.aspx">Home</a></li>               
            </ul>
        </div>
    </nav>
    <div class="container">
    <div class="row">
        <div class="col-md-12">
            <div class="pr-wrap">
                <div class="pass-reset">
                    <label>
                        Enter the email you signed up with</label>
                    <input type="email" placeholder="Email" />
                    <input type="submit" value="Submit" class="pass-reset-submit btn btn-success btn-sm" />
                </div>
            </div>
            <div class="wrap">
                <p class="form-title">
                    Sign In</p>
                <form class="login" runat="server">
                <asp:TextBox ID="txtCustID" runat="server" placeholder="Username"></asp:TextBox> 
                <asp:TextBox ID="txtPassword" runat="server" placeholder="Password"></asp:TextBox>
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login"  />
                <div class="remember-forgot">
                    <div class="row">
                        <div class="col-md-6">
                            <div class="checkbox">
                                <label>
                                    <input type="checkbox" />
                                    Remember Me
                                </label>
                            </div>
                        </div>
                        <div class="col-md-6 forgot-pass-content">
                            <a href="javascription:void(0)" class="forgot-pass">Forgot Password</a>
                        </div>
                    </div>
                </div>
                </form>
            </div>
        </div>
    </div>
        </div>

</body>
</html>
