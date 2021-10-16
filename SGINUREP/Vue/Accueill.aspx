<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Accueill.aspx.cs" Inherits="SGINUREP.Vue.Accueill" %>

<!DOCTYPE html>

<html lang="en" dir="ltr">
  <head>
    <meta charset="UTF-8">
    <title>Accueil</title>
    <link rel="stylesheet" href="../assets/css/style.css">
    <!-- Boxicons CDN Link -->
    <link href='https://unpkg.com/boxicons@2.0.7/css/boxicons.min.css' rel='stylesheet'>
     <meta name="viewport" content="width=device-width, initial-scale=1.0">
       
     <!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous">
 
   </head>
<body >
  <section class="container-fluid">
  <nav class="navbar navbar-expand-lg  bg-dark">
      <div class="container">
          <div class="logo">
              <asp:Image ID="Image1" runat="server" ImageUrl="../assets/img/logo.jpg" Height="57px" />
          </div>
        <a class="navbar-brand" href="#">SYSTEME DE GESTION INUREP</a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarTogglerDemo02" aria-controls="navbarTogglerDemo02" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarTogglerDemo02">
             <ul class="navbar-nav me-auto mb-2 mb-lg-0">
            <li class="nav-item" runat="server">
              <a class="nav-link" href="Login.aspx" >Connectez-vous</a>
            </li>
                 <li class="nav-item" runat="server">
              <a class="nav-link" href="LoginEtudiant.aspx" >Eudiant</a>
            </li>
           
          </ul>
          <form class="d-flex " runat="server">
              <asp:TextBox ID="trecherche" runat="server"></asp:TextBox>
            <button class="btn btn-outline-primary" type="submit">Recherche</button>
          </form>
          
        </div>
      </div>
    </nav>
      <section>

<div class="row py-0">
<div class="card my-5 border-0 rounded-0">
<div class="row">
<div class="col-md-6">
<div class="card-body px-0">
									<h3 class="card-title">Description</h3>
									<p class="card-text">
										Lorem ipsum, dolor sit amet consectetur adipisicing elit. Vel aliquid maiores asperiores sint
										doloribus eligendi odio nostrum quod, aperiam placeat eaque dolor libero provident beatae neque
										obcaecati quidem tempore debitis.
									</p>
									<p class="card-text"><a href="#" class="btn text-muted">Découvrir le met</a></p>
								</div>
		
</div>
          <div class="col-md-6  my-2">
             
								<div id="carouselExampleControls" class="carousel slide" data-bs-ride="carousel">
									<div class="carousel-inner">
										<div class="carousel-item active">
											<img src="../assets/img/etudiant.jpg" class="d-block w-100" alt="..." />
										</div>
										<div class="carousel-item">
											<img src="../assets/img/etudiant2.jpg" class="d-block w-100" alt="..." />
										</div>
										<div class="carousel-item">
											<img src="../assets/img/etudiant.jpg" class="d-block w-100" alt="..." />
										</div>
									</div>
									<button
										class="carousel-control-prev"
										type="button"
										data-bs-target="#carouselExampleControls"
										data-bs-slide="prev"
									>
										<span class="carousel-control-prev-icon" aria-hidden="true"></span>
										<span class="visually-hidden">Previous</span>
									</button>
									<button
										class="carousel-control-next"
										type="button"
										data-bs-target="#carouselExampleControls"
										data-bs-slide="next"
									>
										<span class="carousel-control-next-icon" aria-hidden="true"></span>
										<span class="visually-hidden">Next</span>
									</button>
								</div>
							</div>
						</div>
					</div>
				</div>
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
