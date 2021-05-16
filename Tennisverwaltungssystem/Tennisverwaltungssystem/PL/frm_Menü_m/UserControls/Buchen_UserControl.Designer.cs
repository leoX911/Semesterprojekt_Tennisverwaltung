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
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.pnl_buchung.Controls.Add(this.listView1);
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
            this.pnl_buchung.Location = new System.Drawing.Point(55, 86);
            this.pnl_buchung.Name = "pnl_buchung";
            this.pnl_buchung.Size = new System.Drawing.Size(827, 423);
            this.pnl_buchung.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(602, 326);
            this.listView1.TabIndex = 51;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(639, 262);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 1);
            this.panel4.TabIndex = 43;
            // 
            // lbl_text_buchungsdetails
            // 
            this.lbl_text_buchungsdetails.AutoSize = true;
            this.lbl_text_buchungsdetails.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text_buchungsdetails.ForeColor = System.Drawing.Color.Gray;
            this.lbl_text_buchungsdetails.Location = new System.Drawing.Point(641, 299);
            this.lbl_text_buchungsdetails.Name = "lbl_text_buchungsdetails";
            this.lbl_text_buchungsdetails.Size = new System.Drawing.Size(71, 12);
            this.lbl_text_buchungsdetails.TabIndex = 50;
            this.lbl_text_buchungsdetails.Text = "Buchungsdetails ";
            // 
            // lbl_click_text_booking
            // 
            this.lbl_click_text_booking.AutoSize = true;
            this.lbl_click_text_booking.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_click_text_booking.ForeColor = System.Drawing.Color.Gray;
            this.lbl_click_text_booking.Location = new System.Drawing.Point(636, 230);
            this.lbl_click_text_booking.Name = "lbl_click_text_booking";
            this.lbl_click_text_booking.Size = new System.Drawing.Size(120, 12);
            this.lbl_click_text_booking.TabIndex = 49;
            this.lbl_click_text_booking.Text = "Hier klicken für neue Buchung";
            // 
            // lbl_subheader_meinebuchungen
            // 
            this.lbl_subheader_meinebuchungen.AutoSize = true;
            this.lbl_subheader_meinebuchungen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subheader_meinebuchungen.Location = new System.Drawing.Point(639, 275);
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
            this.lbl_subheader_neuebuchung.Location = new System.Drawing.Point(635, 207);
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
            this.lbl_price_member.Location = new System.Drawing.Point(789, 166);
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
            this.lbl_price_club.Location = new System.Drawing.Point(789, 142);
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
            this.lbl_price_gast.Location = new System.Drawing.Point(784, 118);
            this.lbl_price_gast.Name = "lbl_price_gast";
            this.lbl_price_gast.Size = new System.Drawing.Size(28, 15);
            this.lbl_price_gast.TabIndex = 44;
            this.lbl_price_gast.Text = "12 €";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(642, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 1);
            this.panel3.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(642, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 1);
            this.panel2.TabIndex = 42;
            // 
            // lbl_member
            // 
            this.lbl_member.AutoSize = true;
            this.lbl_member.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_member.Location = new System.Drawing.Point(636, 167);
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
            this.lbl_club.Location = new System.Drawing.Point(636, 142);
            this.lbl_club.Name = "lbl_club";
            this.lbl_club.Size = new System.Drawing.Size(32, 15);
            this.lbl_club.TabIndex = 40;
            this.lbl_club.Text = "Club";
            // 
            // lbl_price_subheader
            // 
            this.lbl_price_subheader.AutoSize = true;
            this.lbl_price_subheader.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price_subheader.Location = new System.Drawing.Point(637, 91);
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
            this.lbl_guest.Location = new System.Drawing.Point(636, 118);
            this.lbl_guest.Name = "lbl_guest";
            this.lbl_guest.Size = new System.Drawing.Size(30, 15);
            this.lbl_guest.TabIndex = 37;
            this.lbl_guest.Text = "Gast";
            // 
            // lbl_summerheader
            // 
            this.lbl_summerheader.AutoSize = true;
            this.lbl_summerheader.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_summerheader.Location = new System.Drawing.Point(635, 71);
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
            this.lbl_buchungsüberischt_sub.Size = new System.Drawing.Size(149, 21);
            this.lbl_buchungsüberischt_sub.TabIndex = 34;
            this.lbl_buchungsüberischt_sub.Text = "Buchungsübersicht";
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
            this.Controls.Add(this.lbl_buchen);
            this.Controls.Add(this.pnl_buchung);
            this.Name = "Buchen_UserControl";
            this.Size = new System.Drawing.Size(943, 554);
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
        private System.Windows.Forms.Label lbl_subheader_neuebuchung;
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
        private System.Windows.Forms.ListView listView1;
    }
}
