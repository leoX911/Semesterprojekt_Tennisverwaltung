using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennisverwaltungssystem.BL;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.ComponentModel.Design;

namespace Tennisverwaltungssystem.PL.frm_Menü_m.UserControls
{
    public partial class Profil_Usercontrol : UserControl
    {
        public event EventHandler OnComplete;
        readonly User user = Übersicht_M._user;
        public Profil_Usercontrol()
        {
            InitializeComponent();
            UpdateUser();
            Buchungsbestätigung.UpdateUser += Buchungsbestätigung_UpdateUser;
           
        }

        private void Buchungsbestätigung_UpdateUser(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void UpdateUser()
        {
            if (user != null)
            {
                // Vorhandene Daten werden in die Textboxen eingeschrieben
                tbx_Vorname.Text = user.Vorname;
                tbx_Nachname.Text = user.Nachname;
                tbx_Email.Text = user.EMail;

                // TODO: Passwort in Sternchen anzeigen lassen + Button 
                tbx_Passwort.Text = user.Passwort;
                tbx_Straße.Text = user.Straße;
                tbx_Telefonnummer.Text = user.Telefonummer;
                tbx_Email.Enabled = false;
                tbx_PLZ.Text = user.PLZ;
                tbx_Ort.Text = user.Ort;
            }
        }
     
        private void Ändern_Click(object sender, EventArgs e)
        {
            if (Checkdata.CheckFormatVorname_Nachname(tbx_Vorname,tbx_Nachname) && Checkdata.CheckFormatSpaceLogin(tbx_Passwort,tbx_Vorname,tbx_Nachname)
                && Checkdata.CheckPostleitzahl(tbx_PLZ) && Checkdata.CheckPassword(tbx_Passwort)&&Checkdata.CheckPhoneNumber())
            {
                


                user.Vorname = tbx_Vorname.Text;
                user.Nachname = tbx_Nachname.Text;
              
                user.Passwort = tbx_Passwort.Text;
                user.Straße = tbx_Straße.Text;
                user.PLZ = tbx_PLZ.Text;
                user.Ort = tbx_Ort.Text;

                user.Telefonummer = tbx_Telefonnummer.Text;

                if (DAL.DAL_Profil.UpdateUser(user))
                {
                    MessageBox.Show("Erfolgreich aktualisiert");
                }
                else
                {
                    MessageBox.Show("Daten konnten nicht aktualisiert werden");
                }
                OnComplete?.Invoke(this,null);
            }
        }

        private void Löschen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Adresse und Telefonnummer löschen?", "löschen Ja/Nein", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (DAL.DAL_Profil.IsUserDeleted(user))
                {
                    tbx_Straße.Text = "";
                    tbx_Telefonnummer.Text = "";
                    tbx_PLZ.Text = "";
                    tbx_Ort.Text = "";

                    MessageBox.Show("Daten erfolgreich gelöscht");
                }
                else
                {
                    MessageBox.Show("Daten konnten nicht gelöscht werden");
                }
            }
            else
            {
                
            }
            

            
        }

      
    }




    }

