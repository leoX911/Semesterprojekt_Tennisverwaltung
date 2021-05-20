using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Tennisverwaltungssystem.BL;

namespace Tennisverwaltungssystem.DAL
{
    class DAL_Ausleihen
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
        public static bool isAvaiable(Schläger schläger)
        {
            string query = $"SELECT * FROM schläger WHERE Modell='{schläger.Modell}' AND isAvab='1';";
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
    }
    }
