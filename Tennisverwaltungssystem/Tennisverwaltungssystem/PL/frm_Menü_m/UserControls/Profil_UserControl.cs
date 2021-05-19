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

namespace Tennisverwaltungssystem.frm_Menü_m.UserControls
{
    public partial class Profil_UserControl : UserControl
    {
        User user;
        public Profil_UserControl()
        {
       
            InitializeComponent();

            DAL.DAL_Login.CreateConnection();
            if (!DAL.DAL_Login.Connect()) return;

            user = Übersicht_M._user;

            // Vorhandene Daten werden in die Textboxen eingeschrieben
            txtbox_name.Text = user.Vorname;
            txtbox_nachname.Text = user.Nachname;
            txtbox_email.Text = user.EMail;

            // TODO: Passwort in Sternchen anzeigen lassen + Button 
            txtBox_passwort.Text = user.Passwort;
            textbox_straße.Text = user.Straße;
            txtbox_telnummer.Text = user.Telefonummer;

           


        }

        private void txtbox_telnummer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_changedata_Click(object sender, EventArgs e)
        {
            if (CheckFormatVorname_Nachname()&& CheckFormatSpace() && CheckFormatEMail() && CheckPassword())
            {
                user.Vorname = txtbox_name.Text;
                user.Nachname = txtbox_name.Text;
                user.EMail = txtbox_nachname.Text;
                user.Passwort = txtBox_passwort.Text;
                user.Straße = textbox_straße.Text;
                
                
                user.Telefonummer = txtbox_telnummer.Text;






                DAL.DAL_Profil.UpdateDataUser(user);
            }
            
            
        }
        public bool CheckFormatSpace()
        {
            if (txtbox_email.Text != "" && txtBox_passwort.Text != "" && txtbox_name.Text != "" && txtbox_nachname.Text != "")
            {

                return true;
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie alle Pflichtfelder mit korrektem Format aus!");
                return false;
            }
        }

        private static bool IsValidEmail(string testemail)
        {
            try
            {
                MailAddress mail = new MailAddress(testemail);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            throw new NotImplementedException();
        }

        private bool CheckPassword()
        {
            string passwort;
            passwort = txtBox_passwort.Text;
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
        private bool CheckFormatEMail()
        {
            string email;
            email = txtbox_email.Text;

            if (IsValidEmail(email))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Die Email hat das falsche Format");
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
        private bool CheckNames(string name)
        {
            bool query = name.All(char.IsLetter) && !name.Contains(" ");
            return query;
        }

    }
}
