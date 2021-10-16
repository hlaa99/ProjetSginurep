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
    public partial class LoginEtudiant : System.Web.UI.Page
    {

        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;
        ControlleurUtilisateur controuti = new ControlleurUtilisateur();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void Loginuser()
        {

            try
            {
                string uid = tcode.Text;
                string pass = tpass.Text;
                SqlConnection con = new SqlConnection(strcon);
                string query = "select * from tbetudiants where codeetudiant='" + uid + "' and motdepasse='" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    tcode.Text = sdr["codeetudiant"].ToString();
                    Session["codeetudiant"] = tcode.Text;
                    Response.Redirect("ListerEtudiant.aspx");
                }


            }
            catch (Exception ex)
            {
                lmessage.Text = "Code ou Mot de passe  inccorect";
            }
        }
        protected void btnconnect_Click(object sender, EventArgs e)
        {

            if (tcode.Text.Equals("") || tpass.Text.Equals(""))
            {
                lmessage.Text = "Cetains champs sont vides";
            }


            else
            {

                Loginuser();

            }
        }
    }
}