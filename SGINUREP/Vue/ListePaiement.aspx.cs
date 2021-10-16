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
    public partial class ListePaiement : System.Web.UI.Page
    {
        private ControlleurPaiement paie = new ControlleurPaiement();
        protected void Page_Load(object sender, EventArgs e)
        {
            Afficher();
        }
        void Afficher()
        {
            Listepaiement.DataSource = paie.GetListesPaiement();
            Listepaiement.DataBind();
        }

        protected void Listepaiement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}