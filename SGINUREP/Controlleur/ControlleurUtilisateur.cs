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
namespace SGINUREP.Controlleur
{
    public class ControlleurUtilisateur
    {
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;

        ModeleUtilisateur uti;
        public ControlleurUtilisateur()
        {
            uti = new ModeleUtilisateur();
        }
        public void CreerUtilisateur(string codeutilisateur, string nom, string prenom, string nocompte, string type_utilisateur,string motdepasse, string etat_utilisateur)
        {
            this.uti = new ModeleUtilisateur(codeutilisateur, nom, prenom, nocompte, type_utilisateur, motdepasse, etat_utilisateur);
            uti.CreerUtilisateur();
        }
        public string CreerCode(string nom, string prenom)
        {
            return uti.CreerCodeUtilisateur(nom, prenom);
        }
        public string CreerMotdepasse(string nom, string nocompte)
        {
            return uti.CreerMotdepasseUtilisateur(nom, nocompte);
        }

        public void ModifierUtilisateur(string codeutilisateur, string nom, string prenom, string nocompte, string type_utilisateur, string etat_utilisateur)
        {
            uti.ModifierUtilisateur(codeutilisateur, nom, prenom, nocompte, type_utilisateur, etat_utilisateur);

        }
        public DataSet GetListerUtilisateur()
        {
            return (uti.ListerUtilisateur());

        }
        public bool Rechercheuti(string codeutilisateur)
        {
            return (uti.Rechercheuti(codeutilisateur));


        }

       

        public string GetNom()
        {
            if (uti != null)
                return uti.Nom;
            else
                return null;


        }

        public string GetPrenom()
        {
            if (uti != null)
                return uti.Prenom;
            else
                return null;


        }
        public string GetNocompte()
        {
            if (uti != null)
                return uti.Nocompte;
            else
                return null;


        }

        public string GetType_utilisateur()
        {
            if (uti != null)
                return uti.Type_utilisateur;
            else
                return null;


        }
        public string GetEtat_utilisateur()
        {
            if (uti != null)
                return uti.Etat_utilisateur;
            else
                return null;


        }
    }
}