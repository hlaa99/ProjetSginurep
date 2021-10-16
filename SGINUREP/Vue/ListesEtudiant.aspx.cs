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
    public partial class ListerEtudiant : System.Web.UI.Page
    {
        private ControlleurEtudiant etu = new ControlleurEtudiant();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Afficher();
            }
        }
        void Afficher()
        {
            ListeEtudiants.DataSource = etu.GetListerEtudiant();
            ListeEtudiants.DataBind();
        }

        protected void ListeEtudiants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}