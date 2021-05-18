using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennisverwaltungssystem.BL;

namespace Tennisverwaltungssystem.PL.frm_login_register
{
    public partial class frm_register : Form
    {
       
        byte[] ArrNonProfil = System.IO.File.ReadAllBytes("C:\\Users\\leoxo\\Desktop\\Semesterprojekt_Tennisverwaltung\\Fotos\\ProfilPicNone.jpg");

        string base64text;
        User user1;
        Bitmap image;
        public frm_register()
        {
            InitializeComponent();
            txtbox_password.PasswordChar = '*';
            DAL.DAL_Login.CreateConnection();
            if (!DAL.DAL_Login.Connect()) return;
            
        }

  

        private void Lbl_zurückzumlogin_Click(object sender, EventArgs e)
        {
            frm_login.frm_login formlogin = new frm_login.frm_login();
            formlogin.Show();
            this.Hide();
        }
        private bool CheckFormatSpace()
        {
            if(txtbox_email.Text != "" && txtbox_password.Text != "" && txtbox_vornamen.Text != "" && txtbox_nachnamen.Text != "")
            {

                return true;
            }
            else
            {
                MessageBox.Show("Die Eingabe ist fehlerhaft");
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
            passwort = txtbox_password.Text;
            if (passwort.Length>=8 &&!passwort.Contains(" "))
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
            string vorname,nachname;           
            vorname = txtbox_vornamen.Text;
            nachname= txtbox_nachnamen.Text;
            if (CheckNames(vorname)&& CheckNames(nachname))
            {
                
                return true;
            }
            else
            {
                MessageBox.Show("Der Vor- oder Nachname hat das falsche Format!\nNur Buchstaben angeben und keine Leerzeichen!");
                return false;
                
            }
           
        }
        private bool CheckNames(string name)
        {
            bool query = name.All(char.IsLetter) && !name.Contains(" ");
            return query;
        }

        private void Btn_registrieren_Click(object sender, EventArgs e)
        {
            if (CheckFormatVorname_Nachname()&&CheckFormatSpace()&& CheckFormatEMail()&& CheckPassword())
            {

                user1 = new User();           
                user1.Vorname = txtbox_vornamen.Text;
                user1.Nachname = txtbox_nachnamen.Text;              
                user1.EMail = txtbox_email.Text;
                user1.Passwort = txtbox_password.Text;

                user1.Telefonummer = 0;
                
             
                user1.Straße = "";
             
                
                user1.isAdmin = 0;
                user1.isMitglied = 0;
                user1.Hausnummer = 0;

                if (base64text == null)
                {
                    base64text = Convert.ToBase64String(ArrNonProfil);
                }


                user1.ProfilCode = base64text;
                
              

                if (DAL.DAL_Login.IsRegistered(user1))
                {
                    MessageBox.Show("Eingabe erfolgreich");
                    frm_login.frm_login formlogin = new frm_login.frm_login();
                    formlogin.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Eingabe fehlgeschlagen");
                }
                
            }
           
          
           
           




        }

        private void Btn_uploadprofil_Click(object sender, EventArgs e)
        {

           
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                picbox_profil.Image = (Image)image;
                byte[] imageArray = System.IO.File.ReadAllBytes(dialog.FileName);
                base64text = Convert.ToBase64String(imageArray);
           

            }
           
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            picbox_profil.Image = null;
            base64text = null;
        }
    }
}
