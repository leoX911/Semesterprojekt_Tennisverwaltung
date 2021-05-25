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
        public static bool IsOccupied(Daypanel f1)
        {
            string query = $"SELECT * FROM user_bucht_tennisplatz WHERE Tennisplatz_id_Platznummer='{f1.Platznummer}' AND Datum='{f1.Date.Date.ToString("yyyy-MM-dd HH:mm:ss")}' AND Beginn='{f1.Anfangszeit}';";
            return DAL.DAL_Main.ReadData(query);
        }

        public static bool IsBookingNumberUsed(string bookingnumber)
        {
            string query = $"SELECT * FROM user_bucht_tennisplatz WHERE ID_Buchungsnummer={bookingnumber};";
            return DAL.DAL_Main.ReadData(query);
        }
    }
}
