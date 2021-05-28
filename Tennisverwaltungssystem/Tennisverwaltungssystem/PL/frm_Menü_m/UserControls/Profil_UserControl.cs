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
        #region Checknames
        public bool CheckFormatSpace()
        {
            if (tbx_Passwort.Text != "" && tbx_Vorname.Text != "" && tbx_Nachname.Text != "")
            {

                return true;
            }
            else
            {
                MessageBox.Show("Bitte alle Pflichtfelder ausfüllen!");
                return false;
            }
        }

      
        private bool CheckPassword()
        {
            string passwort;
            passwort = tbx_Passwort.Text;
            if (passwort.Length >= 8 && !passwort.Contains(" "))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Passwort muss mindestens 8. Zeichen lang sein\nDarf keine Leerzeichen beeinhalten.");
                return false;
            }

        }
        private bool CheckPostleitzahl()
        {
            string postleitzahl;
            postleitzahl = tbx_PLZ.Text;

            if (postleitzahl.Length == 4 && postleitzahl.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                if (postleitzahl == "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Das ist keine Österreichische Postleitzahl!");
                    return false;
                }
                
            }

        }
        private bool CheckNames(string name)
        {
            bool query = name.All(char.IsLetter) && !name.Contains(" ");
            return query;
        }
        private bool CheckPhoneNumber()
        {
            return true;
        }

        private bool CheckFormatVorname_Nachname()
        {
            string vorname, nachname;
            vorname = tbx_Vorname.Text;
            nachname = tbx_Nachname.Text;
            if (CheckNames(vorname) && CheckNames(nachname))
            {

                return true;
            }
            else
            {
                MessageBox.Show("Der Vor- oder Nachname hat das falsche Format!\nNur Buchstaben angeben und keine Leerzeichen!");
                return false;

            }

        }
        //private bool CheckTelAndStreet()
        //{
            

        //}
        #endregion 
        private void Ändern_Click(object sender, EventArgs e)
        {
            if (CheckFormatVorname_Nachname() && CheckFormatSpace() && CheckPostleitzahl() && CheckPassword()&&CheckPhoneNumber()||user.isAdmin==1)
            {
                


                user.Vorname = tbx_Vorname.Text;
                user.Nachname = tbx_Nachname.Text;
              
                user.Passwort = tbx_Passwort.Text;
                user.Straße = tbx_Straße.Text;
                user.PLZ = tbx_PLZ.Text;
                user.Ort = tbx_Ort.Text;

                user.Telefonummer = tbx_Telefonnummer.Text;

                if (DAL.DAL_Profil.IsUserUpdated(user))
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

        private void Tbx_Straße_TextChanged(object sender, EventArgs e)
        {

        }
    }




    }

