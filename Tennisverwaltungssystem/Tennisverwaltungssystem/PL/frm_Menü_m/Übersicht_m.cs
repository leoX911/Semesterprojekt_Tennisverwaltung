using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennisverwaltungssystem.BL;


namespace Tennisverwaltungssystem
{
    public partial class Übersicht_M : Form
    {
        public static User _user;


        public Übersicht_M(User providedUser)
        {
            _user = providedUser;
            InitializeComponent();
            PrepareLogin(providedUser);



        }
        public static Image LoadBase64(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            Image image;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes))
            {
              
                    image = Image.FromStream(ms);
                
               
            }
            return image;
        }
        private void RoundUpPicBox()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;


        }
        private void PrepareLogin(User user)
        {

            RoundUpPicBox();

            lbl_Username_m.Text = user.Vorname + " " + user.Nachname;
            pictureBox1.Image = LoadBase64(user.ProfilCode);
            if (user.isAdmin == 1 && user.isMitglied == 1)

            {
                Membership_m.Text = "Admin";
            }
            else
            {
                Membership_m.Text = "Gast";
            }
            btn_übersicht_m.BackColor = Color.FromArgb(135, 171, 195);
            überischt_UserControl1.BringToFront();
            btn_navbar_menu.ForeColor = Color.FromArgb(155, 185, 205);
        }
        public Übersicht_M() : this(_user)
        {
            InitializeComponent();
            Nice(_user);




        }


        #region form_click_leave_eevents

        private void Btn_übersicht_m_Click(object sender, EventArgs e)
        {
            btn_übersicht_m.BackColor = Color.FromArgb(135, 171, 195);
            überischt_UserControl1.BringToFront();

        }

        private void Btn_statistiken_m_Click(object sender, EventArgs e)
        {
            btn_statistiken_m.BackColor = Color.FromArgb(135, 171, 195);
            statistiken_UserControl1.BringToFront();


        }

        private void Btn_buchen_m_Click(object sender, EventArgs e)
        {
            btn_buchen_m.BackColor = Color.FromArgb(135, 171, 195);
            buchen_UserControl1.BringToFront();

        }

        private void Btn_ausleihen_m_Click(object sender, EventArgs e)
        {
            btn_ausleihen_m.BackColor = Color.FromArgb(135, 171, 195);
            
            ausleihen_UserControl1.BringToFront();

        }

        private void Btn_profil_m_Click(object sender, EventArgs e)
        {
            btn_profil_m.BackColor = Color.FromArgb(135, 171, 195);
            profil_UserControl1.BringToFront();

        }

        private void Btn_übersicht_m_Leave(object sender, EventArgs e)
        {
            
           
                btn_übersicht_m.BackColor = Color.Transparent;
            
           
        }

   

        private void Btn_statistiken_m_Leave(object sender, EventArgs e)
        {
           
                btn_statistiken_m.BackColor = Color.Transparent;
            
        }

        private void Btn_buchen_m_Leave(object sender, EventArgs e)
        {
           
                btn_buchen_m.BackColor = Color.Transparent;
            
        }

        private void Btn_ausleihen_m_Leave(object sender, EventArgs e)
        {
           
                btn_ausleihen_m.BackColor = Color.Transparent;
            
        }

        private void Btn_profil_m_Leave(object sender, EventArgs e)
        {
           
                btn_profil_m.BackColor = Color.Transparent;
            
        }



        private void Btn_navbar_menu_Click(object sender, EventArgs e)
        {
            btn_navbar_menu.ForeColor = Color.FromArgb(155, 185, 205);
        }

        private void Btn_navbar_konakt_Click(object sender, EventArgs e)
        {
            btn_navbar_konakt.ForeColor = Color.FromArgb(155, 185, 205);

            frm_Kontakt_Hilfe.frm_Kontakt_ kontaktform = new frm_Kontakt_Hilfe.frm_Kontakt_();
            this.Hide();
            kontaktform.Show();




        }

        private void Btn_navbar_hilfe_Click(object sender, EventArgs e)
        {
            frm_Kontakt_Hilfe.frm_Hilfe hilfeform = new frm_Kontakt_Hilfe.frm_Hilfe();
            this.Hide();
            hilfeform.Show();

        }

        private void Btn_navbar_logout_Click(object sender, EventArgs e)
        {
            frm_login.frm_login loginfrm = new frm_login.frm_login();
            this.Hide();
            loginfrm.Show();

            btn_navbar_logout.ForeColor = Color.FromArgb(155, 185, 205);
        }


        private void Btn_navbar_menu_Leave(object sender, EventArgs e)
        {
            btn_navbar_menu.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void Btn_navbar_konakt_Leave(object sender, EventArgs e)
        {
            btn_navbar_konakt.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void Btn_navbar_hilfe_Leave(object sender, EventArgs e)
        {
            btn_navbar_hilfe.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void Btn_navbar_logout_Leave(object sender, EventArgs e)
        {
            btn_navbar_logout.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void Pic_TCHard_Logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://www.tchard.at/");
        }


        #endregion
    }
      
}
