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
    public partial class CreerUtilisateur : System.Web.UI.Page
    {
        ControlleurUtilisateur controuti = new ControlleurUtilisateur();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncreer_Click(object sender, EventArgs e)
        {
           
            if (tnom.Text.Equals("") || tprenom.Text.Equals("") || tnum.Text.Equals("") || cmbtype.Text.Equals(""))
            {
                lmessage.Text = "Certains champs sont vides";
                lerror.Text = "Error!!!!,L'enregistrement n'est pas effectué";
            }
            else
            {
                string codeuti = controuti.CreerCode(tnom.Text, tprenom.Text);
                string moduti = controuti.CreerMotdepasse(tnom.Text, tnum.Text);
                controuti.CreerUtilisateur(codeuti, tnom.Text, tprenom.Text, tnum.Text, cmbtype.Text, moduti, "Actif");
                lmessage.Text = "Enregistrement effectué avec succes";
            }

            tnom.Text = "";
            tprenom.Text = "";
            tnum.Text = "";
            cmbtype.Text = "";

        }
        protected void btnul_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}