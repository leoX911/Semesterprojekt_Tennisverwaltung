using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennisverwaltungssystem.PL
{
    public static class Checkdata
    {
        #region Checknames
        public static bool CheckFormatSpaceLogin(TextBox tbx_Passwort, TextBox tbx_Vorname, TextBox tbx_Nachname)
        {
            if (tbx_Passwort.Text != "" && tbx_Vorname.Text != "" && tbx_Nachname.Text != "")
            {

                return true;
            }
            else
            {
                MessageBox.Show("Bitte alle Pflichtfelder ausfüllen!");
                return false;
            }
        }

        public static bool CheckFormatSpaceElse(TextBox tbx_ort, TextBox tbx_plz, TextBox tbx_TelefonK, TextBox tbx_StraßeK)
        {
            if (tbx_ort.Text != "" && tbx_plz.Text != "" && tbx_TelefonK.Text != "" && tbx_StraßeK.Text != "")
            {

                return true;
            }
            else
            {
                MessageBox.Show("Bitte alle Pflichtfelder ausfüllen!");
                return false;
            }
        }

        public static bool CheckPassword(TextBox tbx_Passwort)
        {
            string passwort;
            passwort = tbx_Passwort.Text;
            if (passwort.Length >= 8 && !passwort.Contains(" "))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Passwort muss mindestens 8. Zeichen lang sein\nDarf keine Leerzeichen beeinhalten.");
                return false;
            }

        }
        public static bool CheckPostleitzahl(TextBox tbx_PLZ)
        {
            string postleitzahl;
            postleitzahl = tbx_PLZ.Text;

            if (postleitzahl.Length == 4 && postleitzahl.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                if (postleitzahl == "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Das ist keine Österreichische Postleitzahl!");
                    return false;
                }

            }

        }
        public static bool CheckNames(string name)
        {
            bool query = name.All(char.IsLetter) && !name.Contains(" ");
            return query;
        }
        public static bool CheckPhoneNumber()
        {
            return true;
        }

        public static bool CheckFormatVorname_Nachname(TextBox tbx_Vorname, TextBox tbx_Nachname)
        {
            string vorname, nachname;
            vorname = tbx_Vorname.Text;
            nachname = tbx_Nachname.Text;
            if (CheckNames(vorname) && CheckNames(nachname))
            {

                return true;
            }
            else
            {
                MessageBox.Show("Der Vor- oder Nachname hat das falsche Format!\nNur Buchstaben angeben und keine Leerzeichen!");
                return false;

            }

        }
        //private bool CheckTelAndStreet()
        //{


        //}
        #endregion
    }
}
