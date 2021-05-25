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
      
        public static bool IsAvaiable(Schläger schläger)
        {
            string query = $"SELECT * FROM schläger WHERE Modell='{schläger.Modell}' AND isAvab='1';";
            return DAL.DAL_Main.ReadData(query);
        }
    }
    }
