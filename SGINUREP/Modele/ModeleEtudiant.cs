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
    public class ModeleEtudiant
    {
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;

        private DataSet data;
        private string codeetudiant;
        private string nom;
        private string prenom;
        private string sexe;
        private string adresse;
        private string datenaissance;
        private string lieunaissance;
        private string groupe_sanguin;
        private string religion;
        private string personne_responsable;
        private string age;
        private string telephone;
        private string telephone_responsable;
        private string anneeacademique;
        private string type_piece;
        private string discipline;
        private string technique;
        private string nationnalite;
        private string modalite;
        private string vacation;
        private string niveau_etude;
        private string etat_matrimoniale;
        private string email;
        private string nif_cin;
        private string derniere_piece;
        private string description;
        private string motdepasse;
        private string statut;


        public ModeleEtudiant(string codeetudiant, string nom, string prenom, string sexe, string adresse, string datenaissance, string lieunaissance, string groupe_sanguin, string religion, string personne_responsable, string age, string telephone, string telephone_responsable, string anneeacademique, string type_piece, string discipline, string technique, string nationnalite, string modalite, string vacation, string niveau_etude, string etat_matrimoniale, string email, string nif_cin, string derniere_piece,string description, string motdepasse, string statut)
        {

            this.codeetudiant = codeetudiant;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.adresse = adresse;
            this.datenaissance = datenaissance;
            this.lieunaissance = lieunaissance;
            this.groupe_sanguin = groupe_sanguin;
            this.religion = religion;
            this.personne_responsable = personne_responsable;
            this.age = age;
            this.telephone = telephone;
            this.telephone_responsable = telephone_responsable;
            this.anneeacademique = anneeacademique;
            this.type_piece = type_piece;
            this.discipline = discipline;
            this.technique = technique;
            this.nationnalite = nationnalite;
            this.modalite = modalite;
            this.vacation = vacation;
            this.niveau_etude = niveau_etude;
            this.etat_matrimoniale = etat_matrimoniale;
            this.email = email;
            this.nif_cin = nif_cin;
            this.derniere_piece = derniere_piece;
            this.description = description;
            this.motdepasse = motdepasse;
            this.statut = statut;
        }
        public ModeleEtudiant() : this(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null)
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
        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }

        }
        public string Sexe
        {
            get { return this.sexe; }
            set { this.sexe = value; }

        }
        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }

        public string Datenaissance
        {
            get { return this.datenaissance; }
            set { this.datenaissance = value; }
        }
        public string Lieunaissance
        {
            get { return this.lieunaissance; }
            set { this.lieunaissance = value; }
        }
        public string Groupe_sanguin
        {
            get { return this.groupe_sanguin; }
            set { this.groupe_sanguin = value; }
        }
        public string Religion
        {
            get { return this.religion; }
            set { this.religion = value; }
        }
        public string Personne_responsable
        {
            get { return this.personne_responsable; }
            set { this.personne_responsable = value; }
        }
        public string Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }

        }

        public string Telephone_responsable
        {
            get { return this.telephone_responsable; }
            set { this.telephone_responsable = value; }

        }
        public string Anneeacademique
        {
            get { return this.anneeacademique; }
            set { this.anneeacademique = value; }

        }
        public string Type_piece
        {
            get { return this.type_piece; }
            set { this.type_piece = value; }

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
        public string Nationnalite
        {
            get { return this.nationnalite; }
            set { this.nationnalite = value; }

        }

        public string Modalite
        {
            get { return this.modalite; }
            set { this.modalite = value; }

        }
        public string Vacation
        {
            get { return this.vacation; }
            set { this.vacation = value; }

        }
        public string Niveau_etude
        {
            get { return this.niveau_etude; }
            set { this.niveau_etude = value; }

        }
        public string Etat_matrimoniale
        {
            get { return this.etat_matrimoniale; }
            set { this.etat_matrimoniale = value; }

        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }

        }

        public string Nif_cin
        {
            get { return this.nif_cin; }
            set { this.nif_cin = value; }

        }
        public string Derniere_piece
        {
            get { return this.derniere_piece; }
            set { this.derniere_piece=value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public string Motdepasse
        {
            get { return this.motdepasse; }
            set { this.motdepasse = value; }

        }


        public string Statut
        {
            get { return this.statut; }
            set { this.statut = value; }

        }

        public void CreerEtudiant()
        {

            string chReq = string.Format("insert into tbetudiants values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}') ", codeetudiant, nom, prenom, sexe, adresse, datenaissance, lieunaissance, groupe_sanguin, religion, personne_responsable, age, telephone, telephone_responsable, anneeacademique, type_piece, discipline, technique, nationnalite, modalite, vacation, niveau_etude, etat_matrimoniale, email, nif_cin, derniere_piece,description, motdepasse, statut);
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(chReq, con);
            cmd.ExecuteNonQuery();
            // lmessage.Text = "Enregistrement effectue avec Succes";
            con.Close();
        }
        public string CreerCodeEtudiant(string nom, string prenom)
        {
            string nocompt;
            string codeuti;
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM tbetudiants", con);
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
        public string CreerMotdepasseEtudiant(string nom, string prenom)
        {
            string numcompt;
            string modetu;
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM tbetudiants", con);
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

            modetu = nom.Substring(0, 2) + prenom.Substring(0, 2) + "-" + numcompt;
            return modetu;

        }
        //Methodes pour rechercher un etudiant par code
       
        //Methodes pour rechercher un etudiant par nom
        public bool RechercheEtuPar(string codeetudiant)
        {

            string chReq = string.Format("select * from tbetudiants where  codeetudiant='{0}'", codeetudiant);

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
                    sexe = reader[3].ToString();
                    adresse = reader[4].ToString();
                    datenaissance = reader[5].ToString();
                    lieunaissance = reader[6].ToString();
                    groupe_sanguin = reader[7].ToString();
                    religion = reader[8].ToString();
                    personne_responsable = reader[9].ToString();
                    age = reader[10].ToString();
                    telephone = reader[11].ToString();
                    telephone_responsable = reader[12].ToString();
                    anneeacademique = reader[13].ToString();
                    type_piece = reader[14].ToString();
                    discipline = reader[15].ToString();
                    technique = reader[16].ToString();
                    nationnalite = reader[17].ToString();
                    modalite = reader[18].ToString();
                    vacation = reader[19].ToString();
                    niveau_etude = reader[20].ToString();
                    etat_matrimoniale = reader[21].ToString();
                    email = reader[22].ToString();
                    nif_cin = reader[23].ToString();
                    derniere_piece = reader[24].ToString();
                    description = reader[25].ToString();
                    statut = reader[26].ToString();

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

        public void ModifierEtudiant(string codeetudiant, string nom, string prenom, string sexe, string adresse, string datenaissance, string lieunaissance, string groupe_sanguin, string religion, string personne_responsable, string age, string telephone, string telephone_responsable, string anneeacademique, string type_piece, string discipline, string technique, string nationnalite, string modalite, string vacation, string niveau_etude, string etat_matrimoniale, string email, string nif_cin, string derniere_piece, string description, string statut)
        {
            SqlConnection con = new SqlConnection(strcon);
            string chReq = string.Format("update tbetudiants set nom='{1}', prenom='{2}', sexe='{3}', adresse='{4}',datenaissance='{5}', lieunaissance='{6}',groupe_sanguin='{7}',religion='{8}',personne_responsable='{9}',age='{10}', telephone='{11}', telephone_responsable='{12}',anneeacademique='{13}',type_piece='{14}', discipline='{15}',technique='{16}',nationnalite='{17}', modalite='{18}', vacation='{19}',niveau_etude='{20}',etat_matrimoniale='{21}', email='{22}',nif_cin='{23}',derniere_piece='{24}',description='{25}',statut='{26}' where  codeetudiant='{0}'", codeetudiant, nom, prenom, sexe, adresse, datenaissance, lieunaissance, groupe_sanguin, religion, personne_responsable, age, telephone, telephone_responsable, anneeacademique, type_piece, discipline,technique, nationnalite, modalite, vacation, niveau_etude, etat_matrimoniale, email, nif_cin, derniere_piece, description, statut);
            con.Open();
            SqlCommand cmd = new SqlCommand(chReq, con);
            cmd.ExecuteNonQuery();


        }
        //Lister toutes les etudiants 
        public DataSet ListerEtudiant()
        {

            SqlDataAdapter adapter;
            SqlConnection con;
            con = new SqlConnection(strcon);
            string command = string.Format("Select nom,prenom,sexe,adresse,datenaissance,telephone,discipline,technique,nationnalite,modalite,vacation,statut from tbetudiants");
            con.Open();
            adapter = new SqlDataAdapter(command, con);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(adapter);
            data = new DataSet();
            adapter.Fill(data, "tbetudiants");
            con.Close();
            return data;
        }
        //Lister les etudiants par leur Discipline
        public DataSet ListerEtudiantParoption(string discipline)
        {

            SqlDataAdapter adapter;
            SqlConnection con;
            con = new SqlConnection(strcon);
            string command = string.Format("Select codeetudiant,nom,prenom,sexe,adresse,datenaissance,telephone,discipline,nationnalite,modalite,vacation,email,statut from tbetudiants where discipline='{0}'", discipline);
            con.Open();
            adapter = new SqlDataAdapter(command, con);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(adapter);
            data = new DataSet();
            adapter.Fill(data, "tbetudiants");
            con.Close();
            return data;
        }
        //Lister les etudiants par leur nom
        public DataSet ListerEtudiantParnom(string nom)
        {

            SqlDataAdapter adapter;
            SqlConnection con;
            con = new SqlConnection(strcon);
            string command = string.Format("Select codeetudiant,nom,prenom,sexe,adresse,datenaissance,telephone,discipline,modalite,email,statut from tbetudiants where nom='{0}'", nom);
            con.Open();
            adapter = new SqlDataAdapter(command, con);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(adapter);
            data = new DataSet();
            adapter.Fill(data, "tbetudiants");
            con.Close();
            return data;
        }
    }
}