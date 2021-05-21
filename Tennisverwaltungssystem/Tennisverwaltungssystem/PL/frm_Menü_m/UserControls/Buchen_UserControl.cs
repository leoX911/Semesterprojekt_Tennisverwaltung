using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennisverwaltungssystem.frm_Menü_m.UserControls
{
    public partial class Buchen_UserControl : UserControl
    {
        public Buchen_UserControl()
        {
            InitializeComponent();
            GenerateDayPanel(90);
            BorderStyle = BorderStyle.None;

        }

        private void Buchen_UserControl_Load(object sender, EventArgs e)
        {

        }
        private void GenerateDayPanel(int totaDays)
        {
            for (int i = 1; i < totaDays; i++)
            {
                FlowLayoutPanel f1 = new FlowLayoutPanel()
                {
                    Name = $"flDay{i}",
                    Size = new Size(97, 22),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin=new Padding(0),
                   

                };

                fp_overall.Controls.Add(f1);
            }
        }

       
    }
}
