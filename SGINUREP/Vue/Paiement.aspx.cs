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
    public partial class Paiement : System.Web.UI.Page
    {
        ControlleurPaiement contropaie = new ControlleurPaiement();
        ControlleurEtudiant con = new ControlleurEtudiant();
        protected void Page_Load(object sender, EventArgs e)
        {

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
        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            Recherche();
        }

        protected void btncreer_Click(object sender, EventArgs e)
        {
            /* double somme = Convert.ToDouble(tsomme.Text) - Convert.ToDouble(tbalance.Text);
             tbalance.Text = somme.ToString(); */
            if (tid.Text.Equals("") || tnom.Text.Equals("") || tsomme.Text.Equals("") || tsommep.Text.Equals("")|| cmbtype.Text.Equals("")|| tdate.Text.Equals(""))
             {
                 lmessage.Text = "Certains champs sont vides";
                 lerror.Text = "Error!!!!,L'enregistrement n'est pas effectué";
             }
             else
             {
                contropaie.CreerPaiement(tid.Text, tnom.Text, tsomme.Text, tsommep.Text, tbalance.Text, cmbtype.Text, tdate.Text);
                lmessage.Text = "Enregistrement effectué avec succes";
             }

             tid.Text=""; 
             tnom.Text = "";
             tsomme.Text = "";
             tsommep.Text = "";
             cmbtype.Text = "";

         }
             

        protected void btnul_Click(object sender, EventArgs e)
        {

        }
    }
}