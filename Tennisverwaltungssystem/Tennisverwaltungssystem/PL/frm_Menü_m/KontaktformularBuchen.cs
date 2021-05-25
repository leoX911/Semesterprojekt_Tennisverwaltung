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
        bool BookingAccess1;
        int _anfangszeit;
        int _endzeit;
        List<Daypanel> _selectedpanels;
        Guid bookingid = Guid.NewGuid();
        string bookingidAsString;

        readonly User user = Übersicht_M._user;
        
        public KontaktformularBuchen(List<Daypanel> SelectedPanels)
        {
          

            InitializeComponent();
            bookingidAsString = bookingid.ToString();

            _selectedpanels = SelectedPanels;
            Random _rndGen = new Random();
            
            nUP_Person.Maximum = 4;
            nUP_Person.Value = 1;
            nUP_Person.Minimum = 1;
            
            
           
            //do
            //{
            //    bookingnumber = _rndGen.Next(10000000, 999999999);
            //} while (DAL.DAL_Buchen.IsBookingNumberUsed(Convert.ToString(bookingnumber)));
            
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
        #region Checknames
        public bool CheckFormatSpace()
        {
            if (tbx_ort.Text != "" && tbx_plz.Text != "" && tbx_TelefonK.Text != "" && tbx_StraßeK.Text != "")
            {

                return true;
            }
            else
            {
                MessageBox.Show("Bitte alle Pflichtfelder ausfüllen!");
                return false;
            }
        }


       
        private bool CheckPostleitzahl()
        {
            string postleitzahl;
            postleitzahl = tbx_plz.Text;

            if (postleitzahl.Length == 4 && postleitzahl.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                if (postleitzahl == "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Das ist keine Österreichische Postleitzahl!");
                    return false;
                }

            }

        }

        
       
        private bool CheckPhoneNumber()
        {
            return true;
        }

       
        //private bool CheckTelAndStreet()
        //{


        //}
        #endregion
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


            };
            if (rdb_Mitglied.Checked)
            {
                buchung.isMitglied = 1;
            }
            else
            {
                buchung.isMitglied = 0;
            }
            if (user.Straße=="" || user.Telefonummer==""|| user.Ort=="" || user.PLZ=="")
            {
                if (CheckFormatSpace() && CheckPostleitzahl() && CheckPhoneNumber() || user.isAdmin == 1)
                {
                    user.Straße = tbx_StraßeK.Text;
                    user.Telefonummer = tbx_TelefonK.Text;
                    user.PLZ = tbx_plz.Text;
                    user.Ort = tbx_ort.Text;



                    if (DAL.DAL_Profil.IsUserUpdated(user))
                    {
                        InsertBuchung();
                        MessageBox.Show("Erfolgreich aktualisiert");
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
                buchungsbestätigung.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Buchung ist fehlgeschlagen");
            }
        }
          


        }
    }

