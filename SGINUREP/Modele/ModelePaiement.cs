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
    public class ModelePaiement
    {
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;

        private DataSet data;
        
        private string codeetudiant;
        private string nom;
        private string sommede;
        private string somme_pour;
        private string balance;
        private string type_paiement;
        private string date_paiement;
        public ModelePaiement(string codeetudiant, string nom, string sommede, string somme_pour, string balance, string type_paiement, string date_paiement)
        {

            
            this.codeetudiant = codeetudiant;
            this.nom = nom;
            this.sommede = sommede;
            this.somme_pour = somme_pour;
            this.balance = balance;
            this.type_paiement = type_paiement;
            this.date_paiement = date_paiement;


        }
        public ModelePaiement() : this(null, null, null, null, null, null, null)
        {
        }
   
        public string Codeetudiant
        {
            get { return this.codeetudiant; }
            set { this.codeetudiant = value; }

        }
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }

        }
        public string Sommede
        {
            get { return this.sommede; }
            set { this.sommede = value; }

        }
        public string Somme_pour
        {
            get { return this.somme_pour; }
            set { this.somme_pour = value; }

        }
        public string Balance
        {
            get { return this.balance; }
            set { this.balance = value; }

        }
        public string Type_paiement
        {
            get { return this.type_paiement; }
            set { this.type_paiement = value; }

        }
        public string Date_paiement
        {
            get { return this.date_paiement; }
            set { this.date_paiement = value; }

        }
        public void CreerPaiement()
        {

            string chReq = string.Format("insert into tbpaiement values('{0}','{1}','{2}','{3}','{4}','{5}','{6}') ", codeetudiant,  nom, sommede, somme_pour, balance, type_paiement, date_paiement);
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(chReq, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        public bool RechercherPaiement(string idpaiement)
        {

            string chReq = string.Format("select * from tbpaiement where  idpaiement='{0}'", idpaiement);

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

                    codeetudiant=reader[1].ToString();
                    nom = reader[2].ToString();
                    sommede = reader[3].ToString();
                    somme_pour = reader[4].ToString();
                    balance = reader[5].ToString();
                    type_paiement = reader[6].ToString();
                    date_paiement = reader[7].ToString();


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
        public void ModifierPaiement(string codeetudiant, string nom, string sommede, string somme_pour, string balance, string type_paiement, string date_paiement)
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string chReq = string.Format("update tbpaiement set nom='{1}', sommede='{2}',somme_pour='{3}',balance='{4}', type_paiement='{5}',date_paiement='{6}' where codeetudiant='{0}'", codeetudiant, nom, sommede, somme_pour, balance, type_paiement, date_paiement);
            SqlCommand cmd = new SqlCommand(chReq, con);
            cmd.ExecuteNonQuery();
            con.Close();



        }
        //Lister toutes les Paiement 
        public DataSet ListesPaiement()
        {

            SqlDataAdapter adapter;
            SqlConnection con;
            con = new SqlConnection(strcon);
            string command = string.Format("Select * from tbpaiement");
            con.Open();
            adapter = new SqlDataAdapter(command, con);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(adapter);
            data = new DataSet();
            adapter.Fill(data, "tbpaiement");
            con.Close();
            return data;
        }

    }
}