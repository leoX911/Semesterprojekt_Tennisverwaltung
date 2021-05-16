namespace Tennisverwaltungssystem.frm_login
{
    partial class frm_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_header_m = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_navbar_headline = new System.Windows.Forms.Button();
            this.pic_TCHard_Logo = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_BenutzerErstellen = new System.Windows.Forms.Label();
            this.txtbox_Passwort = new System.Windows.Forms.TextBox();
            this.lbl_Passwort = new System.Windows.Forms.Label();
            this.txtbox_EMail = new System.Windows.Forms.TextBox();
            this.lbl_EMail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_header_m.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TCHard_Logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header_m
            // 
            this.pnl_header_m.BackColor = System.Drawing.Color.White;
            this.pnl_header_m.Controls.Add(this.panel1);
            this.pnl_header_m.Controls.Add(this.pic_TCHard_Logo);
            this.pnl_header_m.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header_m.Location = new System.Drawing.Point(0, 0);
            this.pnl_header_m.Name = "pnl_header_m";
            this.pnl_header_m.Size = new System.Drawing.Size(1184, 108);
            this.pnl_header_m.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_navbar_headline);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 108);
            this.panel1.TabIndex = 5;
            // 
            // btn_navbar_headline
            // 
            this.btn_navbar_headline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_navbar_headline.FlatAppearance.BorderSize = 0;
            this.btn_navbar_headline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_navbar_headline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_navbar_headline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_navbar_headline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_navbar_headline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_navbar_headline.Location = new System.Drawing.Point(0, 0);
            this.btn_navbar_headline.Margin = new System.Windows.Forms.Padding(0);
            this.btn_navbar_headline.Name = "btn_navbar_headline";
            this.btn_navbar_headline.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btn_navbar_headline.Size = new System.Drawing.Size(223, 108);
            this.btn_navbar_headline.TabIndex = 6;
            this.btn_navbar_headline.Text = "BUCHUNGSYSTEM";
            this.btn_navbar_headline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_navbar_headline.UseVisualStyleBackColor = true;
            // 
            // pic_TCHard_Logo
            // 
            this.pic_TCHard_Logo.Image = global::Tennisverwaltungssystem.Properties.Resources.tchard_logo;
            this.pic_TCHard_Logo.Location = new System.Drawing.Point(523, 12);
            this.pic_TCHard_Logo.Name = "pic_TCHard_Logo";
            this.pic_TCHard_Logo.Size = new System.Drawing.Size(88, 83);
            this.pic_TCHard_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_TCHard_Logo.TabIndex = 0;
            this.pic_TCHard_Logo.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(170)))), ((int)(((byte)(194)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_login.Location = new System.Drawing.Point(130, 470);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(263, 39);
            this.btn_login.TabIndex = 11;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // lbl_BenutzerErstellen
            // 
            this.lbl_BenutzerErstellen.AutoSize = true;
            this.lbl_BenutzerErstellen.BackColor = System.Drawing.Color.White;
            this.lbl_BenutzerErstellen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(170)))), ((int)(((byte)(194)))));
            this.lbl_BenutzerErstellen.Location = new System.Drawing.Point(212, 515);
            this.lbl_BenutzerErstellen.Name = "lbl_BenutzerErstellen";
            this.lbl_BenutzerErstellen.Size = new System.Drawing.Size(91, 13);
            this.lbl_BenutzerErstellen.TabIndex = 12;
            this.lbl_BenutzerErstellen.Text = "Benutzer erstellen";
            this.lbl_BenutzerErstellen.Click += new System.EventHandler(this.Lbl_BenutzerErstellen_Click);
            // 
            // txtbox_Passwort
            // 
            this.txtbox_Passwort.BackColor = System.Drawing.Color.White;
            this.txtbox_Passwort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_Passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Passwort.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtbox_Passwort.Location = new System.Drawing.Point(196, 363);
            this.txtbox_Passwort.Name = "txtbox_Passwort";
            this.txtbox_Passwort.Size = new System.Drawing.Size(197, 27);
            this.txtbox_Passwort.TabIndex = 14;
            // 
            // lbl_Passwort
            // 
            this.lbl_Passwort.AutoSize = true;
            this.lbl_Passwort.BackColor = System.Drawing.Color.White;
            this.lbl_Passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Passwort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Passwort.Location = new System.Drawing.Point(127, 368);
            this.lbl_Passwort.Name = "lbl_Passwort";
            this.lbl_Passwort.Size = new System.Drawing.Size(63, 16);
            this.lbl_Passwort.TabIndex = 15;
            this.lbl_Passwort.Text = "Passwort";
            // 
            // txtbox_EMail
            // 
            this.txtbox_EMail.BackColor = System.Drawing.Color.White;
            this.txtbox_EMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_EMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_EMail.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtbox_EMail.Location = new System.Drawing.Point(196, 316);
            this.txtbox_EMail.Name = "txtbox_EMail";
            this.txtbox_EMail.Size = new System.Drawing.Size(197, 27);
            this.txtbox_EMail.TabIndex = 13;
            // 
            // lbl_EMail
            // 
            this.lbl_EMail.AutoSize = true;
            this.lbl_EMail.BackColor = System.Drawing.Color.White;
            this.lbl_EMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_EMail.Location = new System.Drawing.Point(127, 321);
            this.lbl_EMail.Name = "lbl_EMail";
            this.lbl_EMail.Size = new System.Drawing.Size(46, 16);
            this.lbl_EMail.TabIndex = 10;
            this.lbl_EMail.Text = "E-Mail";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(103, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 380);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennisverwaltungssystem.Properties.Resources.Login_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_BenutzerErstellen);
            this.Controls.Add(this.txtbox_Passwort);
            this.Controls.Add(this.lbl_Passwort);
            this.Controls.Add(this.txtbox_EMail);
            this.Controls.Add(this.lbl_EMail);
            this.Controls.Add(this.pnl_header_m);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "frm_login";
            this.Text = "frm_login";
            this.pnl_header_m.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_TCHard_Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header_m;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_TCHard_Logo;
        private System.Windows.Forms.Button btn_navbar_headline;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_BenutzerErstellen;
        private System.Windows.Forms.TextBox txtbox_Passwort;
        private System.Windows.Forms.Label lbl_Passwort;
        private System.Windows.Forms.TextBox txtbox_EMail;
        private System.Windows.Forms.Label lbl_EMail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}