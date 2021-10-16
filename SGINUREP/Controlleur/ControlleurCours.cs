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
    public class ControlleurCours
    {
       
            string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;

            ModeleCours cours;
            public ControlleurCours()
            {
            cours = new ModeleCours();
            }
            public void CreerCours(string codecours,string professeur, string coefficient, string session, string discipline, string technique, string niveau, string nomcours)
        {
            this.cours = new ModeleCours(codecours,professeur, coefficient, session,discipline,technique, niveau, nomcours);
            cours.CreerCours();
        }
            public string CreerCode(string nomcours, string professeur)
            {
                return cours.CreerCodeCours(nomcours, professeur);
            }
        public void ModifierCours( string professeur, string coefficient, string session, string discipline, string technique, string niveau, string nomcours)
        {
            cours.ModifierCours(professeur, coefficient, session, discipline, technique, niveau, nomcours);

        }
        public DataSet GetListesCours()
        {
            return (cours.ListesCours());

        }
        public bool Recherchecours(string nomcours)
        {
            return (cours.Recherchecours(nomcours));


        }



        public string GetProfesseur()
        {
            if (cours != null)
                return cours.Professeur;
            else
                return null;


        }
        public string GetCoefficient()
        {
            if (cours != null)
                return cours.Coefficient;
            else
                return null;


        }
        public string GetSession()
        {
            if (cours != null)
                return cours.Session;
            else
                return null;


        }
        public string GetDiscipline()
        {
            if (cours != null)
                return cours.Discipline;
            else
                return null;


        }
        public string GetTechnique()
        {
            if (cours != null)
                return cours.Technique;
            else
                return null;


        }

        public string GetNiveau()
        {
            if (cours != null)
                return cours.Niveau;
            else
                return null;


        }
        public string GetNomcours()
        {
            if (cours != null)
                return cours.Nomcours;
            else
                return null;


        }
    }
}