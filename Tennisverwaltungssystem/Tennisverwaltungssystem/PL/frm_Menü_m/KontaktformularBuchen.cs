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
using Tennisverwaltungssystem.PL.frm_Menü_m.UserControls;

namespace Tennisverwaltungssystem.PL.frm_Menü_m
{
    public partial class KontaktformularBuchen : Form
    {
        string Anmerkung;
        int _anfangszeit;
        int _endzeit;
        List<Daypanel> _selectedpanels;
        int bookingnumber;

        readonly User user = Übersicht_M._user;
        public KontaktformularBuchen(List<Daypanel> SelectedPanels)
        {
      
            InitializeComponent();
            _selectedpanels = SelectedPanels;
            Random _rndGen = new Random();
            
            nUP_Person.Maximum = 4;
            nUP_Person.Value = 1;
            nUP_Person.Minimum = 1;
            
            
           
            do
            {
                bookingnumber = _rndGen.Next(10000000, 999999999);
            } while (DAL.DAL_Buchen.IsBookingNumberUsed(Convert.ToString(bookingnumber)));
            
            lbl_pltznummer.Text = Convert.ToString(SelectedPanels[0].Platznummer);
            lbl_date.Text = SelectedPanels[0].Date.ToShortDateString();

            if (SelectedPanels.Count==1)
            {
                _anfangszeit=SelectedPanels[0].Anfangszeit;
                _endzeit= SelectedPanels[0].Endzeit;
                lbl_zeitraum.Text = $"{_anfangszeit}:00-{_endzeit}:00";

           
            }
            else
            {
                _anfangszeit = SelectedPanels[0].Anfangszeit;
                _endzeit = SelectedPanels[1].Endzeit;
                lbl_zeitraum.Text = $"{_anfangszeit}:00-{_endzeit}:00";
            }


            if (user !=null)
            {
                
                tbx_Buhcungsnummer.Text = Convert.ToString(bookingnumber);
                lbl_bookingsnumber.Text = Convert.ToString(bookingnumber);
                tbx_Buhcungsnummer.Enabled = false;
                tbx_VornameK.Enabled = false;
                tbx_NachnameK.Enabled = false;
                tbx_EmailK.Enabled = false;

                tbx_VornameK.Text = user.Vorname;
                tbx_NachnameK.Text = user.Nachname;
                tbx_EmailK.Text = user.EMail;

                if (user.Telefonummer!="")
                {
                    tbx_TelefonK.Text = user.Telefonummer;
                    tbx_TelefonK.Enabled = false;
                }

                if (user.Straße!="")
                {
                    tbx_StraßeK.Text = user.Straße;
                    tbx_StraßeK.Enabled = false;
                }

                if (user.Ort!=""||user.Ort!= "")
                {
                    tbx_PLZortK.Text = $"{user.PLZ} {user.Ort}";
                   
                    tbx_PLZortK.Enabled = false;

                }
           

                //tbx_NachnameK.Text = user.Nachname;
               
            }
            
        }

        private void Btn_zurückK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_BuchenK_Click(object sender, EventArgs e)
        {
            Anmerkung = textBox1.Text;
            if (DAL.DAL_Buchen.IsInserted(user, _selectedpanels, bookingnumber, Anmerkung))
            {
                MessageBox.Show("nice");
            }
            else
            {
                MessageBox.Show("ok");
            }
        }
    }
}
