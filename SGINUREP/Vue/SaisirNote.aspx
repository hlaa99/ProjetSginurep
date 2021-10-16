﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SaisirNote.aspx.cs" Inherits="SGINUREP.Vue.SaisirNote" %>

<!DOCTYPE html>

<html lang="en" dir="ltr">
  <head>
    <meta charset="UTF-8">
    <title>Notes</title>
    <link rel="stylesheet" href="../assets/css/style.css">
    <!-- Boxicons CDN Link -->
    <link href='https://unpkg.com/boxicons@2.0.7/css/boxicons.min.css' rel='stylesheet'>
     <meta name="viewport" content="width=device-width, initial-scale=1.0">

     <!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous">
      <style type="text/css">
          .auto-style1 {
              border: 3px solid #0F96E4;
              padding: 1px 4px;
          }
      </style>
   </head>
<body class="m-0 p-0">

  <div class="sidebar m-0 p-0">
    <div class="logo-details m-0 p-0" >
      <i class='bx bxl-c-plus-plus icon'></i>
        <div class="logo_name ">SGINUREP</div>
        <i class='bx bx-menu' id="btn" ></i>
    </div>
    <ul class="nav-list m-0 p-0" >
    
      <li>
        <a href="#">
          <i class='bx bx-home'></i>
          <span class="links_name">Acceuil</span>
        </a>
         <span class="tooltip">Acceuil</span>
      </li>
      <li class="dropstart">
  <a class=" dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
   <i class='bx bx-user'></i>
          <span class="links_name">Etudiant</span>
  </a>

  <ul class="dropdown-menu shadow p-3 mb-5 rounded border border-info">
    <li><a class="dropdown-item text-light" href="EnregistrerEtudiant.aspx">Ajouter un etudiant</a></li>
     <li><a class="dropdown-item text-light " href="DossierEtudiant.aspx">Dossier etudiant</a></li>
    <li><a class="dropdown-item text-light" href="ListesEtudiant.aspx">Liste etudiant</a></li>
     <li><a class="dropdown-item text-light" href="ListesParOption.aspx">Liste etudiant par option</a></li>
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
              <a class="nav-link active" aria-current="page" href="#">Home</a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="#">Link</a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="#">Disabled</a>
            </li>
          </ul>
          <form class="d-flex">
            <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
            <button class="btn btn-outline-primary" type="submit">Recherche</button>
          </form>
        </div>
      </div>
    </nav>
      <section>

       <section class="order-form py-2 ">
    <div class="auto-style1">
        <h2 class="merriweather text-center bg-primary mb-4">Saisir notes</h2>
        <form class="auto-style1" runat="server">
            <div class="row">
     
                  <div class="col-md-6 col-sm">
            <div class="input-group mb-3">
                 <asp:TextBox ID="tid" placeholder="Rechercher un etudiant" runat="server"></asp:TextBox>
                  <asp:Button ID="btnrechercher" runat="server" class="btn btn-primary" Text="Rechercher" Width="100px" OnClick="btnRechercher_Click" />      

              </div>
            </div>
            <div class="col-md-6 col-sm">
                 <div class="input-group mb-3">
                <label for="validationTooltip01" class="m-2">Nom de l'etudiant</label>
                  <asp:TextBox ID="tnom" class="form-control" placeholder="Nom etudiant" runat="server"></asp:TextBox>
               </div>
                 </div>
               <div class="col-md-6 col-sm">
                   <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Code cours</label>
                  <asp:TextBox ID="tcode" class="form-control" placeholder="" runat="server"></asp:TextBox>
              </div>
                 </div>
                  <div class="col-md-6 col-sm">
                   <div class="input-group mb-3">
                 <label for="validationTooltip01" class="m-2">Niveau</label>
                  <asp:DropDownList ID="ddniveau" runat="server">
                      <asp:ListItem>1er Annee</asp:ListItem>
                      <asp:ListItem>2eme Annee</asp:ListItem>
                      <asp:ListItem>3eme Annee</asp:ListItem>
                      <asp:ListItem>4trieme Annee</asp:ListItem>
                  </asp:DropDownList>             

                   </div>
                 </div>
                 <div class="col-md-6 col-sm">
                  <div class="input-group mb-3">
                <label for="validationTooltip01" class="m-2">Annee academique</label>
                 <asp:TextBox ID="tannee" class="form-control" placeholder="Entrez annee academique" runat="server"></asp:TextBox>
                </div>
                 </div>

     <div class="col-md-6 col-sm">
                  <div class="input-group mb-3">
                <label for="validationTooltip01" class="m-2">Nom cours</label>
                      <asp:DropDownList ID="ddcour" runat="server">
                      <asp:ListItem>Java</asp:ListItem>
                      <asp:ListItem>Csharp</asp:ListItem>
                      <asp:ListItem>Anglais</asp:ListItem>
                      <asp:ListItem>Francais</asp:ListItem>
                  </asp:DropDownList>                           

                  </div>
                 </div>
<div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Intra</label>
                  <asp:TextBox ID="tintra" class="form-control" placeholder="" runat="server"></asp:TextBox> 
                  </div>
              </div>
              <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Final</label>
                  <asp:TextBox ID="tfinal" class="form-control" placeholder="" runat="server"></asp:TextBox> 
                  </div>
              </div>
               <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Session</label>
                     <asp:DropDownList ID="ddsession" runat="server">
                      <asp:ListItem>1ere Session</asp:ListItem>
                      <asp:ListItem>2ème Session</asp:ListItem>
                  </asp:DropDownList>                

              </div>
              </div>
              <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Total</label>
                  <asp:TextBox ID="ttotal" class="form-control" placeholder="" runat="server"></asp:TextBox> 
                  </div>
              </div>  
 
              <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Moyenne</label>
                  <asp:TextBox ID="tmoy" class="form-control"  placeholder="" runat="server"></asp:TextBox> 
                  </div>
              </div> 
               <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Mention</label>
                  <asp:TextBox ID="tmention" class="form-control"  placeholder="" runat="server"></asp:TextBox> 
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
            
             <asp:Button ID="btncreer" runat="server" class="btn btn-primary" text="Enregistrer" Width="100px" OnClick="btncreer_Click"/>      

              </div>
</div>
<div class="col-6">
    <div class="col-md-4 col-sm">
              <asp:Button ID="btnul" runat="server" class="btn btn-primary"  text="Cancel"  Width="100px" OnClick="btnul_Click"/>      
              </div>
</div>
    </div>
        </form> 
         </div>
 
    </section>
      </section>
      </section>
    <section>
        <div class="col-12 text-center py-4 text-muted bg-dark">
            &copy; La réference 
            <script>
              document.write(new Date().getFullYear());
            </script>
            Copyright
          </div>
    </section>
  <script src="../assets/js/script.js"></script>
<!-- JavaScript Bundle with Popper -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj" crossorigin="anonymous"></script>
</body>
</html>

