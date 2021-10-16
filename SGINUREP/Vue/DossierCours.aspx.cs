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
    public partial class ModifierCours : System.Web.UI.Page
    {
        ControlleurCours contromo = new ControlleurCours();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void Recherche()
        {
            bool trouves = contromo.Recherchecours(trecherche.Text);
            if (!trouves)
            {
                lmessage.Text = ("Le cours n'existe pas");

            }
            else
            {


                tprofe.Text = contromo.GetProfesseur();
                tcoe.Text = contromo.GetCoefficient();
                cmbsession.Text = contromo.GetSession();
                cmboption.Text = contromo.GetDiscipline();
                cmbtec.Text = contromo.GetTechnique();
                cmbniveau.Text = contromo.GetNiveau();
               


            }
        }

        protected void btnrechercher_Click(object sender, EventArgs e)
        {
            Recherche();
        }

       
        protected void btnul_Click(object sender, EventArgs e)
        {

        }

        protected void btnmodifier_Click(object sender, EventArgs e)
        {
            contromo.ModifierCours(tprofe.Text, tcoe.Text, cmbsession.Text, cmboption.Text, cmbtec.Text, cmbniveau.Text, trecherche.Text);
            lmessage.Text = "La modification  est effectué !!!";
        }
    }
}