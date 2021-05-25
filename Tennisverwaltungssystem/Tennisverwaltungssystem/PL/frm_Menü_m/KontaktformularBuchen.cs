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
        readonly User user = Übersicht_M._user;
        public KontaktformularBuchen(List<Daypanel> SelectedPanels)
        {
            InitializeComponent();
            tbx_PlatznummerK.Text = Convert.ToString(SelectedPanels[1].Platznummer);
            if (user !=null)
            {
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
