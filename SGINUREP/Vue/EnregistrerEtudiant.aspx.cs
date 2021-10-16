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
    public partial class EnregistrerEtudiant : System.Web.UI.Page
    {
        ControlleurEtudiant controetu = new ControlleurEtudiant();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
     
        protected void btnEnregistre_Click(object sender, EventArgs e)
        {
            if (tnom.Text.Equals("") || tprenom.Text.Equals("") || cmbsexe.Text.Equals("") || tadresse.Text.Equals("") || tlieu.Text.Equals("") || tres.Text.Equals("") || cmbpiece.Text.Equals("") || cmbvacation.Text.Equals("") || tniveau.Text.Equals(""))
            {
                lmessage.Text = "Certains champs sont vides";
                lerror.Text = "Error!!!!,L'enregistrement n'est pas effectué";
            }
            else
            { 
            string codeet = controetu.CreerCode(tnom.Text, tprenom.Text);
            string modetu = controetu.CreerMotdepasse(tnom.Text, tprenom.Text);
            controetu.CreerEtudiant(codeet, tnom.Text, tprenom.Text, cmbsexe.Text, tadresse.Text, tnaiss.Text, tlieu.Text, cmbgroup.Text, treligion.Text, tres.Text, tage.Text, tphone.Text, tphone2.Text, tannee.Text, cmbpiece.Text, cmboption.Text, cmbtec.Text, cmbnatio.Text, cmbmod.Text, cmbvacation.Text, tniveau.Text, cmbetat.Text, temail.Text, tnifcin.Text, tdps.Text, tdescription.Text, modetu, "Actif");
            lmessage.Text = "Enregistrement effectué avec succes";
           }
            
            tnom.Text = "";
            tprenom.Text = "";
            cmbsexe.Text = "";
            tadresse.Text = "";
            tnaiss.Text = "";
            tlieu.Text = "";
            cmbgroup.Text = "";
            treligion.Text = "";
            tres.Text = "";
            tage.Text = "";
            tphone.Text = "";
            tphone2.Text = "";
            tannee.Text = "";
            cmbpiece.Text = "";
            cmboption.Text = "";
            cmbtec.Text = "";
            cmbnatio.Text = "";
            cmbmod.Text = "";
            cmbvacation.Text = "";
            tniveau.Text = "";
            cmbetat.Text = "";
            temail.Text = "";
            tdps.Text = "";
            tdescription.Text = "";
            tnifcin.Text = "";

        }

        protected void btnul_Click(object sender, EventArgs e)
        {

        }
    }
}