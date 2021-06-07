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
        
        public static string buchungsnummer;
        User _user = Übersicht_M._user;
       
        public BuchungenListe_UserControl()
        {
            
            InitializeComponent();
            Buchungsbestätigung.UpdateBuchung += Buchungsbestätigung_UpdateBuchung;
            UpdateData();


        }

        private void Buchungsbestätigung_UpdateBuchung(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            if (_user != null)
            {
                foreach (var item in DAL.DAL_Buchen.ReadBooking(_user))
                {
                    dataGridView1.Rows.Add(item.Buchungsnummer, item.Erstelldatum.ToShortDateString(), item.Datum.ToShortDateString(), "...");
                }
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if (e.ColumnIndex==3)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                buchungsnummer=row.Cells[0].Value.ToString();
                Buchungsdetails bd = new Buchungsdetails(buchungsnummer);
                this.Controls.Add(bd);
                bd.Visible = true;
                bd.BringToFront();



            }
           


        }
    }
}
