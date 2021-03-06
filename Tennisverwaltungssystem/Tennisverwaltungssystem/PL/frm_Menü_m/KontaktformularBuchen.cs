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
using Tennisverwaltungssystem.PL.frm_Menü_m.UserControls;

namespace Tennisverwaltungssystem.PL.frm_Menü_m
{
    public partial class KontaktformularBuchen : Form
    {
        Buchung buchung;
        readonly int _anfangszeit;
        readonly int _endzeit;
        readonly List<Daypanel> _selectedpanels;
        Guid bookingid = Guid.NewGuid();
        readonly string bookingidAsString;

        readonly User user = Übersicht_M._user;
        
        public KontaktformularBuchen(List<Daypanel> SelectedPanels)
        {
          

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            bookingidAsString = bookingid.ToString();

            _selectedpanels = SelectedPanels;
      
            
            nUP_Person.Maximum = 4;
            nUP_Person.Value = 1;
            nUP_Person.Minimum = 1;
         
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
                
                tbx_Buhcungsnummer.Text = Convert.ToString(bookingidAsString);
                lbl_bookingsnumber.Text = Convert.ToString(bookingidAsString);
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

                if (user.Ort!="")
                {
                    tbx_ort.Text = user.Ort;
                   
                    tbx_ort.Enabled = false;

                }
                if (user.PLZ != "")
                {
                    tbx_plz.Text = user.PLZ;


                    tbx_plz.Enabled = false;

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
            buchung = new Buchung()
            {
                Buchender = user,
                Anmerkung = textBox1.Text,
                Platznummer = _selectedpanels[0].Platznummer,
                Anfangszeit = _anfangszeit,
                Endzeit = _endzeit,
                Buchungsnummer = bookingidAsString,
                Datum = _selectedpanels[0].Date,
                AnzahlPersonen = Convert.ToInt32(nUP_Person.Value),
                Erstelldatum = DateTime.Today,

            };
            if (rdb_Mitglied.Checked)
            {
                buchung.IsMitglied = 1;
            }
            else
            {
                buchung.IsMitglied = 0;
            }
            if (user.Straße=="" || user.Telefonummer==""|| user.Ort=="" || user.PLZ=="")
            {
                if (Checkdata.CheckFormatSpaceElse(tbx_ort,tbx_plz,tbx_TelefonK,tbx_StraßeK)&& Checkdata.CheckPostleitzahl(tbx_plz) && Checkdata.CheckPhoneNumber())
                {
                    user.Straße = tbx_StraßeK.Text;
                    user.Telefonummer = tbx_TelefonK.Text;
                    user.PLZ = tbx_plz.Text;
                    user.Ort = tbx_ort.Text;



                    if (DAL.DAL_Profil.UpdateUser(user))
                    {
                        InsertBuchung();
                      
                    }
                    else
                    {
                        MessageBox.Show("Daten konnten nicht aktualisiert werden");
                    }
                }
              
            }
            else
            {
                InsertBuchung();



            }
          
                
        }

        private void InsertBuchung()
        {
            if (DAL.DAL_Buchen.IsInserted(buchung))
            {
                Buchungsbestätigung buchungsbestätigung = new Buchungsbestätigung(buchung);
                buchungsbestätigung.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Buchung ist fehlgeschlagen");
            }
        }
          


        }
    }

