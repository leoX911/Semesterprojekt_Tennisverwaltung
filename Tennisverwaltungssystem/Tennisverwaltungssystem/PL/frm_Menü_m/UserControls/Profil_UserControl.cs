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
        User user = Übersicht_M._user;
        public Profil_Usercontrol()
        {
            InitializeComponent();
            
            if (user != null)
            {
                // Vorhandene Daten werden in die Textboxen eingeschrieben
                txtbox_name.Text = user.Vorname;
                txtbox_nachname.Text = user.Nachname;
                txtbox_email.Text = user.EMail;

                // TODO: Passwort in Sternchen anzeigen lassen + Button 
                txtbox_password.Text = user.Passwort;
                textbox_straße.Text = user.Straße;
                txtbox_tell.Text = user.Telefonummer;
                txtbox_email.Enabled = false;
            }
        }
        #region Checknames
        public bool CheckFormatSpace()
        {
            if (txtbox_password.Text != "" && txtbox_name.Text != "" && txtbox_nachname.Text != "")
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
            passwort = txtbox_password.Text;
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
      
        private bool CheckNames(string name)
        {
            bool query = name.All(char.IsLetter) && !name.Contains(" ");
            return query;
        }
        private bool CheckPhoneNumber()
        {
            if (Regex.IsMatch(txtbox_tell.Text, @"/(\b(0043|0)|\B\+43)(\s?\(0\))?(\s)?[1-9]{2}(\s)?[0-9]{3}(\s)?[0-9]{2}(\s)?[0-9]{2}\b/"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("falsche Tellnummer");
                return false;
               
            }
        }

        private bool CheckFormatVorname_Nachname()
        {
            string vorname, nachname;
            vorname = txtbox_name.Text;
            nachname = txtbox_nachname.Text;
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
        #endregion 
        private void Ändern_Click(object sender, EventArgs e)
        {
            if (CheckFormatVorname_Nachname() && CheckFormatSpace()&& CheckPassword()&&CheckPhoneNumber()||user.isAdmin==1)
            {

               
                user.Vorname = txtbox_name.Text;
                user.Nachname = txtbox_nachname.Text;
              
                user.Passwort = txtbox_password.Text;
                user.Straße = textbox_straße.Text;


                user.Telefonummer = txtbox_tell.Text;

                if (DAL.DAL_Profil.IsUserUpdated(user))
                {
                    MessageBox.Show("Erfolgreich aktualisiert");
                }
                else
                {
                    MessageBox.Show("Daten konnten nicht aktualisiert werden");
                }
               
            }
        }


        //private bool CheckFormatTelefon()
        //{
        //    Console.WriteLine("Enter a phone number.");
        //    string telNo = Console.ReadLine();

        //    if (Regex.Match(user.Telefonummer, @"^(\+[0-9])$").Success)
        //    {

        //        return true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Die eingegebene Tel. Nummer ist falsch!");
        //        return false;
        //    }

        //}


    }




    }

