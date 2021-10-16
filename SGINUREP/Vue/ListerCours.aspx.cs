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
    public partial class ListerCours : System.Web.UI.Page
    {
        private ControlleurCours co = new ControlleurCours();
        protected void Page_Load(object sender, EventArgs e)
        {
            Afficher();
        }
        void Afficher()
        {
            ListeCours.DataSource = co.GetListesCours();
            ListeCours.DataBind();
        }

        protected void ListeCours_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}