using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// MACO: Das hier ist ein Steuerelement für die Benutzeroberfläche und gehört somit in den Presentation Layer!
namespace Tennisverwaltungssystem.PL.frm_Menü_m.UserControls
{
    public class Daypanel: FlowLayoutPanel
    {
        public bool Clicked { get; set; } = false;
        public int Platznummer { get; set; }
        public int Anfangszeit { get; set; }
        public int Endzeit { get; set; }
        public DateTime Date { get; set; }
        public bool Occupied { get; set; }
    }
}
