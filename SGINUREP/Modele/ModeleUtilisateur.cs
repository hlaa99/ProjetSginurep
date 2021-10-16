using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using SGINUREP.Controlleur;
using SGINUREP.Modele;
using SGINUREP.Vue;

namespace SGINUREP.Modele
{
    public class ModeleUtilisateur
    {
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;
        private DataSet data;
        private string codeutilisateur;
        private string nom;
        private string prenom;
        private string nocompte;
        private string type_utilisateur;
        private string motdepasse;
        private string etat_utilisateur;

        public ModeleUtilisateur(string codeutilisateur, string nom, string prenom, string nocompte,string type_utilisateur, string motdepasse, string etat_utilisateur)
        {

            this.codeutilisateur = codeutilisateur;
            this.nom = nom;
            this.prenom = prenom;
            this.nocompte = nocompte;
            this.type_utilisateur = type_utilisateur;
            this.motdepasse = motdepasse;
            this.etat_utilisateur = etat_utilisateur;
        }
        public ModeleUtilisateur() : this(null,null, null, null, null, null, null)
        {
        }
        public string Codeutilisateur
        {
            get { return this.codeutilisateur; }
            set { this.codeutilisateur = value; }

        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }


        }
        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }

        }
        public string Nocompte
        {
            get { return this.nocompte; }
            set { this.nocompte = value; }

        }
       
        public string Type_utilisateur
        {
            get { return this.type_utilisateur; }
            set { this.type_utilisateur = value; }

        }
        public string Motdepasse
        {
            get { return this.motdepasse; }
            set { this.motdepasse = value; }

        }
        public string Etat_utilisateur
        {
            get { return this.etat_utilisateur; }
            set { this.etat_utilisateur = value; }

        }

        public void CreerUtilisateur()
        {

            string chReq = string.Format("insert into tbutilisateur values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", codeutilisateur, nom, prenom, nocompte, type_utilisateur, motdepasse, etat_utilisateur);
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(chReq, con);
            cmd.ExecuteNonQuery();
            // lmessage.Text = "Enregistrement effectue avec Succes";
            con.Close();
        }


        public string CreerCodeUtilisateur(string nom, string prenom)
        {
            string nocompt;
            string codeuti;
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM tbutilisateur", con);
            con.Open();
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count > 0)
            {
                nocompt = Convert.ToString(count.ToString());
            }
            else
            {
                nocompt = "0";
            }
            con.Close();

            codeuti = nom.Substring(0, 2) + prenom.Substring(0, 1) + "-" + nocompt;
            return codeuti;

        }
        public string CreerMotdepasseUtilisateur(string nom, string nocompte)
        {
            string numcompt;
            string moduti;
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM tbutilisateur", con);
            con.Open();
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count > 0)
            {
                numcompt = Convert.ToString(count.ToString());
            }
            else
            {
                numcompt = "0";
            }
            con.Close();

            moduti = nom.Substring(0, 2) + nocompte.Substring(0, 1) + "-" + numcompt;
            return moduti;

        }

        public bool Rechercheuti(string codeutilisateur)
        {

            string chReq = string.Format("select * from tbutilisateur where  codeutilisateur='{0}'", codeutilisateur);

            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = null;

            bool trouve = false;

            try
            {
                con.Open();
                cmd = new SqlCommand(chReq, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    nom = reader[1].ToString();
                    prenom = reader[2].ToString();
                    nocompte = reader[3].ToString();
                    type_utilisateur = reader[4].ToString();
                    etat_utilisateur = reader[5].ToString();




                    trouve = true;
                }

                reader.Close();
                con.Close();
                return trouve;
            }
            catch (Exception)
            {

                return trouve;
            }

        }
        public void ModifierUtilisateur(string codeutilisateur,string nom, string prenom, string nocompte, string type_utilisateur, string etat_utilisateur)
        {
            SqlConnection con = new SqlConnection(strcon);
            string chReq = string.Format("update tbutilisateur set  nom='{1}', prenom='{2}', nocompte='{3}', type_utilisateur='{4}', etat_utilisateur='{5}' where codeutilisateur='{0}'", codeutilisateur, nom, prenom, nocompte, type_utilisateur, etat_utilisateur);
            con.Open();
            SqlCommand cmd = new SqlCommand(chReq, con);
            cmd.ExecuteNonQuery();


        }
        public DataSet ListerUtilisateur()
        {

            SqlDataAdapter adapter;
            SqlConnection con;
            con = new SqlConnection(strcon);
            string command = string.Format("Select * from tbutilisateur");
            con.Open();
            adapter = new SqlDataAdapter(command, con);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(adapter);
            data = new DataSet();
            adapter.Fill(data, "tbutilisateur");
            con.Close();
            return data;
        }

    }
}
