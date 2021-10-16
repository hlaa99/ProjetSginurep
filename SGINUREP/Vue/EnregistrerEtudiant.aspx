<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnregistrerEtudiant.aspx.cs" Inherits="SGINUREP.Vue.EnregistrerEtudiant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
   <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
     <link rel="stylesheet" href="../assets/css/style.css"/>
     <link href='https://unpkg.com/boxicons@2.0.7/css/boxicons.min.css' rel='stylesheet'/>
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
        .auto-style2 {
            border: 4px solid #0F96E4;
            padding: 1px 4px;
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
     
<section class="auto-style2">
    <div class="container">
        <h2 class="merriweather text-center bg-primary mb-4">Enregistrer un etudiant</h2>
        <form class="auto-style1" runat="server">
            <div class="row">
            <div class="col-md-6 col-sm">
               
              <div class="input-group mb-3">
                <label for="validationTooltip01" class="m-2">Code etudiant</label>
                  <asp:TextBox ID="tid" class="form-control" placeholder="****************" runat="server"></asp:TextBox>
              </div>

           </div>

            <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
                <label for="validationTooltip01" class="m-2">Nom</label>
                  <asp:TextBox ID="tnom" class="form-control" placeholder="Entrez votre nom" runat="server"></asp:TextBox>
              </div>
              </div>
            <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
                 <label for="validationTooltip01" class="m-2">Prenom</label>
                  <asp:TextBox ID="tprenom" class="form-control" placeholder="Entrez votre prenom" runat="server"></asp:TextBox>
              </div>
              </div>
                 <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
                 <label for="validationTooltip01" class="m-2">Choisir votre sexe</label>
                      <asp:DropDownList ID="cmbsexe" runat="server">
                      <asp:ListItem>Masculin</asp:ListItem>
                      <asp:ListItem>Feminin</asp:ListItem>
                      <asp:ListItem>Autres</asp:ListItem>
                  </asp:DropDownList>              </div>
              </div>
                 <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Adresse</label>
                  <asp:TextBox ID="tadresse" class="form-control" placeholder="Entrez Adresse" runat="server"></asp:TextBox>
              </div>
              </div>
               <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Datenaissance</label>
                  <asp:TextBox ID="tnaiss" class="form-control" TextMode="Date" placeholder="Entrez date naissance" runat="server"></asp:TextBox>
              </div>
              </div>
               <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Lieu naissance</label>
               <asp:TextBox ID="tlieu" class="form-control" placeholder="Entrez lieu naissance" runat="server"></asp:TextBox>
              </div>
              </div>
              <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Groupe sanguin</label>
                      <asp:DropDownList ID="cmbgroup" runat="server">
                      <asp:ListItem>O+</asp:ListItem>
                      <asp:ListItem>A-</asp:ListItem>
                      <asp:ListItem>A+</asp:ListItem>
                  </asp:DropDownList>          

              </div>
              </div>
              <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Religion</label>
                  <asp:TextBox ID="treligion" class="form-control" placeholder="Entrez votre religion" runat="server"></asp:TextBox>
              </div>
              </div>
               <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Personne responsable</label>
                  <asp:TextBox ID="tres" class="form-control" placeholder="Personne responsable" runat="server"></asp:TextBox>
              </div>
              </div>
               <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Age</label>
                  <asp:TextBox ID="tage" class="form-control" placeholder="Entrez age" runat="server"></asp:TextBox>
              </div>
              </div>
              <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
                   <label for="validationTooltip01" class="m-2">Telephone</label>
                   <asp:TextBox ID="tphone" class="form-control" TextMode="Phone" placeholder="Telephone" runat="server"></asp:TextBox>
              </div>

            </div>
             <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
           <label for="validationTooltip01" class="m-2">Telephone responsable</label>
                  <asp:TextBox ID="tphone2" class="form-control" TextMode="Phone" placeholder="Telephone responsable" runat="server"></asp:TextBox>
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
               <label for="validationTooltip01" class="m-2">Type piece</label>
               <asp:DropDownList ID="cmbpiece" runat="server">
                      <asp:ListItem>Original acte de naissance </asp:ListItem>
                      <asp:ListItem>Copie acte de naissance </asp:ListItem>
                       <asp:ListItem>Original pasport </asp:ListItem>
                      <asp:ListItem>Copie pasport</asp:ListItem>
                    <asp:ListItem>Autres</asp:ListItem>
                  </asp:DropDownList>      
              </div>
              </div>
              <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Discipline</label>
                  <asp:DropDownList ID="cmboption" runat="server">
                       <asp:ListItem>Aucun</asp:ListItem>
                      <asp:ListItem>Sciences informatique(4 ans)</asp:ListItem>
                      <asp:ListItem>Techn.Informatique(DUT)(3 ans)</asp:ListItem>
                      <asp:ListItem>Programation(2 ans)</asp:ListItem>
                      <asp:ListItem>Informatique Bureautique(9 mois)</asp:ListItem>
                      <asp:ListItem>Depannage d'ordinateur(6 mois)</asp:ListItem>
                      <asp:ListItem>Reseaux(12 mois)</asp:ListItem>
                      <asp:ListItem>Infographie(12 mois)</asp:ListItem>
                      <asp:ListItem>Sciences infirmières</asp:ListItem>
                      <asp:ListItem>Sciences Comptables</asp:ListItem>
                      <asp:ListItem>Sciences administratives</asp:ListItem>
                      <asp:ListItem>Sciences de la gestion</asp:ListItem>
                      <asp:ListItem>Sciences de l'education</asp:ListItem>
                      

                  </asp:DropDownList>
              </div>

              </div>
         <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Technique/Professionnelle</label>
                  <asp:DropDownList ID="cmbtec" runat="server">
                      <asp:ListItem>Aucun</asp:ListItem>
                      <asp:ListItem>Auto-ecole(3 mois)</asp:ListItem>
                      <asp:ListItem>Cosmetologie(9 mois)</asp:ListItem>
                      <asp:ListItem>Cuisine-pâtisserie(9 mois)</asp:ListItem>
                      <asp:ListItem>Décoration gateaux(6 mois)</asp:ListItem>
                      <asp:ListItem>Décor.Evènementielle(9 mois)</asp:ListItem>
                      <asp:ListItem>Anglais(12 mois)</asp:ListItem>
                      <asp:ListItem>Francais(12 mois)</asp:ListItem>
                      

                  </asp:DropDownList>
              </div>

              </div>

              <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Modalite</label>
                  <asp:DropDownList ID="cmbmod" runat="server">
                      <asp:ListItem>Bourse</asp:ListItem>
                      <asp:ListItem>Demi-bourse</asp:ListItem>
                      <asp:ListItem>Paiement</asp:ListItem>
                  </asp:DropDownList>
              </div>

              </div>
                
              <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Nationalite</label>
                  <asp:DropDownList ID="cmbnatio" runat="server">
                            <asp:ListItem>Haitienne</asp:ListItem>
                            <asp:ListItem>Americaine</asp:ListItem>
                            <asp:ListItem>Canadienne</asp:ListItem>
                            <asp:ListItem>Dominicaine</asp:ListItem>
                            <asp:ListItem>Cubain</asp:ListItem>
                            <asp:ListItem>Chilienne</asp:ListItem>
                            <asp:ListItem>Japonaise</asp:ListItem>
                        </asp:DropDownList>
              </div>

              </div>
              <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
               <label for="validationTooltip01" class="m-2">Vacation</label>
                  <asp:DropDownList ID="cmbvacation" runat="server">
                      <asp:ListItem>Matin</asp:ListItem>
                      <asp:ListItem>Median</asp:ListItem>
                      <asp:ListItem>Week-end</asp:ListItem>
                  </asp:DropDownList>
              </div>
</div>
              <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
                   <label for="validationTooltip01" class="m-2">Niveau d'etude</label>
                   <asp:TextBox ID="tniveau" class="form-control"  placeholder="Niveau d'etude" runat="server"></asp:TextBox>
              </div>
 </div>
              <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
                   <label for="validationTooltip01" class="m-2">Etat matrimoniale</label>
                  <asp:DropDownList ID="cmbetat" runat="server">
                      <asp:ListItem>Mariée</asp:ListItem>
                      <asp:ListItem>Divorcé</asp:ListItem>
                      <asp:ListItem>Celibataire</asp:ListItem>
                  </asp:DropDownList>              

              </div>
      </div>
          <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
                   <label for="validationTooltip01" class="m-2">Adresse electronique</label>
                   <asp:TextBox ID="temail" class="form-control"  placeholder="Email" runat="server"></asp:TextBox>
              </div>
              </div>
                <div class="col-md-6 col-sm">
              <div class="input-group mb-3">
                   <label for="validationTooltip01" class="m-2">Numero nif/cin</label>
                   <asp:TextBox ID="tnifcin" class="form-control"  placeholder="Numero nif/cin" runat="server"></asp:TextBox>
              </div>
      </div>
<div class="col-md-6 col-sm">
              <div class="input-group mb-3">
                   <label for="validationTooltip01" class="m-2">Derniere pièces scolaires</label>
                   <asp:TextBox ID="tdps" class="form-control"  placeholder="Derniere pièces scolaires" runat="server"></asp:TextBox>
              </div>
    </div>
    <div class="col-12 col-sm">
              <div class="input-group mb-3">
                   <label for="validationTooltip01" class="m-2">Description</label>
                   <asp:TextBox ID="tdescription" class="form-control"  runat="server" Font-Bold="True" Font-Italic="True" MaxLength="200" TextMode="MultiLine"></asp:TextBox>
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
    <div class="col-6 col-sm">
    <div class="col-md-4 col-sm">
              <div class="input-group mb-3">
            
             <asp:Button ID="btnEnregistre" runat="server" class="btn btn-primary" text="Enregistrer" Width="100px" OnClick="btnEnregistre_Click"/>      

              </div>

            </div>
</div>
<div class="col-6 col-sm">
    <div class="col-md-4 col-sm">
              <div class="input-group ms-3">
              <asp:Button ID="btnul" runat="server" class="btn btn-primary"  text="Cancel"  Width="100px" OnClick="btnul_Click"/>      
              </div>

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
