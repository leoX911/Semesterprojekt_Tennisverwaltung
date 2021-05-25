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
        int _anfangszeit;
        int _endzeit;
        DateTime _date;
        string DateToString;
       
        readonly User user = Übersicht_M._user;
        public KontaktformularBuchen(List<Daypanel> SelectedPanels)
        {
         
            InitializeComponent();
            Random _rndGen = new Random();
            int bookingnumber;
            
           
            do
            {
                bookingnumber = _rndGen.Next(10000000, 999999999);
            } while (DAL.DAL_Buchen.IsBookingNumberUsed(Convert.ToString(bookingnumber)));
            
            lbl_pltznummer.Text = Convert.ToString(SelectedPanels[0].Platznummer);

            if (SelectedPanels.Count==1)
            {
                _anfangszeit=SelectedPanels[0].Anfangszeit;
                _endzeit= SelectedPanels[0].Endzeit;
                _date= SelectedPanels[0].Date;
           
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
      

        
    }
}
