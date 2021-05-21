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
      






      

        

        public static void UpdateDataUser(User user)
        {
            string query = $"UPDATE user SET Vorname=?vorname, Nachname=?nachname, Email=?email, Passwort=?passwort, Telefonnummer=?telefonnummer, Straße=?straße)";
            if (DAL_Main.Connect())
            {
                MySqlCommand cmd = new MySqlCommand(query, DAL_Main.conn);
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
            if (DAL_Main.Connect())
            {
                MySqlCommand cmd = new MySqlCommand(query, DAL_Main.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    DAL_Main.conn.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    DAL_Main.conn.Close();
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
                DAL_Main.conn.Close();
                return false;
            }



        }
    }

}
