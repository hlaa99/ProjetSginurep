<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreerUtilisateur.aspx.cs" Inherits="SGINUREP.Vue.CreerUtilisateur" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Creer utilisateur</title>
   <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
     <link rel="stylesheet" href="../assets/css/style.css"/>
     <link href='https://unpkg.com/boxicons@2.0.7/css/boxicons.min.css' rel='stylesheet'>
     <meta name="viewport" content="width=device-width, initial-scale=1.0">

     <!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous"/>
    <style type="text/css">
        .auto-style1 {
            border: 2px solid #0000FF;
            padding: 1px 4px;
        }
        .auto{
            right:10%;
        }
    </style>
</head>
<body class="m-0 p-0">

  <div class="sidebar m-0 p-0">
    <div class="logo-details m-0 p-0" >
      <i class='bx bxl-c-plus-plus icon'></i>
        <div class="logo_name ">SAU</div>
        <i class='bx bx-menu' id="btn" ></i>
    </div>
    <ul class="nav-list m-0 p-0" >
    
      <li>
        <a href="#">
          <i class='bx bx-home'></i>
          <span class="links_name" href="Admin.aspx" >Acceuil</span>
        </a>
         <span class="tooltip">Acceuil</span>
      </li>
      <li class="dropstart">
  <a class=" dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
   <i class='bx bx-user'></i>
          <span class="links_name">Etudiant</span>
  </a>

  <ul class="dropdown-menu shadow p-3 mb-5 rounded border border-info">
    <li><a class="dropdown-item text-light" href="Enregistreretudiant.aspx">Ajouter un etudiant</a></li>
     <li><a class="dropdown-item text-light " href="Modifieretudiant.aspx">Modifier etudiant</a></li>
    <li><a class="dropdown-item text-light" href="#">Dossier etudiant</a></li>
  </ul>
</li>
 <li class="dropstart">
  <a class=" dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
   <i class='bx bx-book'></i>
          <span class="links_name">Utilisateur</span>
  </a>

  <ul class="dropdown-menu shadow p-3 mb-5 rounded border border-info">
    <li><a class="dropdown-item text-light" href="CreeerUtilisateur.aspx">Ajouter un utilisateur</a></li>
     <li><a class="dropdown-item text-light " href="ModifierUtilisateur.aspx">Dossier utilisateur</a></li>
    <li><a class="dropdown-item text-light" href="ListesUtilisateur.aspx">Listes utilisateur</a></li>
  </ul>
</li>
     <li>
       <a href="#">
         <i class='bx bx-chat' ></i>
         <span class="links_name">Messages</span>
       </a>
       <span class="tooltip">Messages</span>
     </li>
     <li>
       <a href="#">
         <i class='bx bx-cog' ></i>
         <span class="links_name">Setting</span>
       </a>
       <span class="tooltip">Setting</span>
     </li>
     <li class="profile">
         
         <i class='bx bx-log-out' id="log_out" ></i>
     </li>
     <li>
     	
     </li>
    </ul>
  </div>
  <section class="home-section">
    <nav class="navbar navbar-expand-lg  bg-dark">
      <div class="container-fluid">
        <a class="navbar-brand" href="#">SYSTEME DE GESTION INUREP</a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarTogglerDemo02" aria-controls="navbarTogglerDemo02" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarTogglerDemo02">
          <ul class="navbar-nav me-auto mb-2 mb-lg-0">
            <li class="nav-item">
              <a class="nav-link active" aria-current="page" href="Admin.aspx">Home</a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="#">Link</a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="#">Disabled</a>
            </li>
          </ul>
          <form class="d-flex">
            <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search"/>
            <button class="btn btn-outline-success" type="submit">Recherche</button>
          </form>
        </div>
      </div>
    </nav>
     
<section class="order-form py-2 ">
    <div class="container">
        <h2 class="merriweather text-center bg-primary mb-4">Creer Utilisateur</h2>
        <form class="auto-style1" runat="server">
            <div class="row">
            <div class="col-md-4 col-sm">
               
              <div class="input-group mb-3">
                <label for="validationTooltip01" class="m-2">Motdepasse</label>
                  <asp:TextBox ID="tid" class="form-control" placeholder="****************" runat="server"></asp:TextBox>
              </div>

           </div>

            <div class="col-md-4 col-sm">
              <div class="input-group mb-3">
                <label for="validationTooltip01" class="m-2">Nom</label>
                  <asp:TextBox ID="tnom" class="form-control" placeholder="Entrez nom d'utilisateur " runat="server"></asp:TextBox>
              </div>
              </div>
            <div class="col-md-4 col-sm">
              <div class="input-group mb-3">
                 <label for="validationTooltip01" class="m-2">Prenom</label>
                  <asp:TextBox ID="tprenom" class="form-control" placeholder="Entrez le prenom d'utilisateur" runat="server"></asp:TextBox>
              </div>
              </div>
                 <div class="col-md-4 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Numero compte</label>
                  <asp:TextBox ID="tnum" class="form-control" placeholder="Entrez numero compte" runat="server"></asp:TextBox>
              </div>
              </div>
              <div class="col-md-4 col-sm">
                 
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Type utilisateur</label>
                  <asp:DropDownList ID="cmbtype" runat="server">
                      <asp:ListItem>Type utilisateur</asp:ListItem>
                      <asp:ListItem>Secretaire</asp:ListItem>
                      <asp:ListItem>Comptable</asp:ListItem>
                      <asp:ListItem>Anonyme</asp:ListItem>
                  </asp:DropDownList>
              </div>

            </div>

 </div>
            <div class="col-md-6 col-sm">
            <div class="input-group mb-3">
               
                <asp:Label ID="lmessage" ForeColor="#009900" runat="server" Text="@"></asp:Label>
              </div>
            </div>
            <div class="col-md-6 col-sm">
            <div class="input-group mb-3">
               
                <asp:Label ID="lerror" ForeColor="Red"  runat="server" Text="@"></asp:Label>
              </div>
            </div>
            <div class="row">
<div class="col-6">
    <div class="col-md-4 col-sm">
              <div class="input-group mb-3">
            
             <asp:Button ID="btncreer" runat="server" class="btn btn-primary" text="Enregistrer" Width="100px" OnClick="btncreer_Click"/>      

              </div>

            </div>
</div>
<div class="col-6">
    <div class="col-md-4 col-sm">
              <div class="input-group ms-3">
              <asp:Button ID="btnul" runat="server" class="btn btn-primary"  text="Cancel"  Width="100px" OnClick="btnul_Click"/>      
              </div>

            </div>
</div>
    </div>
        </form> 
         </div>
 
    </section>
    </section>
    <section>
        <div class="col-12 text-center py-4 text-muted">
            &copy; La réference 
            <script>
              document.write(new Date().getFullYear());
            </script>
            Copyright
          </div>
    </section>

       <div class="clear">
        </div>
    <script src="../assets/js/script.js"></script>
<!-- JavaScript Bundle with Popper -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj" crossorigin="anonymous"></script>

</body>
</html>
