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
    public partial class DossierPaiement : System.Web.UI.Page
    {
        ControlleurPaiement contropaie = new ControlleurPaiement();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void Recherche()
        {
            bool trouves = contropaie.RecherchePaiement(tre.Text);
            if (!trouves)
            {
                lmessage.Text = ("Le cours n'existe pas");

            }
            else
            {


                tid.Text = contropaie.GetCodeetudiant();
                tnom.Text = contropaie.GetNom();
                tsomme.Text = contropaie.GetSommede();
                tsommep.Text = contropaie.GetSomme_pour();
                tbalance.Text = contropaie.GetBalance();
                cmbtype.Text = contropaie.GetType_paiement();
                tdate.Text = contropaie.GetDate_paiement();



            }
        }


        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            Recherche();
        }

        protected void btncreer_Click(object sender, EventArgs e)

        {
            try
            {
                contropaie.ModifierPaiement(tid.Text, tnom.Text, tsomme.Text, tsommep.Text, tbalance.Text, cmbtype.Text, tdate.Text);
                lmessage.Text = "Enregistrement effectué avec succes";
            }
            catch
            {
                lerror.Text = "Error!!!!,L'enregistrement n'est pas effectué";
            }
        }

        protected void btnul_Click(object sender, EventArgs e)
        {

        }
    }
}