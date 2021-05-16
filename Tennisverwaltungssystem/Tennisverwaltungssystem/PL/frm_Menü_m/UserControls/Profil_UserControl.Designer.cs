namespace Tennisverwaltungssystem.frm_Menü_m.UserControls
{
    partial class Profil_UserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_changedata = new System.Windows.Forms.Button();
            this.btn_cleardata = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_persondata = new System.Windows.Forms.Panel();
            this.lbl_persondata = new System.Windows.Forms.Label();
            this.lbl_geschlecht = new System.Windows.Forms.Label();
            this.lbl_straße = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtbox_telnummer = new System.Windows.Forms.TextBox();
            this.textbox_straße = new System.Windows.Forms.TextBox();
            this.txtbox_nachname = new System.Windows.Forms.TextBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.pnl_logindata = new System.Windows.Forms.Panel();
            this.lbl_passwort = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtBox_passwort = new System.Windows.Forms.TextBox();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.lbl_logindata = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pixbox_tennisimg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnl_persondata.SuspendLayout();
            this.pnl_logindata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixbox_tennisimg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_changedata);
            this.panel1.Controls.Add(this.btn_cleardata);
            this.panel1.Location = new System.Drawing.Point(656, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 98);
            this.panel1.TabIndex = 0;
            // 
            // btn_changedata
            // 
            this.btn_changedata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(63)))), ((int)(((byte)(78)))));
            this.btn_changedata.FlatAppearance.BorderSize = 0;
            this.btn_changedata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(171)))), ((int)(((byte)(195)))));
            this.btn_changedata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(171)))), ((int)(((byte)(195)))));
            this.btn_changedata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changedata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changedata.ForeColor = System.Drawing.Color.White;
            this.btn_changedata.Location = new System.Drawing.Point(13, 56);
            this.btn_changedata.Name = "btn_changedata";
            this.btn_changedata.Size = new System.Drawing.Size(194, 28);
            this.btn_changedata.TabIndex = 1;
            this.btn_changedata.Text = "Änderungen speichern";
            this.btn_changedata.UseVisualStyleBackColor = false;
            // 
            // btn_cleardata
            // 
            this.btn_cleardata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(63)))), ((int)(((byte)(78)))));
            this.btn_cleardata.FlatAppearance.BorderSize = 0;
            this.btn_cleardata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(171)))), ((int)(((byte)(195)))));
            this.btn_cleardata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(171)))), ((int)(((byte)(195)))));
            this.btn_cleardata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cleardata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cleardata.ForeColor = System.Drawing.Color.White;
            this.btn_cleardata.Location = new System.Drawing.Point(13, 18);
            this.btn_cleardata.Name = "btn_cleardata";
            this.btn_cleardata.Size = new System.Drawing.Size(194, 28);
            this.btn_cleardata.TabIndex = 0;
            this.btn_cleardata.Text = "Daten löschen";
            this.btn_cleardata.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(656, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 336);
            this.panel2.TabIndex = 1;
            // 
            // pnl_persondata
            // 
            this.pnl_persondata.BackColor = System.Drawing.Color.White;
            this.pnl_persondata.Controls.Add(this.lbl_persondata);
            this.pnl_persondata.Controls.Add(this.lbl_geschlecht);
            this.pnl_persondata.Controls.Add(this.lbl_straße);
            this.pnl_persondata.Controls.Add(this.lbl_telefon);
            this.pnl_persondata.Controls.Add(this.lbl_name);
            this.pnl_persondata.Controls.Add(this.txtbox_telnummer);
            this.pnl_persondata.Controls.Add(this.textbox_straße);
            this.pnl_persondata.Controls.Add(this.txtbox_nachname);
            this.pnl_persondata.Controls.Add(this.txtbox_name);
            this.pnl_persondata.Location = new System.Drawing.Point(66, 69);
            this.pnl_persondata.Name = "pnl_persondata";
            this.pnl_persondata.Size = new System.Drawing.Size(560, 268);
            this.pnl_persondata.TabIndex = 2;
            // 
            // lbl_persondata
            // 
            this.lbl_persondata.AutoSize = true;
            this.lbl_persondata.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_persondata.Location = new System.Drawing.Point(19, 20);
            this.lbl_persondata.Name = "lbl_persondata";
            this.lbl_persondata.Size = new System.Drawing.Size(119, 21);
            this.lbl_persondata.TabIndex = 37;
            this.lbl_persondata.Text = "Personendaten";
            // 
            // lbl_geschlecht
            // 
            this.lbl_geschlecht.AutoSize = true;
            this.lbl_geschlecht.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_geschlecht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_geschlecht.Location = new System.Drawing.Point(19, 206);
            this.lbl_geschlecht.Name = "lbl_geschlecht";
            this.lbl_geschlecht.Size = new System.Drawing.Size(45, 15);
            this.lbl_geschlecht.TabIndex = 7;
            this.lbl_geschlecht.Text = "Telefon";
            // 
            // lbl_straße
            // 
            this.lbl_straße.AutoSize = true;
            this.lbl_straße.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_straße.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_straße.Location = new System.Drawing.Point(20, 161);
            this.lbl_straße.Name = "lbl_straße";
            this.lbl_straße.Size = new System.Drawing.Size(40, 15);
            this.lbl_straße.TabIndex = 6;
            this.lbl_straße.Text = "Straße";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_telefon.Location = new System.Drawing.Point(20, 111);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(70, 15);
            this.lbl_telefon.TabIndex = 5;
            this.lbl_telefon.Text = "Nachname*";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_name.Location = new System.Drawing.Point(20, 66);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(59, 15);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Vorname*";
            // 
            // txtbox_telnummer
            // 
            this.txtbox_telnummer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_telnummer.Location = new System.Drawing.Point(103, 201);
            this.txtbox_telnummer.Name = "txtbox_telnummer";
            this.txtbox_telnummer.Size = new System.Drawing.Size(392, 25);
            this.txtbox_telnummer.TabIndex = 3;
            // 
            // textbox_straße
            // 
            this.textbox_straße.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_straße.Location = new System.Drawing.Point(103, 154);
            this.textbox_straße.Name = "textbox_straße";
            this.textbox_straße.Size = new System.Drawing.Size(392, 25);
            this.textbox_straße.TabIndex = 2;
            // 
            // txtbox_nachname
            // 
            this.txtbox_nachname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nachname.Location = new System.Drawing.Point(103, 107);
            this.txtbox_nachname.Name = "txtbox_nachname";
            this.txtbox_nachname.Size = new System.Drawing.Size(392, 25);
            this.txtbox_nachname.TabIndex = 1;
            // 
            // txtbox_name
            // 
            this.txtbox_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_name.Location = new System.Drawing.Point(103, 62);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(392, 25);
            this.txtbox_name.TabIndex = 0;
            // 
            // pnl_logindata
            // 
            this.pnl_logindata.BackColor = System.Drawing.Color.White;
            this.pnl_logindata.Controls.Add(this.lbl_passwort);
            this.pnl_logindata.Controls.Add(this.lbl_email);
            this.pnl_logindata.Controls.Add(this.txtBox_passwort);
            this.pnl_logindata.Controls.Add(this.txtbox_email);
            this.pnl_logindata.Controls.Add(this.lbl_logindata);
            this.pnl_logindata.Location = new System.Drawing.Point(66, 357);
            this.pnl_logindata.Name = "pnl_logindata";
            this.pnl_logindata.Size = new System.Drawing.Size(560, 166);
            this.pnl_logindata.TabIndex = 3;
            // 
            // lbl_passwort
            // 
            this.lbl_passwort.AutoSize = true;
            this.lbl_passwort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_passwort.Location = new System.Drawing.Point(20, 109);
            this.lbl_passwort.Name = "lbl_passwort";
            this.lbl_passwort.Size = new System.Drawing.Size(59, 15);
            this.lbl_passwort.TabIndex = 42;
            this.lbl_passwort.Text = "Passwort*";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_email.Location = new System.Drawing.Point(20, 64);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(46, 15);
            this.lbl_email.TabIndex = 41;
            this.lbl_email.Text = "E-Mail*";
            // 
            // txtBox_passwort
            // 
            this.txtBox_passwort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_passwort.Location = new System.Drawing.Point(103, 105);
            this.txtBox_passwort.Name = "txtBox_passwort";
            this.txtBox_passwort.Size = new System.Drawing.Size(392, 25);
            this.txtBox_passwort.TabIndex = 40;
            // 
            // txtbox_email
            // 
            this.txtbox_email.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_email.Location = new System.Drawing.Point(103, 60);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(392, 25);
            this.txtbox_email.TabIndex = 39;
            // 
            // lbl_logindata
            // 
            this.lbl_logindata.AutoSize = true;
            this.lbl_logindata.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logindata.Location = new System.Drawing.Point(19, 16);
            this.lbl_logindata.Name = "lbl_logindata";
            this.lbl_logindata.Size = new System.Drawing.Size(93, 21);
            this.lbl_logindata.TabIndex = 38;
            this.lbl_logindata.Text = "Logindaten";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "Profil";
            // 
            // pixbox_tennisimg
            // 
            this.pixbox_tennisimg.Image = global::Tennisverwaltungssystem.Properties.Resources.tennisball_ist_auf_der_aufschlagvertikale_40803477;
            this.pixbox_tennisimg.Location = new System.Drawing.Point(656, 187);
            this.pixbox_tennisimg.Name = "pixbox_tennisimg";
            this.pixbox_tennisimg.Size = new System.Drawing.Size(220, 336);
            this.pixbox_tennisimg.TabIndex = 0;
            this.pixbox_tennisimg.TabStop = false;
            // 
            // Profil_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pixbox_tennisimg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnl_logindata);
            this.Controls.Add(this.pnl_persondata);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Profil_UserControl";
            this.Size = new System.Drawing.Size(943, 554);
            this.panel1.ResumeLayout(false);
            this.pnl_persondata.ResumeLayout(false);
            this.pnl_persondata.PerformLayout();
            this.pnl_logindata.ResumeLayout(false);
            this.pnl_logindata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixbox_tennisimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_persondata;
        private System.Windows.Forms.Panel pnl_logindata;
        private System.Windows.Forms.Button btn_changedata;
        private System.Windows.Forms.Button btn_cleardata;
        private System.Windows.Forms.TextBox txtbox_telnummer;
        private System.Windows.Forms.TextBox textbox_straße;
        private System.Windows.Forms.TextBox txtbox_nachname;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_persondata;
        private System.Windows.Forms.Label lbl_geschlecht;
        private System.Windows.Forms.Label lbl_straße;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_passwort;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txtBox_passwort;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.Label lbl_logindata;
        private System.Windows.Forms.PictureBox pixbox_tennisimg;
    }
}
