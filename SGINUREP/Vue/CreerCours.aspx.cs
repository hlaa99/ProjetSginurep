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
    public partial class CreerCous : System.Web.UI.Page
    {
        ControlleurCours controcours = new ControlleurCours();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncreer_Click(object sender, EventArgs e)
        {
         
            if (tprofe.Text.Equals("") || tcoe.Text.Equals("") || cmbsession.Text.Equals("") || tnomc.Text.Equals(""))
            {
                lmessage.Text = "Certains champs sont vides";
                lerror.Text = "Error!!!!,L'enregistrement n'est pas effectué";
            }
            else
            {
                string codec = controcours.CreerCode(tprofe.Text, tnomc.Text);
                controcours.CreerCours(codec, tprofe.Text, tcoe.Text, cmbsession.Text, cmboption.Text, cmbtec.Text, cmbniveau.Text, tnomc.Text);
                lmessage.Text = "Enregistrement effectué avec succes";
            }

            tprofe.Text = "";
            tcoe.Text = "";
            cmbsession.Text = "";
            cmbniveau.Text = "";
            cmboption.Text = "";
            cmbtec.Text = "";
            tnomc.Text = "";


        }

        protected void btnul_Click(object sender, EventArgs e)
        {

        }
    }
}