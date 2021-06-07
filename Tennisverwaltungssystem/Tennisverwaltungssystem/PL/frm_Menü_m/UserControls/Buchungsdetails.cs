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
    public partial class Buchungsdetails : UserControl
    {
        public string buchungsnummer;
           User user = Übersicht_M._user;
        
        public Buchungsdetails(string buchungsnummer)
        {
            
           
            InitializeComponent();
            if (buchungsnummer!=null && user!= null)
            {
                Buchung b = DAL.DAL_Buchen.GetDataBuchung(buchungsnummer, user);
                tbx_Tellnummer.Text = b.Buchender.Telefonummer;
                tbx_Vorname.Text = b.Buchender.Vorname;
                tbx_Nachname.Text = b.Buchender.Nachname;
                tbx_Email.Text = b.Buchender.EMail;
                tbx_Adresse.Text = b.Buchender.Straße;
                lbl_actualBuchungsnummer.Text = buchungsnummer;
                lbl_Platznummer.Text = "Platznummer: " + b.Platznummer;
                lbl_Zeitraum.Text = b.Datum.ToShortDateString();
                lbl_zeitttt.Text = b.Anfangszeit+ ":00 - " + b.Endzeit+":00";
            }
           



        }

     

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }

   
    }
}
