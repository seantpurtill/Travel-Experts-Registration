<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateInfo.aspx.cs" Inherits="WebApplication7.UpdateInfo" %>

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
                <li><a href="PackageHistory.aspx">Package History</a></li>              
                <li><a href="Login.aspx">Logout</a></li>                
            </ul>
        </div>
    </nav>

    
    
     <form id="form1" runat="server">          <div>
 
 <div class="container-fluid">
    <section class="container">
		<div class="container-page">				
			<div class="col-md-6">
				<h3 class="dark-grey">Update Information</h3>
                	
                <div class="form-group col-lg-6">
					<label>Your Customer ID is</label>
                    <asp:Label ID="lblID" runat="server" Text=""></asp:Label>
					

				</div>
                		
				<div class="form-group col-lg-6">
					<label>First Name</label>
					<asp:TextBox ID="txtF" class="form-control" runat="server"></asp:TextBox>&nbsp;

				</div>
				
				<div class="form-group col-lg-6">
					<label>Last Name</label>
					<asp:TextBox ID="txtL" class="form-control" runat="server" AutoPostBack="True"></asp:TextBox>&nbsp;

				</div>
								
				<div class="form-group col-lg-6">
					<label>Email Address</label>
					<asp:TextBox ID="txtE" class="form-control" runat="server"></asp:TextBox>&nbsp;

				</div>
                
				<div class="form-group col-lg-6">
					<label>Address</label>
					<asp:TextBox ID="txtA" class="form-control" runat="server"></asp:TextBox>&nbsp;

				</div>
				
				<div class="form-group col-lg-6">
					<label>Postal Code</label>
					<asp:TextBox ID="txtPo" class="form-control" runat="server"></asp:TextBox>&nbsp;

				</div>
								
				<div class="form-group col-lg-6">
					<label>City</label>
					<asp:TextBox ID="txtCi" class="form-control" runat="server"></asp:TextBox>&nbsp;

				</div>

				
				<div class="form-group col-lg-6">
					<label>Province</label>
					<asp:DropDownList ID="ddlProvinces" class="form-control" runat="server" AutoPostBack="True">
                        <asp:ListItem>AB</asp:ListItem>
                        <asp:ListItem>BC</asp:ListItem>
                        <asp:ListItem>MB</asp:ListItem>
                        <asp:ListItem>NB</asp:ListItem>
                        <asp:ListItem>NL</asp:ListItem>
                        <asp:ListItem>NS</asp:ListItem>
                        <asp:ListItem>NT</asp:ListItem>
                        <asp:ListItem>NU</asp:ListItem>
                        <asp:ListItem>ON</asp:ListItem>
                        <asp:ListItem>PE</asp:ListItem>
                        <asp:ListItem>QC</asp:ListItem>
                        <asp:ListItem>SK</asp:ListItem>
                        <asp:ListItem>YT</asp:ListItem>
                    </asp:DropDownList>&nbsp;

				</div>

                <div class="form-group col-lg-6">
					<label>Country</label>
					<asp:TextBox ID="txtCo" class="form-control" runat="server"></asp:TextBox>&nbsp;

				</div>
								
				<div class="form-group col-lg-6">
					<label>Home Phone</label>
					<asp:TextBox ID="txtH" class="form-control" runat="server"></asp:TextBox>&nbsp;
				</div>

				
				<div class="form-group col-lg-6">
					<label>Business Phone</label>
					<asp:TextBox ID="txtB" class="form-control" runat="server"></asp:TextBox>&nbsp;
				</div>


					
			

				<div class="col-sm-6">
				</div>				
			
			</div>
		
			<div class="col-md-6">
				<h3 class="dark-grey">Your TE Account</h3>

                 <div class="form-group col-lg-12">
					<label>Password</label>
					<asp:TextBox ID="txtpassword" class="form-control" runat="server"></asp:TextBox>&nbsp;
				</div>
								
				<div class="form-group col-lg-12">
					<label>Repeat Password</label>
					<asp:TextBox ID="txtconfirm" class="form-control" runat="server"></asp:TextBox>&nbsp;
				</div>

				</div>

				<asp:Button ID="btnUpdate" runat="server" type="submit" class="btn btn-primary" Text="Update" OnClick="btnUpdate_Click"/>
				<asp:Button ID="btnCancel" runat="server" type="submit" class="btn btn-primary" Text="Cancel" OnClick="btnCancel_Click"/>

			</div>
		</div>
	</section>
</div>
        <br />
        <br />
        <br />
         <asp:TextBox ID="txttest" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
    
    </div>

    </form>

</body>
</html>

</body>
</html>


</body>
</html>
