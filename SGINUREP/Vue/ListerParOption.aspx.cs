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
    public partial class ListerParOption : System.Web.UI.Page
    {
        private ControlleurEtudiant etu = new ControlleurEtudiant();
        protected void Page_Load(object sender, EventArgs e)
        {
            AfficherPar();
        }
        void AfficherPar()
        {
            ListeEtudiants.DataSource = etu.GetListerEtudiantParoption(tre.Text);
            ListeEtudiants.DataBind();

        }
        protected void btnrechercher_Click1(object sender, EventArgs e)
        {
           if(tre.Text.Equals("discipline"))
            {
                AfficherPar();
            }
            else
            {
                lerror.Text = "Error!!!!,Le mot n'est pas correct !";
            }
        }

        protected void ListeEtudiants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void tre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}