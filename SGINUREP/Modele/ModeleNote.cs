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
    public class ModeleNote
    {
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;
       

        private DataSet data;
        private string codeetudiant;
        private string codecours;
        private string niveau;
        private string anneeacademique;
        private string cours;
        private string intra;
        private string final;
        private string session;
        private string total;
        private string moyenne;
        private string mention;




        public ModeleNote(string codeetudiant, string codecours, string niveau, string anneeacademique, string cours, string intra, string final, string session, string total,string moyenne,string mention)
        {

            this.codeetudiant = codeetudiant;
            this.codecours = codecours; ;
            this.niveau = niveau;
            this.anneeacademique = anneeacademique;
            this.cours = cours;
            this.intra = intra;
            this.final = final;
            this.session = session;
            this.total = total;
            this.moyenne = moyenne;
            this.mention = mention;


        }
        public ModeleNote() : this( null, null, null, null, null, null, null, null, null, null, null)
        {
        }

        public string Codeetudiant
        {
            get { return this.codeetudiant; }
            set { this.codeetudiant = value; }

        }
        public string Codecours
        {
            get { return this.codecours; }
            set { this.codecours = value; }

        }

        public string Niveau
        {
            get { return this.niveau; }
            set { this.niveau = value; }

        }
        public string Anneeacademique
        {
            get { return this.anneeacademique; }
            set { this.anneeacademique = value; }

        }
        public string Cours
        {
            get { return this.cours; }
            set { this.cours = value; }

        }
        public string Intra
        {
            get { return this.intra; }
            set { this.intra = value; }

        }
        public string Final
        {
            get { return this.final; }
            set { this.final = value; }

        }
        public string Session
        {
            get { return this.session; }
            set { this.session = value; }

        }
        public string Total
        {
            get { return this.total; }
            set { this.total = value; }

        }

        public string Moyenne
        {
            get { return this.moyenne; }
            set { this.moyenne = value; }

        }
        public string Mention
        {
            get { return this.mention; }
            set { this.mention = value; }

        }
        public void SaisirNotes()
        {

            string chReq = string.Format("insert into tbnotes values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}') ", codeetudiant, codecours, niveau, anneeacademique, cours, intra, final, session, total, moyenne, mention);
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(chReq, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public bool RechercheNotes(string codenote)
        {

            string chReq = string.Format("select * from tbnotes where  codenote='{0}'", codenote);

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



                    codeetudiant = reader[1].ToString();
                    niveau = reader[2].ToString();
                    anneeacademique = reader[3].ToString();
                    cours = reader[4].ToString();
                    intra = reader[5].ToString();
                    final = reader[6].ToString();
                    session = reader[7].ToString();
                    total = reader[8].ToString();


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
        public void ModifierNotes(string codeetudiant, string codecours, string niveau, string anneeacademique, string cours, string intra, string final, string session, string total, string moyenne, string mention)
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string chReq = string.Format("update tbnote set codeetudiant='{0}', codecours='{1}', niveau='{2}', anneeacademique='{3}',cours='{4}',intra='{5}',final='{6}',session='{7}',total='{8}',moyenne='{9}',mention='{10}' where idnote='{0}'", codecours, niveau, anneeacademique, cours, intra, final, session, total,moyenne, mention);
            SqlCommand cmd = new SqlCommand(chReq, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
    }
}