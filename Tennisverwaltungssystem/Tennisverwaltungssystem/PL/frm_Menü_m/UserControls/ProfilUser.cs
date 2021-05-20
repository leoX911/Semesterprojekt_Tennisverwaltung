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
    public partial class ProfilUser : UserControl
    {
        User user;
        public ProfilUser()
        {
            InitializeComponent();
            user = Übersicht_M._user;
            //txtbox_name.Text = "lol";
            //// Vorhandene Daten werden in die Textboxen eingeschrieben
            txtbox_name.Text = user.Vorname;
            txtbox_nachname.Text = user.Nachname;
            txtbox_email.Text = user.EMail;

            // TODO: Passwort in Sternchen anzeigen lassen + Button 
            txtBox_passwort.Text = user.Passwort;
            textbox_straße.Text = user.Straße;
            txtbox_telnummer.Text = user.Telefonummer;

        }


    }
}
