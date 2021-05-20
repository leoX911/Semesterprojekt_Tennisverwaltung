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
     

       
        
        public static bool isAvaiable(Schläger schläger)
        {
            string query = $"SELECT * FROM schläger WHERE Modell='{schläger.Modell}' AND isAvab='1';";
            if (DAL.Connect())
            {
                MySqlCommand cmd = new MySqlCommand(query, DAL.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    DAL.conn.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    DAL.conn.Close();
                    return false;
                }
            }
            else
            {
                DAL.conn.Close();
                return false;
            }
        }
    }
    }
