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
    public class ModeleCours
    {
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;
       

        private DataSet data;
        private string codecours;
        private string professeur;
        private string coefficient;
        private string session;
        private string discipline;
        private string technique;
        private string niveau;
        private string nomcours;


        public ModeleCours(string codecours, string professeur, string coefficient, string session, string discipline, string technique, string niveau, string nomcours)
        {

            this.codecours = codecours;
            this.professeur = professeur;
            this.coefficient = coefficient;
            this.session = session;
            this.discipline = discipline;
            this.technique = technique;
            this.niveau = niveau;
            this.nomcours = nomcours;


        }
        public ModeleCours() : this(null, null, null, null, null, null, null, null)
        {
        }

        public string Codecours
        {
            get { return this.codecours; }
            set { this.codecours = value; }

        }
        public string Professeur
        {
            get { return this.professeur; }
            set { this.professeur = value; }

        }
        public string Coefficient
        {
            get { return this.coefficient; }
            set { this.coefficient = value; }

        }
        public string Session
        {
            get { return this.session; }
            set { this.session = value; }

        }
        public string Niveau
        {
            get { return this.niveau; }
            set { this.niveau = value; }

        }
        public string Discipline
        {
            get { return this.discipline; }
            set { this.discipline = value; }

        }
        public string Technique
        {
            get { return this.technique; }
            set { this.technique = value; }

        }
        public string Nomcours
        {
            get { return this.nomcours; }
            set { this.nomcours = value; }

        }

        public void CreerCours()
        {

            string chReq = string.Format("insert into tbcours values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}') ", codecours, professeur, coefficient, session,discipline,technique, niveau, nomcours);
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(chReq, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public string CreerCodeCours(string nomcours, string professeur)
        {
            string nombreetu;
            string codeco;
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM tbcours", con);
            con.Open();
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count > 0)
            {
                nombreetu = Convert.ToString(count.ToString());
            }
            else
            {
                nombreetu = "0";
            }
            con.Close();

            codeco = nomcours.Substring(0, 2) + professeur.Substring(0, 1) + "-" + nombreetu;
            return codeco;

        }
        public bool Recherchecours(string nomcours)
        {

            string chReq = string.Format("select * from tbcours where  nomcours='{0}'", nomcours);

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


                    professeur = reader[1].ToString();
                    coefficient = reader[2].ToString();
                    session = reader[3].ToString();
                    discipline = reader[4].ToString();
                    technique = reader[5].ToString();
                    niveau = reader[6].ToString();
                    nomcours = reader[7].ToString();


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
        public void ModifierCours(string professeur, string coefficient, string session, string discipline, string technique, string niveau, string nomcours)
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string chReq = string.Format("update tbcours set professeur='{1}',coefficient='{2}', session='{3}',discipline='{4}',technique='{5}', niveau='{6}' where nomcours='{0}'", nomcours, professeur, coefficient, session, discipline, technique, niveau);
            SqlCommand cmd = new SqlCommand(chReq, con);
            cmd.ExecuteNonQuery();
            con.Close();



        }
    //Lister toutes les cours 
    public DataSet ListesCours()
    {

        SqlDataAdapter adapter;
        SqlConnection con;
        con = new SqlConnection(strcon);
        string command = string.Format("Select * from tbcours");
        con.Open();
        adapter = new SqlDataAdapter(command, con);
        SqlCommandBuilder cmdBldr = new SqlCommandBuilder(adapter);
        data = new DataSet();
        adapter.Fill(data, "tbcours");
        con.Close();
        return data;
    }
}
}
