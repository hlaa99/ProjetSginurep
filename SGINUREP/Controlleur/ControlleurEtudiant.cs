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
    public class ControlleurEtudiant
    {
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;

        ModeleEtudiant etu;
        public ControlleurEtudiant()
        {
            etu = new ModeleEtudiant();
        }
        public void CreerEtudiant(string codeetudiant, string nom, string prenom, string sexe, string adresse, string datenaissance, string lieunaissance, string groupe_sanguin, string religion, string personne_responsable, string age, string telephone, string telephone_responsable, string anneeacademique, string type_piece, string discipline, string technique, string nationnalite, string modalite, string vacation, string niveau_etude, string etat_matrimoniale, string email, string nif_cin, string derniere_piece,string description, string motdepasse, string statut)
        {
            this.etu = new ModeleEtudiant(codeetudiant, nom, prenom, sexe, adresse, datenaissance, lieunaissance, groupe_sanguin, religion, personne_responsable, age, telephone, telephone_responsable, anneeacademique, type_piece, discipline, technique, nationnalite, modalite, vacation, niveau_etude, etat_matrimoniale, email, nif_cin, derniere_piece, description, motdepasse, statut);
            etu.CreerEtudiant();
        }
        public string CreerCode(string nom, string prenom)
        {
            return etu.CreerCodeEtudiant(nom, prenom);
        }
        public string CreerMotdepasse(string nom, string prenom)
        {
            return etu.CreerMotdepasseEtudiant(nom, prenom);
        }
        public void ModifierEtudiant(string codeetudiant,string nom, string prenom, string sexe, string adresse, string datenaissance, string lieunaissance, string groupe_sanguin, string religion, string personne_responsable, string age, string telephone, string telephone_responsable, string anneeacademique, string type_piece, string discipline, string technique, string nationnalite, string modalite, string vacation, string niveau_etude, string etat_matrimoniale, string email, string nif_cin, string derniere_piece,string description, string statut)
        {
            etu.ModifierEtudiant(codeetudiant, nom, prenom, sexe, adresse, datenaissance, lieunaissance, groupe_sanguin, religion, personne_responsable, age, telephone, telephone_responsable, anneeacademique, type_piece, discipline,technique, nationnalite, modalite, vacation, niveau_etude, etat_matrimoniale, email, nif_cin, derniere_piece, description, statut);

        }
        public DataSet GetListerEtudiant()
        {
            return (etu.ListerEtudiant());

        }
       
        public DataSet GetListerEtudiantParoption(string discipline)
        {
            return (etu.ListerEtudiantParoption(discipline));

        }
        public DataSet GetListerEtudiantParnom(string nom)
        {
            return (etu.ListerEtudiantParnom(nom));

        }


        public bool RechercheEtu(string codeetudiant)
        {
            return (etu.RechercheEtuPar(codeetudiant));


        }
        public string GetCodeetudiant()
        {
            if (etu != null)
                return etu.Codeetudiant;
            else
                return null;
        }
        public string GetNom()
        {
            if (etu != null)
                return etu.Nom;
            else
                return null;


        }

        public string GetPrenom()
        {
            if (etu != null)
                return etu.Prenom;
            else
                return null;


        }
        public string GetSexe()
        {
            if (etu != null)
                return etu.Sexe;
            else
                return null;


        }
        public string GetAdresse()
        {
            if (etu != null)
                return etu.Adresse;
            else
                return null;


        }
        public string GetDatenaissance()
        {
            if (etu != null)
                return etu.Datenaissance;
            else
                return null;
        }

        public string GetLieunaissance()
        {
            if (etu != null)
                return etu.Lieunaissance;
            else
                return null;


        }
        public string GetGroupe_sanguin()
        {
            if (etu != null)
                return etu.Groupe_sanguin;
            else
                return null;


        }
        public string GetReligion()
        {
            if (etu != null)
                return etu.Religion;
            else
                return null;


        }
        public string GetPersonne_responsable()
        {
            if (etu != null)
                return etu.Personne_responsable;
            else
                return null;


        }
        public string GetAge()
        {
            if (etu != null)
                return etu.Age;
            else
                return null;


        }


        public string GetTelephone()
        {
            if (etu != null)
                return etu.Telephone;
            else
                return null;


        }

        public string GetTelephone_responsable()
        {
            if (etu != null)
                return etu.Telephone_responsable;
            else
                return null;


        }


        public string GetAnneeacademique()
        {
            if (etu != null)
                return etu.Anneeacademique;
            else
                return null;


        }
        public string GetType_piece()
        {
            if (etu != null)
                return etu.Type_piece;
            else
                return null;


        }
        public string GetDiscipline()
        {
            if (etu != null)
                return etu.Discipline;
            else
                return null;


        }
        public string GetTechnique()
        {
            if (etu != null)
                return etu.Technique;
            else
                return null;


        }
        public string GetNationnalite()
        {
            if (etu != null)
                return etu.Nationnalite;
            else
                return null;


        }

        public string GetModalite()
        {
            if (etu != null)
                return etu.Modalite;
            else
                return null;


        }

        public string GetVacation()
        {
            if (etu != null)
                return etu.Vacation;
            else
                return null;


        }

        public string GetNiveau_etude()
        {
            if (etu != null)
                return etu.Niveau_etude;
            else
                return null;


        }
        public string GetEtat_matrimoniale()
        {
            if (etu != null)
                return etu.Etat_matrimoniale;
            else
                return null;


        }
        public string GetEmail()
        {
            if (etu != null)
                return etu.Email;
            else
                return null;


        }
 
        public string GetNif_cin()
        {
            if (etu != null)
                return etu.Nif_cin;
            else
                return null;


        }
        public string GetDerniere_piece()
        {
            if (etu != null)
                return etu.Derniere_piece;
            else
                return null;


        }
 public string GetDescription()
        {
            if (etu != null)
                return etu.Description;
            else
                return null;


        }
        public string GetSatut()
        {
            if (etu != null)
                return etu.Statut;
            else
                return null;


        }


    }
}