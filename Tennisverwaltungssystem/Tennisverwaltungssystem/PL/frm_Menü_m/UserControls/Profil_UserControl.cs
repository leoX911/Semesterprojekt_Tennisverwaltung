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

namespace Tennisverwaltungssystem.frm_Menü_m.UserControls
{
    public partial class Profil_UserControl : UserControl
    {
        User user;
        public Profil_UserControl()
        {
       
            InitializeComponent();
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
            user.Vorname = txtbox_name.Text;
            user.Nachname = txtbox_name.Text;
            user.EMail = txtbox_nachname.Text;
            user.Passwort = txtBox_passwort.Text;
            user.Straße = textbox_straße.Text;
            //user.Telefonummer

            
        }


    }
}
