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
    public partial class frm_Hilfe : Form
    {
       
       
        public frm_Hilfe()
        {
            InitializeComponent();
            btn_navbar_hilfe.ForeColor = Color.FromArgb(155, 185, 205);
        }

        private void Btn_navbar_menu_Click(object sender, EventArgs e)
        {
            Übersicht_M überischtform = new Übersicht_M();

            this.Hide();
            überischtform.Show();
            
        }

        private void Btn_navbar_konakt_Click(object sender, EventArgs e)
        {
            frm_Kontakt_ kontaktform = new frm_Kontakt_();

            this.Hide();
            kontaktform.Show();
            
        }

        private void Btn_navbar_logout_Click(object sender, EventArgs e)
        {
            frm_login.Frm_login loginfrm = new frm_login.Frm_login();

            this.Hide();
            loginfrm.Show();
            
        }
    }
}
