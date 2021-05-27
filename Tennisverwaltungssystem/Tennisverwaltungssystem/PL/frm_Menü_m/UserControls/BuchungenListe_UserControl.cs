using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennisverwaltungssystem.BL;

namespace Tennisverwaltungssystem.PL.frm_Menü_m.UserControls
{
    public partial class BuchungenListe_UserControl : UserControl
    {
      
        User _user = Übersicht_M._user;
       
        public BuchungenListe_UserControl()
        {
            
            InitializeComponent();
            if (_user!=null)
            {
                foreach (var item in DAL.DAL_Buchen.GetData(_user))
                {
                    dataGridView1.Rows.Add(item.Buchungsnummer, item.Erstelldatum.ToShortDateString(), item.Datum.ToShortDateString());
                }
            }
            
        }
    }
}
