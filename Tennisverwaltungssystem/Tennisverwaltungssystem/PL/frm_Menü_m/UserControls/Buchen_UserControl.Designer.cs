namespace Tennisverwaltungssystem.frm_Menü_m.UserControls
{
    partial class Buchen_UserControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_buchung = new System.Windows.Forms.Panel();
            this.buchungenListe_UserControl1 = new Tennisverwaltungssystem.PL.frm_Menü_m.UserControls.BuchungenListe_UserControl();
            this.btn_nextpage = new System.Windows.Forms.Button();
            this.btn_today = new System.Windows.Forms.Button();
            this.btn_nextday = new System.Windows.Forms.Button();
            this.btn_prevDay = new System.Windows.Forms.Button();
            this.fl_Time = new System.Windows.Forms.Panel();
            this.fl_Platz = new System.Windows.Forms.FlowLayoutPanel();
            this.fp_overall = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_text_buchungsdetails = new System.Windows.Forms.Label();
            this.lbl_click_text_booking = new System.Windows.Forms.Label();
            this.lbl_subheader_meinebuchungen = new System.Windows.Forms.Label();
            this.lbl_subheader_neuebuchung = new System.Windows.Forms.Label();
            this.lbl_price_member = new System.Windows.Forms.Label();
            this.lbl_price_club = new System.Windows.Forms.Label();
            this.lbl_price_gast = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_member = new System.Windows.Forms.Label();
            this.lbl_club = new System.Windows.Forms.Label();
            this.lbl_price_subheader = new System.Windows.Forms.Label();
            this.lbl_guest = new System.Windows.Forms.Label();
            this.lbl_summerheader = new System.Windows.Forms.Label();
            this.lbl_buchungsüberischt_sub = new System.Windows.Forms.Label();
            this.lbl_buchen = new System.Windows.Forms.Label();
            this.pnl_buchung.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_buchung
            // 
            this.pnl_buchung.BackColor = System.Drawing.Color.White;
            this.pnl_buchung.Controls.Add(this.buchungenListe_UserControl1);
            this.pnl_buchung.Controls.Add(this.btn_nextpage);
            this.pnl_buchung.Controls.Add(this.btn_today);
            this.pnl_buchung.Controls.Add(this.btn_nextday);
            this.pnl_buchung.Controls.Add(this.btn_prevDay);
            this.pnl_buchung.Controls.Add(this.fl_Time);
            this.pnl_buchung.Controls.Add(this.fl_Platz);
            this.pnl_buchung.Controls.Add(this.fp_overall);
            this.pnl_buchung.Controls.Add(this.panel4);
            this.pnl_buchung.Controls.Add(this.lbl_text_buchungsdetails);
            this.pnl_buchung.Controls.Add(this.lbl_click_text_booking);
            this.pnl_buchung.Controls.Add(this.lbl_subheader_meinebuchungen);
            this.pnl_buchung.Controls.Add(this.lbl_subheader_neuebuchung);
            this.pnl_buchung.Controls.Add(this.lbl_price_member);
            this.pnl_buchung.Controls.Add(this.lbl_price_club);
            this.pnl_buchung.Controls.Add(this.lbl_price_gast);
            this.pnl_buchung.Controls.Add(this.panel3);
            this.pnl_buchung.Controls.Add(this.panel2);
            this.pnl_buchung.Controls.Add(this.lbl_member);
            this.pnl_buchung.Controls.Add(this.lbl_club);
            this.pnl_buchung.Controls.Add(this.lbl_price_subheader);
            this.pnl_buchung.Controls.Add(this.lbl_guest);
            this.pnl_buchung.Controls.Add(this.lbl_summerheader);
            this.pnl_buchung.Controls.Add(this.lbl_buchungsüberischt_sub);
            this.pnl_buchung.Location = new System.Drawing.Point(52, 86);
            this.pnl_buchung.Name = "pnl_buchung";
            this.pnl_buchung.Size = new System.Drawing.Size(827, 423);
            this.pnl_buchung.TabIndex = 3;
            // 
            // buchungenListe_UserControl1
            // 
            this.buchungenListe_UserControl1.BackColor = System.Drawing.Color.White;
            this.buchungenListe_UserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buchungenListe_UserControl1.Location = new System.Drawing.Point(22, 19);
            this.buchungenListe_UserControl1.Name = "buchungenListe_UserControl1";
            this.buchungenListe_UserControl1.Size = new System.Drawing.Size(583, 385);
            this.buchungenListe_UserControl1.TabIndex = 58;
            this.buchungenListe_UserControl1.Visible = false;
            // 
            // btn_nextpage
            // 
            this.btn_nextpage.Font = new System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nextpage.Location = new System.Drawing.Point(702, 375);
            this.btn_nextpage.Name = "btn_nextpage";
            this.btn_nextpage.Size = new System.Drawing.Size(97, 24);
            this.btn_nextpage.TabIndex = 57;
            this.btn_nextpage.Text = "weiter >>";
            this.btn_nextpage.UseVisualStyleBackColor = true;
            this.btn_nextpage.Click += new System.EventHandler(this.Btn_nextpage_Click);
            // 
            // btn_today
            // 
            this.btn_today.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_today.FlatAppearance.BorderSize = 0;
            this.btn_today.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_today.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_today.Location = new System.Drawing.Point(509, 19);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(54, 23);
            this.btn_today.TabIndex = 56;
            this.btn_today.Text = "Heute";
            this.btn_today.UseVisualStyleBackColor = false;
            this.btn_today.Click += new System.EventHandler(this.Btn_today_Click);
            // 
            // btn_nextday
            // 
            this.btn_nextday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_nextday.FlatAppearance.BorderSize = 0;
            this.btn_nextday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nextday.Location = new System.Drawing.Point(579, 19);
            this.btn_nextday.Name = "btn_nextday";
            this.btn_nextday.Size = new System.Drawing.Size(26, 23);
            this.btn_nextday.TabIndex = 55;
            this.btn_nextday.Text = ">";
            this.btn_nextday.UseVisualStyleBackColor = false;
            this.btn_nextday.Click += new System.EventHandler(this.Btn_nextday_Click);
            // 
            // btn_prevDay
            // 
            this.btn_prevDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_prevDay.FlatAppearance.BorderSize = 0;
            this.btn_prevDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prevDay.Location = new System.Drawing.Point(467, 19);
            this.btn_prevDay.Name = "btn_prevDay";
            this.btn_prevDay.Size = new System.Drawing.Size(26, 23);
            this.btn_prevDay.TabIndex = 54;
            this.btn_prevDay.Text = "<";
            this.btn_prevDay.UseVisualStyleBackColor = false;
            this.btn_prevDay.Click += new System.EventHandler(this.Btn_prevDay_Click);
            // 
            // fl_Time
            // 
            this.fl_Time.Location = new System.Drawing.Point(509, 48);
            this.fl_Time.Name = "fl_Time";
            this.fl_Time.Size = new System.Drawing.Size(96, 351);
            this.fl_Time.TabIndex = 53;
            // 
            // fl_Platz
            // 
            this.fl_Platz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fl_Platz.Location = new System.Drawing.Point(22, 48);
            this.fl_Platz.Name = "fl_Platz";
            this.fl_Platz.Size = new System.Drawing.Size(487, 22);
            this.fl_Platz.TabIndex = 52;
            // 
            // fp_overall
            // 
            this.fp_overall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fp_overall.Location = new System.Drawing.Point(22, 70);
            this.fp_overall.Name = "fp_overall";
            this.fp_overall.Size = new System.Drawing.Size(487, 330);
            this.fp_overall.TabIndex = 51;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(629, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 1);
            this.panel4.TabIndex = 43;
            // 
            // lbl_text_buchungsdetails
            // 
            this.lbl_text_buchungsdetails.AutoSize = true;
            this.lbl_text_buchungsdetails.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text_buchungsdetails.ForeColor = System.Drawing.Color.Gray;
            this.lbl_text_buchungsdetails.Location = new System.Drawing.Point(631, 318);
            this.lbl_text_buchungsdetails.Name = "lbl_text_buchungsdetails";
            this.lbl_text_buchungsdetails.Size = new System.Drawing.Size(66, 12);
            this.lbl_text_buchungsdetails.TabIndex = 50;
            this.lbl_text_buchungsdetails.Text = "Alle Buchungen";
            this.lbl_text_buchungsdetails.Click += new System.EventHandler(this.Lbl_text_buchungsdetails_Click);
            // 
            // lbl_click_text_booking
            // 
            this.lbl_click_text_booking.AutoSize = true;
            this.lbl_click_text_booking.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_click_text_booking.ForeColor = System.Drawing.Color.Gray;
            this.lbl_click_text_booking.Location = new System.Drawing.Point(626, 248);
            this.lbl_click_text_booking.Name = "lbl_click_text_booking";
            this.lbl_click_text_booking.Size = new System.Drawing.Size(79, 12);
            this.lbl_click_text_booking.TabIndex = 49;
            this.lbl_click_text_booking.Text = "Buchungsübersicht";
            this.lbl_click_text_booking.Click += new System.EventHandler(this.Lbl_click_text_booking_Click);
            // 
            // lbl_subheader_meinebuchungen
            // 
            this.lbl_subheader_meinebuchungen.AutoSize = true;
            this.lbl_subheader_meinebuchungen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subheader_meinebuchungen.Location = new System.Drawing.Point(629, 294);
            this.lbl_subheader_meinebuchungen.Name = "lbl_subheader_meinebuchungen";
            this.lbl_subheader_meinebuchungen.Size = new System.Drawing.Size(118, 17);
            this.lbl_subheader_meinebuchungen.TabIndex = 48;
            this.lbl_subheader_meinebuchungen.Tag = "#t";
            this.lbl_subheader_meinebuchungen.Text = "Meine Buchungen";
            // 
            // lbl_subheader_neuebuchung
            // 
            this.lbl_subheader_neuebuchung.AutoSize = true;
            this.lbl_subheader_neuebuchung.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subheader_neuebuchung.Location = new System.Drawing.Point(625, 226);
            this.lbl_subheader_neuebuchung.Name = "lbl_subheader_neuebuchung";
            this.lbl_subheader_neuebuchung.Size = new System.Drawing.Size(98, 17);
            this.lbl_subheader_neuebuchung.TabIndex = 47;
            this.lbl_subheader_neuebuchung.Tag = "#t";
            this.lbl_subheader_neuebuchung.Text = "Neue Buchung";
            // 
            // lbl_price_member
            // 
            this.lbl_price_member.AutoSize = true;
            this.lbl_price_member.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price_member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_price_member.Location = new System.Drawing.Point(779, 185);
            this.lbl_price_member.Name = "lbl_price_member";
            this.lbl_price_member.Size = new System.Drawing.Size(22, 15);
            this.lbl_price_member.TabIndex = 46;
            this.lbl_price_member.Text = "0 €";
            // 
            // lbl_price_club
            // 
            this.lbl_price_club.AutoSize = true;
            this.lbl_price_club.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price_club.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_price_club.Location = new System.Drawing.Point(779, 161);
            this.lbl_price_club.Name = "lbl_price_club";
            this.lbl_price_club.Size = new System.Drawing.Size(22, 15);
            this.lbl_price_club.TabIndex = 45;
            this.lbl_price_club.Text = "0 €";
            // 
            // lbl_price_gast
            // 
            this.lbl_price_gast.AutoSize = true;
            this.lbl_price_gast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price_gast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_price_gast.Location = new System.Drawing.Point(774, 137);
            this.lbl_price_gast.Name = "lbl_price_gast";
            this.lbl_price_gast.Size = new System.Drawing.Size(28, 15);
            this.lbl_price_gast.TabIndex = 44;
            this.lbl_price_gast.Text = "12 €";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(632, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 1);
            this.panel3.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(632, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 1);
            this.panel2.TabIndex = 42;
            // 
            // lbl_member
            // 
            this.lbl_member.AutoSize = true;
            this.lbl_member.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_member.Location = new System.Drawing.Point(626, 186);
            this.lbl_member.Name = "lbl_member";
            this.lbl_member.Size = new System.Drawing.Size(51, 15);
            this.lbl_member.TabIndex = 41;
            this.lbl_member.Text = "Mitglied";
            // 
            // lbl_club
            // 
            this.lbl_club.AutoSize = true;
            this.lbl_club.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_club.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_club.Location = new System.Drawing.Point(626, 161);
            this.lbl_club.Name = "lbl_club";
            this.lbl_club.Size = new System.Drawing.Size(32, 15);
            this.lbl_club.TabIndex = 40;
            this.lbl_club.Text = "Club";
            // 
            // lbl_price_subheader
            // 
            this.lbl_price_subheader.AutoSize = true;
            this.lbl_price_subheader.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price_subheader.Location = new System.Drawing.Point(627, 110);
            this.lbl_price_subheader.Name = "lbl_price_subheader";
            this.lbl_price_subheader.Size = new System.Drawing.Size(65, 11);
            this.lbl_price_subheader.TabIndex = 39;
            this.lbl_price_subheader.Tag = "#t";
            this.lbl_price_subheader.Text = "Preise pro Stunde";
            // 
            // lbl_guest
            // 
            this.lbl_guest.AutoSize = true;
            this.lbl_guest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_guest.Location = new System.Drawing.Point(626, 137);
            this.lbl_guest.Name = "lbl_guest";
            this.lbl_guest.Size = new System.Drawing.Size(30, 15);
            this.lbl_guest.TabIndex = 37;
            this.lbl_guest.Text = "Gast";
            // 
            // lbl_summerheader
            // 
            this.lbl_summerheader.AutoSize = true;
            this.lbl_summerheader.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_summerheader.Location = new System.Drawing.Point(625, 90);
            this.lbl_summerheader.Name = "lbl_summerheader";
            this.lbl_summerheader.Size = new System.Drawing.Size(100, 20);
            this.lbl_summerheader.TabIndex = 35;
            this.lbl_summerheader.Tag = "#t";
            this.lbl_summerheader.Text = "Sommer 2021";
            // 
            // lbl_buchungsüberischt_sub
            // 
            this.lbl_buchungsüberischt_sub.AutoSize = true;
            this.lbl_buchungsüberischt_sub.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buchungsüberischt_sub.Location = new System.Drawing.Point(23, 17);
            this.lbl_buchungsüberischt_sub.Name = "lbl_buchungsüberischt_sub";
            this.lbl_buchungsüberischt_sub.Size = new System.Drawing.Size(157, 21);
            this.lbl_buchungsüberischt_sub.TabIndex = 34;
            this.lbl_buchungsüberischt_sub.Text = "Buchungsübersicht |";
            // 
            // lbl_buchen
            // 
            this.lbl_buchen.AutoSize = true;
            this.lbl_buchen.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buchen.Location = new System.Drawing.Point(50, 48);
            this.lbl_buchen.Name = "lbl_buchen";
            this.lbl_buchen.Size = new System.Drawing.Size(75, 25);
            this.lbl_buchen.TabIndex = 34;
            this.lbl_buchen.Text = "Buchen";
            // 
            // Buchen_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_buchen);
            this.Controls.Add(this.pnl_buchung);
            this.Name = "Buchen_UserControl";
            this.Size = new System.Drawing.Size(941, 552);
            this.Load += new System.EventHandler(this.Buchen_UserControl_Load);
            this.pnl_buchung.ResumeLayout(false);
            this.pnl_buchung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_buchung;
        private System.Windows.Forms.Label lbl_buchen;
        private System.Windows.Forms.Label lbl_summerheader;
        private System.Windows.Forms.Label lbl_buchungsüberischt_sub;
        private System.Windows.Forms.Label lbl_text_buchungsdetails;
        private System.Windows.Forms.Label lbl_click_text_booking;
        private System.Windows.Forms.Label lbl_subheader_meinebuchungen;
        private System.Windows.Forms.Label lbl_price_member;
        private System.Windows.Forms.Label lbl_price_club;
        private System.Windows.Forms.Label lbl_price_gast;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_member;
        private System.Windows.Forms.Label lbl_club;
        private System.Windows.Forms.Label lbl_price_subheader;
        private System.Windows.Forms.Label lbl_guest;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel fp_overall;
        private System.Windows.Forms.Panel fl_Time;
        private System.Windows.Forms.FlowLayoutPanel fl_Platz;
        private System.Windows.Forms.Label lbl_subheader_neuebuchung;
        private System.Windows.Forms.Button btn_today;
        private System.Windows.Forms.Button btn_nextday;
        private System.Windows.Forms.Button btn_prevDay;
        private System.Windows.Forms.Button btn_nextpage;
        private PL.frm_Menü_m.UserControls.BuchungenListe_UserControl buchungenListe_UserControl1;
    }
}
