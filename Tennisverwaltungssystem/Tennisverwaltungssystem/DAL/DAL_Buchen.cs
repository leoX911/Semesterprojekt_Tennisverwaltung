using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tennisverwaltungssystem.PL.frm_Menü_m.UserControls;

namespace Tennisverwaltungssystem.DAL
{
    class DAL_Buchen
    {
        public static bool isOccupied(Daypanel f1)
        {
            string query = $"SELECT * FROM user_bucht_tennisplatz WHERE Tennisplatz_id_Platznummer='{f1.Platznummer}' AND Datum='{f1.Date.Date.ToString("yyyy-MM-dd HH:mm:ss")}' AND Beginn='{f1.Anfangszeit}';";
            if (DAL_Main.Connect())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, DAL_Main.conn))
                {
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
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
                    }
                   
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
