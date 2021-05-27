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
                tbx_buchungsnummer.Text = b.Buchungsnummer;
                tbx_buchender.Text = b.Buchender.Nachname;
            }
           



        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }

        private void Buchungsdetails_VisibleChanged(object sender, EventArgs e)
        {
           
    }
    }
}
