using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennisverwaltungssystem.frm_Kontakt_Hilfe
{
    public partial class frm_Kontakt_ : Form
    {
        
       
        public frm_Kontakt_()
        {
            InitializeComponent();
            btn_navbar_konakt.ForeColor = Color.FromArgb(155, 185, 205);
        }

        private void Btn_navbar_menu_Click(object sender, EventArgs e)
        {
            btn_navbar_menu.ForeColor = Color.FromArgb(155, 185, 205);
            Übersicht_M überischtform = new Übersicht_M();
            this.Hide();
            überischtform.Show();
         
          


        }

        private void Btn_navbar_konakt_Click(object sender, EventArgs e)
        {
            btn_navbar_konakt.ForeColor = Color.FromArgb(155, 185, 205);
        }

        private void Btn_navbar_hilfe_Click(object sender, EventArgs e)
        {
           frm_Hilfe hilfeform = new frm_Hilfe();
            this.Hide();
            hilfeform.Show();

        }

        private void Btn_navbar_logout_Click(object sender, EventArgs e)
        {
            
            frm_login.Frm_login loginfrm = new frm_login.Frm_login();
            this.Hide();
            loginfrm.Show();
        }

        private void Btn_navbar_logout_Leave(object sender, EventArgs e)
        {
            btn_navbar_logout.ForeColor = Color.FromArgb(64, 64, 64); 
        }

        private void Btn_navbar_hilfe_Leave(object sender, EventArgs e)
        {
            btn_navbar_hilfe.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void Btn_navbar_konakt_Leave(object sender, EventArgs e)
        {
            btn_navbar_konakt.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void Btn_navbar_menu_Leave(object sender, EventArgs e)
        {
            btn_navbar_menu.ForeColor = Color.FromArgb(64, 64, 64);
        }
    }
}
