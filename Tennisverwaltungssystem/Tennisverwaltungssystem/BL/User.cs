using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennisverwaltungssystem.BL
{
    public class User
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Passwort { get; set; }
        public string EMail { get; set; }
        public string Straße { get; set; }
        //public int Hausnummer { get; set; }
        public string Telefonummer { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }

        public string ProfilCode { get; set; }
        public int isAdmin { get; set; }
        public int isMitglied { get; set; }



    }
}
