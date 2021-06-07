using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennisverwaltungssystem.BL;

namespace Tennisverwaltungssystem.DAL
{
    public static class DAL_Profil
    {

        // MACO: Hier ist die Benennung etwas irreführend, denn die Hauptaufgabe dieser Methode ist ja schon den Benutzer
        // zu aktualisieren. Sie gibt halt dann noch zurück, ob das geklappt hat oder nicht. Daher würde ich die Methode
        // eher "UpdateUser" oder Ähnliches nennen.

        public static bool UpdateUser(User user)
        {
           
            string query = $"UPDATE user SET Vorname=?vorname, Nachname=?nachname, Passwort=?passwort, Telefonnummer=?telefonnummer, Straße=?straße, Ort=?ort, Postleitzahl=?plz WHERE (Email='{user.EMail}')";
            if (DAL_Main.Connect())
            {
                using(MySqlCommand cmd = new MySqlCommand(query, DAL_Main.conn))
                {
                    cmd.Parameters.Add(new MySqlParameter("vorname",
                      MySqlDbType.VarChar, 30)
                    { Value = user.Vorname });

                    cmd.Parameters.Add(new MySqlParameter("nachname",
                         MySqlDbType.VarChar, 30)
                    { Value = user.Nachname });


                    cmd.Parameters.Add(new MySqlParameter("passwort",
                         MySqlDbType.VarChar, 30)
                    { Value = user.Passwort });

                    cmd.Parameters.Add(new MySqlParameter("telefonnummer",
                    MySqlDbType.VarChar, 30)
                    { Value = user.Telefonummer });

                    cmd.Parameters.Add(new MySqlParameter("straße",
                    MySqlDbType.VarChar, 30)
                    { Value = user.Straße });

                    cmd.Parameters.Add(new MySqlParameter("ort",
                    MySqlDbType.VarChar, 30)
                    { Value = user.Ort });

                    cmd.Parameters.Add(new MySqlParameter("plz",
                    MySqlDbType.VarChar, 30)
                    { Value = user.PLZ });

                    return DAL.DAL_Main.TryToExecute(cmd);
                }
              
            }
            else
            {
                DAL_Main.conn.Close();
                return false;
            }
        }

        public static bool IsUserDeleted(User user)
        {
            string query = $"UPDATE user SET Telefonnummer=?telefonnummer, Straße=?straße, Ort=?ort, Postleitzahl=?plz WHERE (Email='{user.EMail}')";
            if (DAL_Main.Connect())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, DAL_Main.conn))
                {
                    cmd.Parameters.Add(new MySqlParameter("telefonnummer",
                    MySqlDbType.VarChar, 30)
                    { Value = "" });

                    cmd.Parameters.Add(new MySqlParameter("straße",
                    MySqlDbType.VarChar, 30)
                    { Value = "" });

                    cmd.Parameters.Add(new MySqlParameter("ort",
                   MySqlDbType.VarChar, 30)
                    { Value = "" });

                    cmd.Parameters.Add(new MySqlParameter("plz",
                    MySqlDbType.VarChar, 30)
                    { Value = "" });

                    return DAL.DAL_Main.TryToExecute(cmd);
                }

            }
            else
            {
                DAL_Main.conn.Close();
                return false;
            }
            
        }

        



    }
}


