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
    public partial class ModifierUtilisateur : System.Web.UI.Page
    {
        ControlleurUtilisateur controuti = new ControlleurUtilisateur();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void Rechercher()
        {
            bool trouves = controuti.Rechercheuti(trecherche.Text);
            if (!trouves)
            {
                lmessage.Text = ("Cet utilisateur n'existe pas");

            }
            else
            {

                tnom.Text = controuti.GetNom();
                tprenom.Text = controuti.GetPrenom();
                tnum.Text = controuti.GetNocompte();
                cmbtype.Text = controuti.GetType_utilisateur();
                cmbetat.Text = controuti.GetEtat_utilisateur();


            }
        }
        protected void btnrechercher_Click(object sender, EventArgs e)
        {
            Rechercher();
        }
        protected void btncreer_Click(object sender, EventArgs e)
        {
            try
            {
                controuti.ModifierUtilisateur(trecherche.Text, tnom.Text, tprenom.Text, tnum.Text, cmbtype.Text, cmbetat.Text);
                lmessage.Text = "Enregistrement effectué avec succes";
            }
            catch
            {
                lerror.Text = "Error!!!!,Enregistrement n'est pas effectué";
            }
        }

        protected void btnul_Click(object sender, EventArgs e)
        {

        }

       
    }
}