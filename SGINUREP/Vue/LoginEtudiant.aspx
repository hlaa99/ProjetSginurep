<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginEtudiant.aspx.cs" Inherits="SGINUREP.Vue.LoginEtudiant" %>

<!DOCTYPE html>
  <html lang="en">
  <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title></title>
         <link rel="stylesheet" href="../assets/css/style.css">
       <link rel="stylesheet" href="../assets/css/logincs.css">
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
    </head>
    <body class="bs-gray">
  
   <div class="container" id="container">
	
	<div class="form-container sign-in-container">
		<form action="#" class="form" runat="server">
			<h1>Connexion</h1>
			<div class="social-container">
				<a href="#" class="social"><i class="fab fa-facebook-f"></i></a>
				<a href="#" class="social"><i class="fab fa-google-plus-g"></i></a>
				<a href="#" class="social"><i class="fab fa-linkedin-in"></i></a>
			</div>
			<span>Utiliser votre code et votre Motdepasse pour vous connecter</span>
            <asp:TextBox ID="tcode" class="form-control" type="Text" placeholder="Code" runat="server"></asp:TextBox>
            <asp:TextBox ID="tpass" class="form-control" type="password" placeholder="Motdepasse"  runat="server"></asp:TextBox>
            <asp:Label ID="lmessage" runat="server" Text="@"></asp:Label>
            <asp:LinkButton ID="btnlnk" runat="server">Motdepasse oublié?</asp:LinkButton>
            <asp:Button ID="btnconnect" class="btn btn-outline-primary" runat="server" Text="Connecter" OnClick="btnconnect_Click" />
		</form>
	</div>
	<div class="overlay-container">
		<div class="overlay">
			<div class="overlay-panel overlay-left">
				<h1>Welcome Back!</h1>
				<p>Enrez les informations necessaires pour vous connecter</p>
				<button class="ghost" id="signIn">Connectez-vous</button>
			</div>
			<div class="overlay-panel overlay-right">
				<h1>Bienvenue, Friend!</h1>
				<p>Enrez les informations necessaires pour vous connecter</p>
				<button class="ghost btn btn-outline-primary" id="signUp">Connectez-vous</button>
			</div>
		</div>
	</div>
</div>
           
<footer>
	   <section>
        <div class="col-12 text-center py-4 text-muted bg-dark">
            &copy; La réference 
            <script>
              document.write(new Date().getFullYear());
            </script>
            Copyright
          </div>
    </section>
</footer>

<script src="../assets/js/loginjs.js"></script>
<script src="../assets/js/script.js"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
    </body>
</html>

