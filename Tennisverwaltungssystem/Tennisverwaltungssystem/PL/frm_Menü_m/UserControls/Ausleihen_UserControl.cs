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

namespace Tennisverwaltungssystem.frm_Menü_m.UserControls
{
    public partial class Ausleihen_UserControl : UserControl
    {
        private readonly Schläger GrapheneIST, GrapheneEXT, GrapheneKIDS, GrapheneLGT, GrapheneSPD,GrapheneMP;
        public Ausleihen_UserControl()
        {
            InitializeComponent();
            GrapheneIST = new Schläger();
            GrapheneEXT = new Schläger();
            GrapheneKIDS = new Schläger();
            GrapheneLGT = new Schläger();
            GrapheneMP = new Schläger();
            GrapheneSPD = new Schläger();

            GrapheneIST.Modell = "IST";
            GrapheneEXT.Modell = "EXT";
            GrapheneKIDS.Modell = "KIDS";
            GrapheneLGT.Modell = "LGT";
            GrapheneMP.Modell = "MP";
            GrapheneSPD.Modell = "SPD";


            CheckRackAval(btn_Graphene_IST, GrapheneIST);
            CheckRackAval(btn_Graphene_EXT, GrapheneEXT);
            CheckRackAval(btn_GrapheneSPD, GrapheneSPD);
            CheckRackAval(btn_GrapheneLGT, GrapheneLGT);
            CheckRackAval(btn_GrapheneMP, GrapheneMP);
            CheckRackAval(btn_GrapheneKIDS, GrapheneKIDS);



        }
        private void CheckRackAval(Button btn_schläger, Schläger schläger)
        {
            if (DAL.DAL_Ausleihen.isAvaiable(schläger))
            {
                btn_schläger.Text = "verfügbar";
                btn_schläger.BackColor = Color.Green;
            }
            else
            {
                btn_schläger.Text = "nicht verfügbar";
                btn_schläger.BackColor = Color.Red;
            }
        }

       
    }
}
