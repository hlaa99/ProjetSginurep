using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using SGINUREP.Controlleur;
using SGINUREP.Modele;
using SGINUREP.Vue;


namespace SGINUREP.Vue
{
    public partial class SaisirNote : System.Web.UI.Page
    {
        ControlleurNote contronote = new ControlleurNote();
        ControlleurEtudiant con = new ControlleurEtudiant();
        ControlleurCours controcours = new ControlleurCours();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
           
        }
        void Recherche()
        {
            bool trouves = con.RechercheEtu(tid.Text);
            if (!trouves)
            {
                lerror.Text = ("Cet etudiant n'existe pas");

            }
            else
            {

                tnom.Text = con.GetNom() + " " + con.GetPrenom();


            }
        }

        public void CDropdown()
        {
            ddcour.DataSource = controcours.GetListesCours();
            ddcour.DataBind();
            ddcour.DataTextField = "ddcour";
            ddcour.DataValueField = "codecour";
            ddcour.DataBind();
        }

        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            Recherche();
        }

        protected void btncreer_Click(object sender, EventArgs e)
        {
            
           double somme = Convert.ToDouble(tintra.Text) + Convert.ToDouble(tfinal.Text);
           ttotal.Text = somme.ToString();
           contronote.SaisirNotes(tnom.Text,tcode.Text, ddniveau.Text,tannee.Text,ddcour.Text,tintra.Text,tfinal.Text,ddsession.Text,ttotal.Text,tmoy.Text,tmention.Text);
           lmessage.Text = "Enregistrement effectué avec succes";  
    
    
        }

        protected void btnul_Click(object sender, EventArgs e)
        {

        }
    }
}