using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennisverwaltungssystem.BL
{
    public class Buchung
    {
        public User Buchender { get; set; }
        public int Platznummer { get; set; }
        public string Buchungsnummer { get; set; }
        public string Anmerkung { get; set; }
        public int Anfangszeit { get; set; }
        public int Endzeit { get; set; }
        public DateTime Datum { get; set; }
        public int IsMitglied { get; set; }
        public int AnzahlPersonen { get; set; }

        public DateTime Erstelldatum { get; set; }
    }
}
