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
  
    public class ControlleurPaiement
    {
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;

        ModelePaiement paie;
        public ControlleurPaiement()
        {
            paie = new ModelePaiement();
        }
        public void CreerPaiement(string codeetudiant, string nom, string sommede, string somme_pour, string balance, string type_paiement, string date_paiement)
        {
            this.paie = new ModelePaiement(codeetudiant, nom, sommede, somme_pour, balance, type_paiement, date_paiement);
            paie.CreerPaiement();
        }    
        public void ModifierPaiement( string codeetudiant, string nom, string sommede, string somme_pour, string balance, string type_paiement, string date_paiement)
        {
            paie.ModifierPaiement(codeetudiant, nom, sommede, somme_pour, balance, type_paiement, date_paiement);

        }
         public DataSet GetListesPaiement()
          {
              return (paie.ListesPaiement());

          }

        public bool RecherchePaiement(string idpaiement)
        {
            return (paie.RechercherPaiement(idpaiement));


        }

        public string GetCodeetudiant()
        {
            if (paie != null)
                return paie.Codeetudiant;
            else
                return null;


        }
        public string GetNom()
        {
            if (paie != null)
                return paie.Nom;
            else
                return null;


        }
        public string GetSommede()
        {
            if (paie != null)
                return paie.Sommede;
            else
                return null;


        }
        public string GetSomme_pour()
        {
            if (paie != null)
                return paie.Somme_pour;
            else
                return null;


        }

        public string GetBalance()
        {
            if (paie != null)
                return paie.Balance;
            else
                return null;


        }
        public string GetType_paiement()
        {
            if (paie != null)
                return paie.Type_paiement;
            else
                return null;


        }
        public string GetDate_paiement()
        {
            if (paie != null)
                return paie.Date_paiement;
            else
                return null;


        }

    }
}