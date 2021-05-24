using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennisverwaltungssystem.PL.frm_Menü_m.UserControls
{
    class Daypanel: FlowLayoutPanel
    {
        public int Platznummer { get; set; }
        public int Anfangszeit { get; set; }
        public int Endzeit { get; set; }
        public DateTime Date { get; set; }
        public bool Occupied { get; set; }
    }
}
