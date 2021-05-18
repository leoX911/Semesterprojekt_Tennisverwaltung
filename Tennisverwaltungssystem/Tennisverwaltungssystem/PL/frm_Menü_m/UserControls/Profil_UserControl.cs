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
     
        public Profil_UserControl()
        {
       
            InitializeComponent();
            User user = Übersicht_M._user;

            txtbox_name.Text = user.Vorname;
            txtbox_nachname.Text = user.Nachname;
            txtbox_email.Text = user.EMail;
            txtBox_passwort.Text = user.Passwort;
            textbox_straße.Text = user.Straße;

            if (user.Telefonummer == 0)
            {
                txtbox_telnummer.Text = "";
            }
            else
            {
                txtbox_telnummer.Text = Convert.ToString(user.Telefonummer);
            }


        }

        private void txtbox_telnummer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
