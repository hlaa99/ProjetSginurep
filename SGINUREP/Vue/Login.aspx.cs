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
    public partial class Login : System.Web.UI.Page
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
                string query = "select * from tbutilisateur where codeutilisateur='" + uid + "' and motdepasse='" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    tcode.Text = sdr["codeutilisateur"].ToString();
                    Session["codeutilisateur"] = tcode.Text;
                    Response.Redirect("Dashboard.aspx");
                }


            }
            catch (Exception ex)
            {
                lmessage.Text = "Code ou Mot de passe  inccorect";
            }
        }
        void Connecter()
        {
            if (tcode.Text.Equals("Admin") || tpass.Text.Equals("Admin"))
            {
                Response.Redirect("Admin.aspx");
            }
            else
            {

                lmessage.Text = "Code ou Mot de passe  inccorect";
            }

        }

        protected void btnconnect_Click(object sender, EventArgs e)
        {
            if (tcode.Text.Equals("Admin") || tpass.Text.Equals("pass"))
            {
                Connecter();
            }


            else
            {

                Loginuser();

            }
        }
    }
}
