using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennisverwaltungssystem.PL.frm_Menü_m.UserControls;

namespace Tennisverwaltungssystem.frm_Menü_m.UserControls
{
    public partial class Buchen_UserControl : UserControl
    {
       
        private DateTime currentdateTime = DateTime.Today;
        private readonly List<Daypanel>  listFlDay = new List<Daypanel>();
        private readonly List<FlowLayoutPanel> listFlPlatz = new List<FlowLayoutPanel>();
        private readonly List<FlowLayoutPanel> listFltime = new List<FlowLayoutPanel>();
        public Buchen_UserControl()
        {
            InitializeComponent();
           
            GeneratePlatzPanel(5);
            AddLabelToPlatzPanel();

            GenerateZeitPanel(16);
            AddLabelToTimePanel(22);

            GenerateDayPanel();
            DisplayCurrentDate();




            BorderStyle = BorderStyle.None;

        }
        #region GeneratePanels
        private void AddNewBooking(object sender, EventArgs e)
        {
            MessageBox.Show("nice");
            
            DisplayCurrentDate();
        }
        private void Buchen_UserControl_Load(object sender, EventArgs e)
        {

        }
        private void GenerateDayPanel()
        {
            listFlDay.Clear();
           
            for (int i = 0; i < listFltime.Count; i++)
            {
              
                for (int j = 0; j < listFlPlatz.Count; j++)
                {

                    Daypanel f1 = new Daypanel()
                    {

                        Name = $"{listFlPlatz[j].Name};{listFltime[i].Name}",
                        Size = new Size(97, 22),
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(0),
                        Platznummer = Convert.ToInt32(listFlPlatz[j].Name),
                        Anfangszeit = Convert.ToInt32(listFltime[i].Name),
                        Endzeit = Convert.ToInt32(listFltime[i].Name) + 1,
                        Occupied = false,
                        Date = currentdateTime,
                        

                        

                    };
                    f1.Cursor = Cursors.Hand;
                    f1.Click += AddNewBooking;
                    listFlDay.Add(f1);
                    fp_overall.Controls.Add(f1);
                   
                    
                }
                

            }
              
            

            
        }

        private void GeneratePlatzPanel(int Plätze)
        {
            listFlDay.Clear();
            for (int i = 1; i <= Plätze; i++)
            {
                FlowLayoutPanel f2 = new FlowLayoutPanel()
                {

                    Name = $"{i}",
                    Size = new Size(97, 22),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(0),
                    
                    

                   


                };
                fl_Platz.Controls.Add(f2);
                listFlPlatz.Add(f2);
            }
        }

        private void ShowBookingToFlDay()
        {
            foreach (Daypanel f1 in listFlDay)
            {
                if (DAL.DAL_Buchen.isOccupied(f1))
                {
                    f1.BackColor = Color.Red;
                    f1.Occupied = true;
                }
                else
                {
                    f1.Occupied = false;
                    f1.BackColor = Color.White;
                }
            }

        }
        private void GenerateZeitPanel(int Zeit)
        {
            
            int Anfangszeit1 = 8;
            int Endzeit1 = Anfangszeit1 + 1;
            listFltime.Clear();
            for (int i =0; i < Zeit; i++)
            {

                FlowLayoutPanel f3 = new FlowLayoutPanel()
                {

                    Name = $"{Anfangszeit1}",
                    Size = new Size(97, 22),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(0),
                    Dock = DockStyle.Top,

                };
                Anfangszeit1++;
                Endzeit1++;
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
            
            foreach (Daypanel fl in listFlDay)
            {
                fl.Controls.Clear();
              
            }
            for (int i = 0; i < listFlDay.Count; i++)
            {
            
                Label lbl1 = new Label()
                {
                    Name = $"lbl{i}",
                    //AutoSize = false,
                    Text = "besetzt",
                    ForeColor = Color.White,
                    Font = new Font("Segou UI", 7),

                };
                
                if (listFlDay[i].Occupied)
                {
                    listFlDay[i].Controls.Add(lbl1);
                }


            }
        }

        private void AddLabelToTimePanel(int Anfangszeit1)
        {
            
            int Endzeit1 = Anfangszeit1 + 1;
            for (int i = 1; i <= listFltime.Count-1; i++)
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
               
                listFltime[i-1].Controls.Add(lbl);

            }
        }
        private void UpdateflDateToCurrentDate()
        {
            foreach (Daypanel f1 in listFlDay)
            {
                f1.Date = currentdateTime;
            }
        }
        #endregion
        private void DisplayCurrentDate()
        {

           
            UpdateflDateToCurrentDate();
       
            ShowBookingToFlDay();
            AddLabelToDayPanel();
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
