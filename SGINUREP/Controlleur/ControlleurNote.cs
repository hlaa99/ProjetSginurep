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
    public class ControlleurNote
    {
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;
        ModeleNote notes;
        public ControlleurNote()
        {
            notes = new ModeleNote();
        }
        public void SaisirNotes(string codeetudiant, string codecours, string niveau, string anneeacademique, string cours, string intra, string final, string session, string total, string moyenne, string mention)
        {
            this.notes = new ModeleNote(codeetudiant, codecours, niveau, anneeacademique, cours, intra, final, session, total,moyenne, mention);
            notes.SaisirNotes();
        }
        public void ModifierNotes(string codeetudiant, string codecours, string niveau, string anneeacademique, string cours, string intra, string final, string session, string total, string moyenne, string mention)
        {
            notes.ModifierNotes(codeetudiant, codecours, niveau, anneeacademique, cours, intra, final, session, total, moyenne, mention);

        }
        public bool RechercheNotes(string codenote)
        {
            return (notes.RechercheNotes(codenote));


        }


        public string GetCodeetudiant()
        {
            if (notes != null)
                return notes.Codeetudiant;
            else
                return null;

        }
        public string GetCodecours()
        {
            if (notes != null)
                return notes.Codecours;
            else
                return null;

        }

        public string GetNiveau()
        {
            if (notes != null)
                return notes.Niveau;
            else
                return null;

        }
        public string GetAnneeacademique()
        {
            if (notes != null)
                return notes.Anneeacademique;
            else
                return null;

        }
        public string GetCours()
        {
            if (notes != null)
                return notes.Cours;
            else
                return null;

        }
        public string GetIntra()
        {
            if (notes != null)
                return notes.Intra;
            else
                return null;

        }
        public string GetFinal()
        {
            if (notes != null)
                return notes.Final;
            else
                return null;

        }
        public string GetSession()
        {
            if (notes != null)
                return notes.Session;
            else
                return null;

        }
        public string GetTotal()
        {
            if (notes != null)
                return notes.Total;
            else
                return null;

        }
        public string GetMoyenne()
        {
            if (notes != null)
                return notes.Moyenne;
            else
                return null;

        }
        public string GetMention()
        {
            if (notes != null)
                return notes.Mention;
            else
                return null;

        }

    }
}