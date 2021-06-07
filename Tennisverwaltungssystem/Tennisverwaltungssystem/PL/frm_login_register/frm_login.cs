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
  
    public partial class Frm_login : Form
    {

        public Frm_login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            txtbox_Passwort.PasswordChar = '*';
            // MACO: Was nützt euch dieses Return noch? Die Methode ist danach eh vorbei.
            DAL.DAL_Main.CreateConnection();
            if (!DAL.DAL_Main.Connect()) return;

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
       
            if (txtbox_EMail.Text != "" || txtbox_Passwort.Text != "")
            {
                User user1 = new User()
                {
                    EMail = txtbox_EMail.Text,
                    Passwort = txtbox_Passwort.Text
                };
            

                if (DAL.DAL_Login.IsLogin(user1))
                {
                    if (user1.IsAdmin == 1)
                    {
                        DialogResult result = MessageBox.Show("Willst du dich als Admin anmelden", "Admin/Mitglied", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            Close();
                        }
                     
                    }
                  
                    Übersicht_M überischtform = new Übersicht_M(user1);
                    Hide();
                    überischtform.ShowDialog();
                    Close();


                    

                }
                else
                {
                    MessageBox.Show("Das Passwort oder die E-Mail ist falsch!");
                }
            }
            else
            {
                MessageBox.Show("Eingabeeeee ist fehlerhaft");
            }





        }

        private void Lbl_BenutzerErstellen_Click(object sender, EventArgs e)
        {
         
            Hide();
            Hide();
            using (Frm_register register = new Frm_register())
            {
                register.ShowDialog();

            }
            
        }
    }
}
