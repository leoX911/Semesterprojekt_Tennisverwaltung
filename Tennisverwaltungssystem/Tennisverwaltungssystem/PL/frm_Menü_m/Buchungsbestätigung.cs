using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennisverwaltungssystem.BL;
using Tennisverwaltungssystem.frm_Menü_m.UserControls;

namespace Tennisverwaltungssystem.PL.frm_Menü_m
{
    
    public partial class Buchungsbestätigung : Form
    {
        public static event EventHandler UpdateBuchung;
        public static event EventHandler UpdateUser;
        public Buchungsbestätigung(Buchung buchung)
        {
            InitializeComponent();
            this.ControlBox = false;
            lbl_buchungsnummer.Text ="Buchungsnummer: "+buchung.Buchungsnummer;
            lbl_datum.Text = buchung.Datum.ToShortDateString();
            lbl_zeitraum.Text= "Zeitraum: " + Convert.ToString(buchung.Anfangszeit) + ":00-"+ Convert.ToString(buchung.Endzeit) + ":00";
            lbl_Name.Text = buchung.Buchender.Vorname + " " + buchung.Buchender.Nachname;
            Herrxy.Text = "Hallo Herr/Frau " + buchung.Buchender.Nachname;
        }
        
        private void Btn_hauptmenü_Click(object sender, EventArgs e)
        {


            UpdateUser?.Invoke(this, null);
            UpdateBuchung?.Invoke(this, null);
            this.Hide();
        }

        private void Btn_buchungdrucken_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprm", 285, 600);
            printPreviewDialog1.ShowDialog();

        }
    }
}
