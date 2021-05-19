using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Tennisverwaltungssystem.BL;

namespace Tennisverwaltungssystem.DAL
{
    public static  class DAL_Login
    {
       
        private static MySqlConnection conn;
        private static string server, database, un,password;
        static string connString;
        
      
        public static bool IsLogin(User user2)
        {
            
            string query = $"SELECT * FROM user WHERE EMail='{user2.EMail}' AND Passwort='{user2.Passwort}';";
           
            if (Connect())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                   
                    user2.Vorname = (string)reader["Vorname"];
                    user2.Nachname= (string)reader["Nachname"];
                   
                    user2.isMitglied = Convert.ToInt32(reader["isMitglied"]);
                    user2.isAdmin = Convert.ToInt32(reader["isAdmin"]);
                    user2.Straße = Convert.ToString(reader["Straße"]);
                    //user2.Hausnummer = Convert.ToInt32(reader["Hausnummer"]);
                 
                    user2.ProfilCode = Convert.ToString(reader["profilpicCode"]);
                    user2.Telefonummer = Convert.ToString(reader["Telefonnummer"]);


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


            }
            else
            {
                conn.Close();
                return false;
            }

        }
        public static void CreateConnection()
        {
            server = "localhost";
            database = "tennisverwaltung";
            un = "root";
            password = "";
            connString = $"SERVER={server};DATABASE={database};UID={un};PASSWORD={password}";
            
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
            }
            else
            {
                conn.Close();
                return false;
            }
            

                
        }
        public static bool IsRegistered(User user1)
        {
            
            string query = $"INSERT INTO user(idUser,Vorname, Nachname, Email,Passwort,isAdmin,isMitglied,Telefonnummer,Straße,profilpicCode) VALUES(NULL,?vorname,?nachname, ?email, ?passwort, ?isadmin, ?ismitglied, ?telefonnummer, ?straße, ?profilpiccode)";
            if (Connect())
            {
               
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("vorname",
                        MySqlDbType.VarChar, 30)
                { Value = user1.Vorname });

                cmd.Parameters.Add(new MySqlParameter("nachname",
                     MySqlDbType.VarChar, 30)
                { Value = user1.Nachname });

                if (CheckEmailExits(user1))
                {
                    MessageBox.Show("Die E-Mail wird schon verwendet!");
                }
                else
                {
                    cmd.Parameters.Add(new MySqlParameter("email",
                  MySqlDbType.VarChar, 30)
                    { Value = user1.EMail });
                }


                cmd.Parameters.Add(new MySqlParameter("passwort",
                     MySqlDbType.VarChar, 30)
                { Value = user1.Passwort });

                cmd.Parameters.Add(new MySqlParameter("isadmin",
                 MySqlDbType.Int32, 30)
                { Value = user1.isAdmin });

                cmd.Parameters.Add(new MySqlParameter("ismitglied",
                 MySqlDbType.Int32, 30)
                { Value = user1.isMitglied });

               

                cmd.Parameters.Add(new MySqlParameter("telefonnummer",
                MySqlDbType.VarChar, 30)
                { Value = user1.Telefonummer });

                cmd.Parameters.Add(new MySqlParameter("straße",
                MySqlDbType.VarChar, 30)
                { Value = user1.Straße });

                cmd.Parameters.Add(new MySqlParameter("profilpiccode",
                MySqlDbType.LongText)
                { Value = user1.ProfilCode });


              //  cmd.Parameters.Add(new MySqlParameter("hausnummer",
              //MySqlDbType.Int32, 30)
              //  { Value = user1.Hausnummer });


                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                   
                }
            }
            else
            {
                conn.Close();
                return false;
            }
               
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
        

    }
}
