namespace Tennisverwaltungssystem.frm_Menü_m.UserControls
{
    partial class Überischt_UserControl
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
            this.pnl_container = new System.Windows.Forms.Panel();
            this.linklbl_website = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_profil = new System.Windows.Forms.Button();
            this.btn_bookings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_change_password = new System.Windows.Forms.Button();
            this.lbl_text_2_übersicht = new System.Windows.Forms.Label();
            this.lbl_text_übersicht = new System.Windows.Forms.Label();
            this.lbl_welcome_user = new System.Windows.Forms.Label();
            this.picbox_tennimg_tchard = new System.Windows.Forms.PictureBox();
            this.btn_statistics_1 = new System.Windows.Forms.Button();
            this.btn_statistics_3 = new System.Windows.Forms.Button();
            this.lbl_statistics_1 = new System.Windows.Forms.Label();
            this.btn_statistics_2 = new System.Windows.Forms.Button();
            this.lbl_statistics_2 = new System.Windows.Forms.Label();
            this.btn_statistics_4 = new System.Windows.Forms.Button();
            this.lbl_statistics_3 = new System.Windows.Forms.Label();
            this.lbl_statistics_4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_tennimg_tchard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_container
            // 
            this.pnl_container.BackColor = System.Drawing.Color.White;
            this.pnl_container.Controls.Add(this.linklbl_website);
            this.pnl_container.Controls.Add(this.panel3);
            this.pnl_container.Controls.Add(this.btn_profil);
            this.pnl_container.Controls.Add(this.btn_bookings);
            this.pnl_container.Controls.Add(this.panel2);
            this.pnl_container.Controls.Add(this.btn_change_password);
            this.pnl_container.Controls.Add(this.lbl_text_2_übersicht);
            this.pnl_container.Controls.Add(this.lbl_text_übersicht);
            this.pnl_container.Controls.Add(this.lbl_welcome_user);
            this.pnl_container.Controls.Add(this.picbox_tennimg_tchard);
            this.pnl_container.Location = new System.Drawing.Point(56, 230);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(809, 269);
            this.pnl_container.TabIndex = 0;
            this.pnl_container.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // linklbl_website
            // 
            this.linklbl_website.AutoSize = true;
            this.linklbl_website.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_website.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(171)))), ((int)(((byte)(195)))));
            this.linklbl_website.Location = new System.Drawing.Point(38, 113);
            this.linklbl_website.Name = "linklbl_website";
            this.linklbl_website.Size = new System.Drawing.Size(85, 15);
            this.linklbl_website.TabIndex = 8;
            this.linklbl_website.TabStop = true;
            this.linklbl_website.Text = "www.tchard.at";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(39, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 1);
            this.panel3.TabIndex = 6;
            // 
            // btn_profil
            // 
            this.btn_profil.FlatAppearance.BorderSize = 0;
            this.btn_profil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_profil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_profil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_profil.Location = new System.Drawing.Point(39, 217);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(135, 30);
            this.btn_profil.TabIndex = 7;
            this.btn_profil.Text = "Profil verwalten";
            this.btn_profil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Click += new System.EventHandler(this.Btn_profil_Click);
            // 
            // btn_bookings
            // 
            this.btn_bookings.FlatAppearance.BorderSize = 0;
            this.btn_bookings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_bookings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_bookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bookings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_bookings.Location = new System.Drawing.Point(39, 178);
            this.btn_bookings.Name = "btn_bookings";
            this.btn_bookings.Size = new System.Drawing.Size(135, 30);
            this.btn_bookings.TabIndex = 6;
            this.btn_bookings.Text = "Buchungen verwalten";
            this.btn_bookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bookings.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(39, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 1);
            this.panel2.TabIndex = 5;
            // 
            // btn_change_password
            // 
            this.btn_change_password.FlatAppearance.BorderSize = 0;
            this.btn_change_password.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_change_password.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_change_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_change_password.Location = new System.Drawing.Point(39, 137);
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.Size = new System.Drawing.Size(135, 30);
            this.btn_change_password.TabIndex = 4;
            this.btn_change_password.Text = "Passwort ändern";
            this.btn_change_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_change_password.UseVisualStyleBackColor = true;
            // 
            // lbl_text_2_übersicht
            // 
            this.lbl_text_2_übersicht.AutoSize = true;
            this.lbl_text_2_übersicht.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text_2_übersicht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.lbl_text_2_übersicht.Location = new System.Drawing.Point(36, 92);
            this.lbl_text_2_übersicht.Name = "lbl_text_2_übersicht";
            this.lbl_text_2_übersicht.Size = new System.Drawing.Size(114, 15);
            this.lbl_text_2_übersicht.TabIndex = 3;
            this.lbl_text_2_übersicht.Text = "auf unserer Website!";
            // 
            // lbl_text_übersicht
            // 
            this.lbl_text_übersicht.AutoSize = true;
            this.lbl_text_übersicht.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text_übersicht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.lbl_text_übersicht.Location = new System.Drawing.Point(36, 74);
            this.lbl_text_übersicht.Name = "lbl_text_übersicht";
            this.lbl_text_übersicht.Size = new System.Drawing.Size(328, 15);
            this.lbl_text_übersicht.TabIndex = 2;
            this.lbl_text_übersicht.Text = "Sie finden sämtliche Preise, Tarife und weitere Informationen ";
            // 
            // lbl_welcome_user
            // 
            this.lbl_welcome_user.AutoSize = true;
            this.lbl_welcome_user.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome_user.Location = new System.Drawing.Point(34, 32);
            this.lbl_welcome_user.Name = "lbl_welcome_user";
            this.lbl_welcome_user.Size = new System.Drawing.Size(172, 25);
            this.lbl_welcome_user.TabIndex = 1;
            this.lbl_welcome_user.Text = "Wilkommen USER!";
            // 
            // picbox_tennimg_tchard
            // 
            this.picbox_tennimg_tchard.Dock = System.Windows.Forms.DockStyle.Right;
            this.picbox_tennimg_tchard.Image = global::Tennisverwaltungssystem.Properties.Resources.übersicht_tennisclub;
            this.picbox_tennimg_tchard.Location = new System.Drawing.Point(402, 0);
            this.picbox_tennimg_tchard.Name = "picbox_tennimg_tchard";
            this.picbox_tennimg_tchard.Size = new System.Drawing.Size(407, 269);
            this.picbox_tennimg_tchard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_tennimg_tchard.TabIndex = 0;
            this.picbox_tennimg_tchard.TabStop = false;
            // 
            // btn_statistics_1
            // 
            this.btn_statistics_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(171)))), ((int)(((byte)(195)))));
            this.btn_statistics_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistics_1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statistics_1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_statistics_1.Location = new System.Drawing.Point(56, 102);
            this.btn_statistics_1.Name = "btn_statistics_1";
            this.btn_statistics_1.Size = new System.Drawing.Size(150, 69);
            this.btn_statistics_1.TabIndex = 2;
            this.btn_statistics_1.Text = "61 ";
            this.btn_statistics_1.UseVisualStyleBackColor = false;
            // 
            // btn_statistics_3
            // 
            this.btn_statistics_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(121)))), ((int)(((byte)(60)))));
            this.btn_statistics_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistics_3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_statistics_3.ForeColor = System.Drawing.Color.White;
            this.btn_statistics_3.Location = new System.Drawing.Point(502, 101);
            this.btn_statistics_3.Name = "btn_statistics_3";
            this.btn_statistics_3.Size = new System.Drawing.Size(153, 69);
            this.btn_statistics_3.TabIndex = 3;
            this.btn_statistics_3.Text = "76%";
            this.btn_statistics_3.UseVisualStyleBackColor = false;
            // 
            // lbl_statistics_1
            // 
            this.lbl_statistics_1.AutoSize = true;
            this.lbl_statistics_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_statistics_1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statistics_1.ForeColor = System.Drawing.Color.Gray;
            this.lbl_statistics_1.Location = new System.Drawing.Point(85, 174);
            this.lbl_statistics_1.Name = "lbl_statistics_1";
            this.lbl_statistics_1.Size = new System.Drawing.Size(85, 12);
            this.lbl_statistics_1.TabIndex = 9;
            this.lbl_statistics_1.Text = "Spiele diesen Monat\r\n";
            // 
            // btn_statistics_2
            // 
            this.btn_statistics_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(187)))), ((int)(((byte)(116)))));
            this.btn_statistics_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistics_2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statistics_2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_statistics_2.Location = new System.Drawing.Point(279, 102);
            this.btn_statistics_2.Name = "btn_statistics_2";
            this.btn_statistics_2.Size = new System.Drawing.Size(150, 69);
            this.btn_statistics_2.TabIndex = 10;
            this.btn_statistics_2.Text = "1666";
            this.btn_statistics_2.UseVisualStyleBackColor = false;
            // 
            // lbl_statistics_2
            // 
            this.lbl_statistics_2.AutoSize = true;
            this.lbl_statistics_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_statistics_2.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statistics_2.ForeColor = System.Drawing.Color.Gray;
            this.lbl_statistics_2.Location = new System.Drawing.Point(316, 174);
            this.lbl_statistics_2.Name = "lbl_statistics_2";
            this.lbl_statistics_2.Size = new System.Drawing.Size(75, 12);
            this.lbl_statistics_2.TabIndex = 11;
            this.lbl_statistics_2.Text = "ITN diesen Monat";
            // 
            // btn_statistics_4
            // 
            this.btn_statistics_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btn_statistics_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistics_4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_statistics_4.ForeColor = System.Drawing.Color.White;
            this.btn_statistics_4.Location = new System.Drawing.Point(712, 102);
            this.btn_statistics_4.Name = "btn_statistics_4";
            this.btn_statistics_4.Size = new System.Drawing.Size(153, 69);
            this.btn_statistics_4.TabIndex = 12;
            this.btn_statistics_4.Text = "Veteran";
            this.btn_statistics_4.UseVisualStyleBackColor = false;
            // 
            // lbl_statistics_3
            // 
            this.lbl_statistics_3.AutoSize = true;
            this.lbl_statistics_3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_statistics_3.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statistics_3.ForeColor = System.Drawing.Color.Gray;
            this.lbl_statistics_3.Location = new System.Drawing.Point(558, 173);
            this.lbl_statistics_3.Name = "lbl_statistics_3";
            this.lbl_statistics_3.Size = new System.Drawing.Size(22, 12);
            this.lbl_statistics_3.TabIndex = 13;
            this.lbl_statistics_3.Text = "GuV";
            // 
            // lbl_statistics_4
            // 
            this.lbl_statistics_4.AutoSize = true;
            this.lbl_statistics_4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_statistics_4.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statistics_4.ForeColor = System.Drawing.Color.Gray;
            this.lbl_statistics_4.Location = new System.Drawing.Point(761, 173);
            this.lbl_statistics_4.Name = "lbl_statistics_4";
            this.lbl_statistics_4.Size = new System.Drawing.Size(48, 12);
            this.lbl_statistics_4.TabIndex = 14;
            this.lbl_statistics_4.Text = "Spielstärke";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Übersicht";
            // 
            // Überischt_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_statistics_4);
            this.Controls.Add(this.lbl_statistics_3);
            this.Controls.Add(this.btn_statistics_4);
            this.Controls.Add(this.lbl_statistics_2);
            this.Controls.Add(this.btn_statistics_2);
            this.Controls.Add(this.lbl_statistics_1);
            this.Controls.Add(this.btn_statistics_3);
            this.Controls.Add(this.btn_statistics_1);
            this.Controls.Add(this.pnl_container);
            this.Name = "Überischt_UserControl";
            this.Size = new System.Drawing.Size(943, 554);
            this.pnl_container.ResumeLayout(false);
            this.pnl_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_tennimg_tchard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_container;
        private System.Windows.Forms.PictureBox picbox_tennimg_tchard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.Button btn_bookings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_change_password;
        private System.Windows.Forms.Label lbl_text_2_übersicht;
        private System.Windows.Forms.Label lbl_text_übersicht;
        private System.Windows.Forms.Label lbl_welcome_user;
        private System.Windows.Forms.LinkLabel linklbl_website;
        private System.Windows.Forms.Button btn_statistics_3;
        private System.Windows.Forms.Label lbl_statistics_1;
        private System.Windows.Forms.Button btn_statistics_2;
        private System.Windows.Forms.Label lbl_statistics_2;
        private System.Windows.Forms.Button btn_statistics_4;
        private System.Windows.Forms.Label lbl_statistics_3;
        private System.Windows.Forms.Label lbl_statistics_4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_statistics_1;
    }
}
