<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PackageHistory.aspx.cs" Inherits="WebApplication7.PackageHistory" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="~/Scripts/jquery-2.1.4.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
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
                <li><a href="UpdateInfo.aspx">Update Info</a></li>              
                <li><a href="Login.aspx">Logout</a></li>                
            </ul>
        </div>
    </nav>

    <div class="container" style="padding-bottom:10%">
        <%= PackageHistoryDisplay() %>
    </div>

    <footer class="footer navbar-fixed-bottom container-fluid bg-4 modal-footer" style="background-color:white">
        <div class="container">
            <p>&copy; 2018 Travel Experts <a href="MainPage.aspx">Make a booking now!</a></p> 
        </div>
    </footer>
</body>
</html>
