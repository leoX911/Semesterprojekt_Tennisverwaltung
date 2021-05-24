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
    class DAL_Main
    {
        public static MySqlConnection conn;
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
                throw new Exception("Was mahsch du??");
            

            }
        }
    }
}
