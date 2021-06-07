using System.Windows.Forms;

namespace Tennisverwaltungssystem.frm_Menü_m.UserControls
{
    public partial class Überischt_UserControl : UserControl
    {
        public Überischt_UserControl()
        {
            InitializeComponent();
            if (Übersicht_M._user!=null)
            {
                lbl_welcome_user.Text = "Wilkommen Herr/Frau "+Übersicht_M._user.Nachname;
            }
            
         
        }
    }
}
