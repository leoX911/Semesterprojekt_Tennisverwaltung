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
    public static class DAL_Main
    {
        public static MySqlConnection conn;
        private static string server, database, un, password;
        static string connString;
        // MACO: Warum wird diese Methode öfter als ein Mal aufgerufen? Würde es nicht reichen, das einfach ein Mal beim
        // Start des Programmes zu machen und fertig?
        public static void CreateConnection()
        {
            server = "localhost";
            database = "tennisverwaltung";
            un = "root";
            password = "";
            connString = $"SERVER={server};DATABASE={database};UID={un};PASSWORD={password}";

        }
        public static bool TryToExecute(MySqlCommand cmd)
        {
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
        public static bool ReadData(string query)
        {
            if (DAL_Main.Connect())
            {
                using (MySqlCommand cmd = new MySqlCommand(query,conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                       
                        if (reader.Read())
                        {
                            // MACO: Die nächsten zwei Zeilen passieren sowohl im if als auch im else (= auf jeden Fall).
                            // -> vor oder nach die if-Anweisung verschieben, dann müsst ihr sie nicht doppelt haben. (**)
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

                }

            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public static bool CheckEmailExits(User user)
        {
            string query = $"SELECT * FROM user WHERE EMail='{user.EMail}';";
            if (Connect())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
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
                   
                }
                    

            }
            else
            {
                DAL_Main.conn.Close();
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
                MessageBox.Show(ex.Message);
                return false;
            

            }
        }
    }
}
