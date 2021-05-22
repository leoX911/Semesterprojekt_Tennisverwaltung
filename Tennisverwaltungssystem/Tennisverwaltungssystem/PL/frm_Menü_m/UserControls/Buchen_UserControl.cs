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
       
        private DateTime currentdateTime = DateTime.Today;
        private List<FlowLayoutPanel> listFlDay = new List<FlowLayoutPanel>();
        private List<FlowLayoutPanel> listFlPlatz = new List<FlowLayoutPanel>();
        private List<FlowLayoutPanel> listFltime = new List<FlowLayoutPanel>();
        public Buchen_UserControl()
        {
            InitializeComponent();
            DisplayCurrentDate();
            GeneratePlatzPanel(5);
            AddLabelToPlatzPanel();
            GenerateZeitPanel(16);
            AddLabelToTimePanel(1);
            GenerateDayPanel();
            AddLabelToDayPanel();



            BorderStyle = BorderStyle.None;

        }
        #region GeneratePanels
        private void Buchen_UserControl_Load(object sender, EventArgs e)
        {

        }
        private void GenerateDayPanel()
        {

            for (int i = 0; i < listFlPlatz.Count; i++)
            {
              
                for (int j = 0; j < listFltime.Count; j++)
                {

                    FlowLayoutPanel f1 = new FlowLayoutPanel()
                    {

                        Name = $"{listFlPlatz[i].Name} + {listFltime[j].Name}",
                        Size = new Size(97, 22),
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(0),


                    };
                    listFlDay.Add(f1);
                    fp_overall.Controls.Add(f1);
                }
                

            }
              
            

            
        }

        private void GeneratePlatzPanel(int Plätze)
        {
            listFlDay.Clear();
            for (int i = 0; i < Plätze; i++)
            {
                FlowLayoutPanel f2 = new FlowLayoutPanel()
                {

                    Name = $"Platz{i}",
                    Size = new Size(97, 22),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(0),
                 
                    

                   


                };
                fl_Platz.Controls.Add(f2);
                listFlPlatz.Add(f2);
            }
        }

        private void GenerateZeitPanel(int Zeit)
        {
            int Anfangszeit1 = 22;
            int Endzeit1 = Anfangszeit1 + 1;
            listFltime.Clear();
            for (int i =0; i < Zeit; i++)
            {

                FlowLayoutPanel f3 = new FlowLayoutPanel()
                {

                    Name = $"{Anfangszeit1}:00-{Endzeit1}:00",
                    Size = new Size(97, 22),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(0),
                    Dock = DockStyle.Top,

                };
                Anfangszeit1--;
                Endzeit1--;
                fl_Time.Controls.Add(f3);
                listFltime.Add(f3);

            }
        }
        private void AddLabelToPlatzPanel()
        {
            for (int i = 1; i <= listFlPlatz.Count; i++)
            {
                Label lbl = new Label()
                {
                    Name = $"Platz{i}",
                    //AutoSize = false,
                    Text= $"Platz{i}",
                    ForeColor = Color.Black,
                    Font= new Font("Segou UI",10),
                    
                };
                listFlPlatz[i-1].Controls.Add(lbl);

            }
        }

        private void AddLabelToDayPanel()
        {
            for (int i = 0; i < listFlDay.Count; i++)
            {
                Label lbl1 = new Label()
                {
                    Name = $"lbl{i}",
                    //AutoSize = false,
                    Text = $"{listFlDay[i].Name}",
                    ForeColor = Color.Black,
                    Font = new Font("Segou UI", 6),

                };
                listFlDay[i].Controls.Add(lbl1);

            }
        }

        private void AddLabelToTimePanel(int starttime)
        {
            int Anfangszeit1 = 22;
            int Endzeit1 = Anfangszeit1 + 1;
            for (int i = starttime; i <= listFltime.Count; i++)
            {
                
                Label lbl = new Label()
                {
                    Name = $"Time{i}",
                    //AutoSize = false,

                    ForeColor = Color.Black,
                    Font = new Font("Segou UI", 8),
                    Text = $"{Anfangszeit1}:00-{Endzeit1}:00",
                   
                };
                Anfangszeit1--;
                Endzeit1--;
                if (i==16)
                {
                    break;
                }
                listFltime[i-1].Controls.Add(lbl);

            }
        }
        #endregion
        private void DisplayCurrentDate()
        {
            lbl_buchungsüberischt_sub.Text = currentdateTime.ToString("dddd, MMM d");
        }
        private void PrevDay()
        {
            currentdateTime = currentdateTime.AddDays(-1);
            DisplayCurrentDate();   
        }
        private void NextDay()
        {
            currentdateTime = currentdateTime.AddDays(1);
            DisplayCurrentDate();
        }

        private void Btn_prevDay_Click(object sender, EventArgs e)
        {
            PrevDay();
          

        }

        private void Btn_nextday_Click(object sender, EventArgs e)
        {
            NextDay();
         
        }

        private void Btn_today_Click(object sender, EventArgs e)
        {
            currentdateTime = DateTime.Today;
            DisplayCurrentDate();
        }
    }
}
