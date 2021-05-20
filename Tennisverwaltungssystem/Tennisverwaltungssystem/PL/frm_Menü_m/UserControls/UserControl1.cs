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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            User user = Übersicht_M._user;
            textBox1.Text=user.EMail;
        }
    }
}
