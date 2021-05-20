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
    class DAL_Profil
    {
        private static MySqlConnection conn;
        private static string server, database, un, password;
        static string connString;






        public static void CreateConnection()
        {
            server = "localhost";
            database = "tennisverwaltung";
            un = "root";
            password = "";
            connString = $"SERVER={server};DATABASE={database};UID={un};PASSWORD={password}";

        }

        public static bool Connect()
        {
            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serververbindung fehlgeschlagen!");
                return false;


            }
        }

        public static void UpdateDataUser(User user)
        {
            string query = $"UPDATE user SET Vorname=?vorname, Nachname=?nachname, Email=?email, Passwort=?passwort, Telefonnummer=?telefonnummer, Straße=?straße)";
            if (Connect())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("vorname",
                        MySqlDbType.VarChar, 30)
                { Value = user.Vorname });

                cmd.Parameters.Add(new MySqlParameter("nachname",
                     MySqlDbType.VarChar, 30)
                { Value = user.Nachname });

                if (CheckEmailExits(user))
                {
                    MessageBox.Show("Die E-Mail wird schon verwendet!");
                }
                else
                {
                    cmd.Parameters.Add(new MySqlParameter("email",
                  MySqlDbType.VarChar, 30)
                    { Value = user.EMail });
                }


                cmd.Parameters.Add(new MySqlParameter("passwort",
                     MySqlDbType.VarChar, 30)
                { Value = user.Passwort });

                cmd.Parameters.Add(new MySqlParameter("telefonnummer",
                MySqlDbType.VarChar, 30)
                { Value = user.Telefonummer });

                cmd.Parameters.Add(new MySqlParameter("straße",
                MySqlDbType.VarChar, 30)
                { Value = user.Straße });
            }
        }

        public static bool CheckEmailExits(User user)
        {
            string query = $"SELECT * FROM user WHERE EMail='{user.EMail}';";
            if (Connect())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    conn.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    return false;
                }
                //try
                //{
                //    cmd.ExecuteNonQuery();
                //    return true;
                //}
                //catch (Exception ex)
                //{
                //    return false;

                //}
            }
            else
            {
                conn.Close();
                return false;
            }



        }
    }

}
