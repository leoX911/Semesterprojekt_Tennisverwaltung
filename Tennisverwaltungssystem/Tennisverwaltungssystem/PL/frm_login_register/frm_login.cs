using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Tennisverwaltungssystem.BL;
using Tennisverwaltungssystem.PL.frm_login_register;

namespace Tennisverwaltungssystem.frm_login
{
    public partial class frm_login : Form
    {

        public frm_login()
        {
            InitializeComponent();
            txtbox_Passwort.PasswordChar = '*';
            DAL.DAL_Login.CreateConnection();
            if (!DAL.DAL_Login.Connect()) return;

            //login1.BringToFront();
            //register1.Hide();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            //zewas do war der Patrick
            //zewas i ibin leo

            if (txtbox_EMail.Text != "" || txtbox_Passwort.Text != "")
            {
                User user1 = new User();
                user1.EMail = txtbox_EMail.Text;
                user1.Passwort = txtbox_Passwort.Text;

                if (DAL.DAL_Login.IsLogin(user1))
                {
                    if (user1.isAdmin == 1)
                    {
                        DialogResult result = MessageBox.Show("Willst du dich als Admin anmelden", "Admin/Mitglied", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            Close();
                        }
                        else
                        {
                            Übersicht_M überischtform = new Übersicht_M(user1);
                            überischtform.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        Übersicht_M überischtform = new Übersicht_M(user1);
                        überischtform.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Das Passwort oder die E-Mail ist falsch!");
                }
            }
            else
            {
                MessageBox.Show("Eingabe ist fehlerhaft");
            }





        }

        private void Lbl_BenutzerErstellen_Click(object sender, EventArgs e)
        {
            frm_register formregister = new frm_register();
            formregister.Show();
            this.Hide();
        }
    }
}
