using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using SGINUREP.Controlleur;
using SGINUREP.Modele;
using SGINUREP.Vue;

namespace SGINUREP.Vue
{
    public partial class DossierEtudiant : System.Web.UI.Page
    {
        ControlleurEtudiant controetu = new ControlleurEtudiant();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
   

        void Rechercher()
        {
            bool trouves = controetu.RechercheEtu(trecherche.Text);
            if (!trouves)
            {
                lmessage.Text = ("Cet etudiant n'existe pas");


            }
            else
            {
                tnom.Text = controetu.GetNom();
                tprenom.Text = controetu.GetPrenom();
                cmbsexe.Text = controetu.GetSexe();
                tadresse.Text = controetu.GetAdresse();
                tnaiss.Text = controetu.GetDatenaissance();
                tlieu.Text = controetu.GetLieunaissance();
                cmbgroup.Text = controetu.GetGroupe_sanguin();
                treligion.Text = controetu.GetReligion();
                tres.Text = controetu.GetPersonne_responsable();
                tage.Text = controetu.GetAge();
                tphone.Text = controetu.GetTelephone();
                tphone2.Text = controetu.GetTelephone_responsable();
                tannee.Text = controetu.GetAnneeacademique();
                cmbpiece.Text = controetu.GetTechnique(); ;
                cmboption.Text = controetu.GetDiscipline();
                cmbtec.Text = controetu.GetTechnique();
                cmbnatio.Text = controetu.GetNationnalite();
                cmbmod.Text = controetu.GetModalite();
                cmbvacation.Text = controetu.GetVacation();
                tniveau.Text = controetu.GetNiveau_etude();
                cmbetat.Text = controetu.GetEtat_matrimoniale();
                temail.Text = controetu.GetEmail();
                tdps.Text = controetu.GetDerniere_piece();
                tdescription.Text = controetu.GetDescription();
                tnifcin.Text = controetu.GetNif_cin();
                cmbstatut.Text = controetu.GetSatut();

            }
        }
        protected void btnRechercher_Click(object sender, EventArgs e)
        {
           
                Rechercher();
           
            
        }

        protected void btnEnregistre_Click(object sender, EventArgs e)
        {
            if (tprenom.Text.Equals(""))
            {
                lmessage.Text = "Certains champs sont vides";
                lerror.Text = "Error!!!!,La modification n'est pas effectué";
            }
            else
            {
                
                controetu.ModifierEtudiant(trecherche.Text, tnom.Text, tprenom.Text, cmbsexe.Text, tadresse.Text, tnaiss.Text, tlieu.Text, cmbgroup.Text, treligion.Text, tres.Text, tage.Text, tphone.Text, tphone2.Text, tannee.Text, cmbpiece.Text, cmboption.Text, cmbtec.Text, cmbnatio.Text, cmbmod.Text, cmbvacation.Text, tniveau.Text, cmbetat.Text, temail.Text, tnifcin.Text, tdps.Text, tdescription.Text, cmbstatut.Text);
                lmessage.Text = "Enregistrement effectué avec succes";
            }

           
            tprenom.Text = "";
            cmbsexe.Text = "";
            tadresse.Text = "";
            tnaiss.Text = "";
            tlieu.Text = "";
            cmbgroup.Text = "";
            treligion.Text = "";
            tres.Text = "";
            tage.Text = "";
            tphone.Text = "";
            tphone2.Text = "";
            tannee.Text = "";
            cmbpiece.Text = "";
            cmboption.Text = "";
            cmbtec.Text = "";
            cmbnatio.Text = "";
            cmbmod.Text = "";
            cmbvacation.Text = "";
            tniveau.Text = "";
            cmbetat.Text = "";
            temail.Text = "";
            tdps.Text = "";
            tdescription.Text = "";
            tnifcin.Text = "";

        }


        protected void btnul_Click(object sender, EventArgs e)
        {
           
        }
    }
}