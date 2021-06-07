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
    public partial class Frm_register : Form
    {
     
      
        readonly string base64nonProfil="/9j/4AAQSkZJRgABAQEAYABgAAD/2wBDAAMCAgMCAgMDAwMEAwMEBQgFBQQEBQoHBwYIDAoMDAsKCwsNDhIQDQ4RDgsLEBYQERMUFRUVDA8XGBYUGBIUFRT/2wBDAQMEBAUEBQkFBQkUDQsNFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBT/wAARCAF8AXkDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD64ooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAorT0Pw3qHiKYx2Nu0gH3pDwi/U16VoXwksbRVfU5WvZuvloSsY/qf0oA8lhhkuJAkUbSOeioCTW9YfD/XtQAKafJEv96ciP9Dz+le4WGl2mlxeXaW0VsnpGgGfr61aoA8itfg7qki5nu7WH2Xcx/kKsr8GbjvqkQ+kR/wAa9UooA8pb4M3f8OpQn6xkf1rNvPhPrlvnyhb3Q7eXLg/+PAV7RRQB876h4Z1XS8/atPuIlH8WwlfzHFZlfTdYer+C9H1vJuLJFlP/AC1i+RvzHX8aAPAKK7zxD8J77T90umv9uhHPlnAkH9D/AJ4rhZInhkaORGjdTgqwwR9RQA2iiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAoopURpGVVUszHAVRkk+lAAqlmAAyTwAK9E8H/C57sJeawGihPK2vRm/3vQe3X6VueA/h8mipHf6ggk1AjKRnkQ/4t79v1ruqAIbSzgsbdILeJIYUGFRBgCpqKKACiiigAooooAKKKKACiiigArD8R+D9O8TRn7TFsuMYW4j4cfX1Hsa3KKAPn7xN4TvvC9yEuV3wMf3dwg+Vv8D7Vi19J31hb6nayW11Es8DjDIwrxXxv4Il8LXAliLTafIcJIeqH+63+PegDlqKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAK9Z+GnglLO3j1a+izdScwRuP8AVr2bHqf0Fcl8O/Cv/CRat506ZsbYhpM9Hbsv+Pt9a9uAwMAYFAC0UUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFQXtnDqFrLbXEaywSrtZG6EVPRQB4F4x8Ly+FtVaE5e2k+aCT1X0PuKwa+gvFnh2LxNo8tq4AmA3QyEfdcdPwPSvAbi3ktZ5IZkMcsbFWVuoI6igCOiiigAooooA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T0AFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABVLVdHs9atTb3tus8Z6bhyvuD2NXaKAPIvFPwrudNV7nS2a7txyYT/rFHt/e/nXBMpViCMEcEGvpquU8WfD6y8SK08WLS/6+co4c/wC0P69aAPD6KuatpN1ol9JaXkRimT8iOxB7iqdABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFKAWIAGSegpK9d+HvgBdLji1LUY83rfNFC4/1I7Ej+9/L60AV/Afw3W1WPUdXj3T/AHorVhwnu3v7du/PT0aiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAyfEfhmy8TWJgukw68xzKPmjPt7e1eHeIvDt34a1BrW6XjrHKv3ZF9R/hX0PWbr2gWniPT3tLtMqeUcfeRvUGgD52orT8ReH7nw3qclncjOOUkAwJF7EVmUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFdN4D8Jt4n1QGUEWMBDTN/e9FH1/lQB0nwz8DrMI9Zv0yoObaFh1I/jP9Pzr1GmxxrGioihUUYCgYAHpTqACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKAMPxd4Xg8VaYYHIjnjy0M2Put/ge9eEahYz6XeTWtyhjmibay19J1xXxG8G/29Z/bbRB9vgXkDrKnp9R2/KgDxmijpwaKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAnsrObULyG2gQvNKwRVHqa+gPDWgw+G9IhsosFlG6R/77nqa4j4R+HNscusTJ8zZigz6fxN/T869LoAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigDxr4neFv7H1T7fbpi0umJIA4STuPx6/nXE19F69o8WvaTcWUw+WRcK2Put2P4Gvnq8s5dPu5raddksTlGX3BoAhooooAKKKKACiiigAooooAKKKKACiiigAooooAKu6LpcmtapbWUXDzOFz6DufwGTVKvTfhBoP/AB86tKv/AExhz+bH+Q/OgD0exs4tOs4bWBdkMKBFHsKnoooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAryv4ueHRDcQ6vCuFl/dTYH8QHyn8Rx+Ar1Ss/XtJj1zR7qxkxiVMKx/hbqD+BxQB86UVJcQPazyQyrtkjYoynsQcEVHQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQA6NGkdUUbmY4AHc19EeH9LXRdFs7JRzDGA3u3Vj+ZNeOfDnShqviq1DjMdvmdhj+70/UivdKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigDxb4qaT/Z/iY3CriO7QSf8AAhw38gfxrja9l+LGl/bfDa3SjMlpIG/4C3B/XH5V41QAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQB6j8GtP2w6jfEfeZYVP0GW/mtelVzHw3svsXg+xyMNLulP4scfpiunoAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKAKmrWK6ppd1aP0miaP6ZHBr5xkjaKRkcbXU4IPYivpmvAfHVl9g8WanGBgNL5g/4EA39aAMKiiigAooooAKKKKACiiigAooooAKACTgcmirmi2/2rWLGHGfMnjT82AoA+htMtBp+m2tqOkMSx/kAKs0UUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABXj/xfs/J8QW9wBxNAM/VSR/IivYK80+M9vmHSpgPutIh/HaR/I0AeX0UUUAFFFFABRRRQAUUUUAFFFFABW54HjE3i3S1PaYN+XP8ASsOui+Ho3eMtMz/fb/0BqAPeaKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigArhPjDGG8OWr91ulH4FG/wFd3XFfFsZ8Kr7XKfyagDxmiiigAooooAKKKKAP/Z";

        string base64text;
        User user1;
        Bitmap _image;
        public Frm_register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtbox_password.PasswordChar = '*';
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;


        }

  

        private void Lbl_zurückzumlogin_Click(object sender, EventArgs e)
        {

            Hide();
            using (frm_login.Frm_login loginfrm = new frm_login.Frm_login())
            {
                loginfrm.ShowDialog();
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
        private bool CheckSpaceEmail()
        {
            if (txtbox_email.Text!="")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Die Email darf nicht leer sein");
                return false;
            }
        }
      

        private void Btn_registrieren_Click(object sender, EventArgs e)
        {
            if (CheckSpaceEmail()&&Checkdata.CheckFormatVorname_Nachname(txtbox_vornamen,txtbox_nachnamen)&&Checkdata.CheckFormatSpaceLogin(txtbox_password,txtbox_vornamen,txtbox_nachnamen)&& CheckFormatEMail()&&Checkdata.CheckPassword(txtbox_password))
            {

                user1 = new User
                {
                    Vorname = txtbox_vornamen.Text,
                    Nachname = txtbox_nachnamen.Text,
                    EMail = txtbox_email.Text,
                    Passwort = txtbox_password.Text,
                    Ort = "",
                    PLZ = "",
                    Telefonummer = "",


                    Straße = "",

                    
                    IsAdmin = 0,
                    IsMitglied = 0
                };
               
                if (base64text == null)
                {
                    base64text = base64nonProfil;
                }


                user1.ProfilCode = base64text;
                
              

                if (DAL.DAL_Login.IsRegistered(user1))
                {
                    Übersicht_M überischtform = new Übersicht_M(user1);
                    Hide();
                    überischtform.ShowDialog();
                    Close();

                }
                else
                {
                    MessageBox.Show("Bitte erneut versuchen!");
                }
                
            }
           
          
           
           




        }

        private void Btn_uploadprofil_Click(object sender, EventArgs e)
        {


            using (OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",

                CheckFileExists = true,
                Multiselect = false
            })

            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _image = new Bitmap(dialog.FileName);
                    picbox_profil.Image = (Image)_image;
                    byte[] imageArray = System.IO.File.ReadAllBytes(dialog.FileName);
                    base64text = Convert.ToBase64String(imageArray);


                }
            }

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            picbox_profil.Image = null;
            base64text = null;
        }

     
    }
}
