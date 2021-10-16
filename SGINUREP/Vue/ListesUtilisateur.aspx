﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListesUtilisateur.aspx.cs" Inherits="SGINUREP.Vue.ListesUtilisateur" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Listes utilisateur</title>
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
    <li><a class="dropdown-item text-light" href="Listesetudiant.aspx">Liste etudiant</a></li>
    <li><a class="dropdown-item text-light" href="#">Dossier etudiant</a></li>
  </ul>
</li>
 <li class="dropstart">
  <a class=" dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
   <i class='bx bx-book'></i>
          <span class="links_name">Cours</span>
  </a>

  <ul class="dropdown-menu shadow p-3 mb-5 rounded border border-info">
    <li><a class="dropdown-item text-light" href="CreerUtilisateur">Ajouter un utilisateur</a></li>
     <li><a class="dropdown-item text-light" href="ModifierUtilisateur"">Dossier utilisateur</a></li>
    <li><a class="dropdown-item text-light" href="ListeUtilisateur"">Listes utilisateur</a></li>

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
            <button class="btn btn-outline-primary" type="submit">Recherche</button>
          </form>
        </div>
      </div>
    </nav>
     
<section class="order-form py-2 ">
    <div class="container">
        <h2 class="merriweather text-center bg-primary mb-4">Listes Utilisateur</h2>
        <form class="auto-style1" runat="server">
            <div class="row">
            <div class="card-body">
              <asp:GridView ID="ListesUtilisateurs" runat="server" BackColor="Blue" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" CssClass="table table-bordered table-sm" OnSelectedIndexChanged="ListesUtilisateurs_SelectedIndexChanged">
                  <AlternatingRowStyle BackColor="White" />            
                  <FooterStyle BackColor="#3333CC" />
                  <HeaderStyle BackColor="Blue" Font-Bold="True" ForeColor="White" />
                  <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                  <RowStyle BackColor="#F7F7DE" />
                  <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                  <SortedAscendingCellStyle BackColor="#FBFBF2" />
                  <SortedAscendingHeaderStyle BackColor="#848384" />
                  <SortedDescendingCellStyle BackColor="#EAEAD3" />
                  <SortedDescendingHeaderStyle BackColor="#575357" />
              </asp:GridView>

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
