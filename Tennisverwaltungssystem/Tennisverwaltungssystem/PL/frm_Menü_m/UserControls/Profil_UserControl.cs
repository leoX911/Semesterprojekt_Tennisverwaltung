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
            }
        }

        private void Ändern_Click(object sender, EventArgs e)
        {
            if (/*CheckFormatVorname_Nachname() && CheckFormatSpace() && CheckFormatEMail() && CheckPassword()*/true)
            {
                user.Vorname = txtbox_name.Text;
                user.Nachname = txtbox_nachname.Text;
                user.EMail = txtbox_email.Text;
                user.Passwort = txtbox_password.Text;
                user.Straße = textbox_straße.Text;


                user.Telefonummer = txtbox_tell.Text;

                DAL.DAL_Profil.UpdateDataUser(user);
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

