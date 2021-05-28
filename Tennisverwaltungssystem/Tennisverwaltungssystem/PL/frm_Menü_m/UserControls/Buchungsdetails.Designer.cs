namespace Tennisverwaltungssystem.PL.frm_Menü_m.UserControls
{
    partial class Buchungsdetails
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
            this.lbl_Vorname = new System.Windows.Forms.Label();
            this.tbx_Nachname = new System.Windows.Forms.TextBox();
            this.tbx_Adresse = new System.Windows.Forms.TextBox();
            this.lbl_Adresse = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_storno = new System.Windows.Forms.Button();
            this.tbx_Vorname = new System.Windows.Forms.TextBox();
            this.lbl_Nachname = new System.Windows.Forms.Label();
            this.lbl_Buchungsnummer = new System.Windows.Forms.Label();
            this.lbl_actualBuchungsnummer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Zeitraum = new System.Windows.Forms.Label();
            this.lbl_Platznummer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbx_Tellnummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_zeitttt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Vorname
            // 
            this.lbl_Vorname.AutoSize = true;
            this.lbl_Vorname.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vorname.Location = new System.Drawing.Point(14, 89);
            this.lbl_Vorname.Name = "lbl_Vorname";
            this.lbl_Vorname.Size = new System.Drawing.Size(55, 15);
            this.lbl_Vorname.TabIndex = 13;
            this.lbl_Vorname.Text = "Vorname";
            // 
            // tbx_Nachname
            // 
            this.tbx_Nachname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Nachname.Location = new System.Drawing.Point(189, 107);
            this.tbx_Nachname.Multiline = true;
            this.tbx_Nachname.Name = "tbx_Nachname";
            this.tbx_Nachname.ReadOnly = true;
            this.tbx_Nachname.Size = new System.Drawing.Size(155, 27);
            this.tbx_Nachname.TabIndex = 14;
            // 
            // tbx_Adresse
            // 
            this.tbx_Adresse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Adresse.Location = new System.Drawing.Point(17, 165);
            this.tbx_Adresse.Multiline = true;
            this.tbx_Adresse.Name = "tbx_Adresse";
            this.tbx_Adresse.ReadOnly = true;
            this.tbx_Adresse.Size = new System.Drawing.Size(327, 27);
            this.tbx_Adresse.TabIndex = 15;
            // 
            // lbl_Adresse
            // 
            this.lbl_Adresse.AutoSize = true;
            this.lbl_Adresse.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adresse.Location = new System.Drawing.Point(14, 147);
            this.lbl_Adresse.Name = "lbl_Adresse";
            this.lbl_Adresse.Size = new System.Drawing.Size(48, 15);
            this.lbl_Adresse.TabIndex = 16;
            this.lbl_Adresse.Text = "Adresse";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(14, 203);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(41, 15);
            this.lbl_Email.TabIndex = 18;
            this.lbl_Email.Text = "E-Mail";
            // 
            // tbx_Email
            // 
            this.tbx_Email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Email.Location = new System.Drawing.Point(17, 220);
            this.tbx_Email.Multiline = true;
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.ReadOnly = true;
            this.tbx_Email.Size = new System.Drawing.Size(327, 27);
            this.tbx_Email.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Zurück";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_storno
            // 
            this.btn_storno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_storno.Location = new System.Drawing.Point(468, 344);
            this.btn_storno.Name = "btn_storno";
            this.btn_storno.Size = new System.Drawing.Size(75, 23);
            this.btn_storno.TabIndex = 20;
            this.btn_storno.Text = "Stornieren";
            this.btn_storno.UseVisualStyleBackColor = true;
            // 
            // tbx_Vorname
            // 
            this.tbx_Vorname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Vorname.Location = new System.Drawing.Point(17, 107);
            this.tbx_Vorname.Multiline = true;
            this.tbx_Vorname.Name = "tbx_Vorname";
            this.tbx_Vorname.ReadOnly = true;
            this.tbx_Vorname.Size = new System.Drawing.Size(159, 27);
            this.tbx_Vorname.TabIndex = 21;
            // 
            // lbl_Nachname
            // 
            this.lbl_Nachname.AutoSize = true;
            this.lbl_Nachname.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nachname.Location = new System.Drawing.Point(186, 89);
            this.lbl_Nachname.Name = "lbl_Nachname";
            this.lbl_Nachname.Size = new System.Drawing.Size(65, 15);
            this.lbl_Nachname.TabIndex = 22;
            this.lbl_Nachname.Text = "Nachname";
            // 
            // lbl_Buchungsnummer
            // 
            this.lbl_Buchungsnummer.AutoSize = true;
            this.lbl_Buchungsnummer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buchungsnummer.Location = new System.Drawing.Point(14, 21);
            this.lbl_Buchungsnummer.Name = "lbl_Buchungsnummer";
            this.lbl_Buchungsnummer.Size = new System.Drawing.Size(106, 15);
            this.lbl_Buchungsnummer.TabIndex = 23;
            this.lbl_Buchungsnummer.Text = "Buchungsnummer";
            // 
            // lbl_actualBuchungsnummer
            // 
            this.lbl_actualBuchungsnummer.AutoSize = true;
            this.lbl_actualBuchungsnummer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actualBuchungsnummer.Location = new System.Drawing.Point(14, 46);
            this.lbl_actualBuchungsnummer.Name = "lbl_actualBuchungsnummer";
            this.lbl_actualBuchungsnummer.Size = new System.Drawing.Size(37, 15);
            this.lbl_actualBuchungsnummer.TabIndex = 24;
            this.lbl_actualBuchungsnummer.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(17, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 1);
            this.panel1.TabIndex = 25;
            // 
            // lbl_Zeitraum
            // 
            this.lbl_Zeitraum.AutoSize = true;
            this.lbl_Zeitraum.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Zeitraum.Location = new System.Drawing.Point(367, 54);
            this.lbl_Zeitraum.Name = "lbl_Zeitraum";
            this.lbl_Zeitraum.Size = new System.Drawing.Size(107, 25);
            this.lbl_Zeitraum.TabIndex = 27;
            this.lbl_Zeitraum.Text = "24.03.2021";
            // 
            // lbl_Platznummer
            // 
            this.lbl_Platznummer.AutoSize = true;
            this.lbl_Platznummer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Platznummer.Location = new System.Drawing.Point(369, 81);
            this.lbl_Platznummer.Name = "lbl_Platznummer";
            this.lbl_Platznummer.Size = new System.Drawing.Size(95, 15);
            this.lbl_Platznummer.TabIndex = 28;
            this.lbl_Platznummer.Text = "Platznummer:  9";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tennisverwaltungssystem.Properties.Resources.arnold;
            this.pictureBox1.Location = new System.Drawing.Point(372, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbx_Tellnummer
            // 
            this.tbx_Tellnummer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Tellnummer.Location = new System.Drawing.Point(17, 278);
            this.tbx_Tellnummer.Multiline = true;
            this.tbx_Tellnummer.Name = "tbx_Tellnummer";
            this.tbx_Tellnummer.ReadOnly = true;
            this.tbx_Tellnummer.Size = new System.Drawing.Size(327, 27);
            this.tbx_Tellnummer.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Telefonnummer";
            // 
            // lbl_zeitttt
            // 
            this.lbl_zeitttt.AutoSize = true;
            this.lbl_zeitttt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zeitttt.Location = new System.Drawing.Point(473, 54);
            this.lbl_zeitttt.Name = "lbl_zeitttt";
            this.lbl_zeitttt.Size = new System.Drawing.Size(107, 25);
            this.lbl_zeitttt.TabIndex = 31;
            this.lbl_zeitttt.Text = "24.03.2021";
            // 
            // Buchungsdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_zeitttt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_Tellnummer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Platznummer);
            this.Controls.Add(this.lbl_Zeitraum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_actualBuchungsnummer);
            this.Controls.Add(this.lbl_Buchungsnummer);
            this.Controls.Add(this.lbl_Nachname);
            this.Controls.Add(this.tbx_Vorname);
            this.Controls.Add(this.btn_storno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.tbx_Email);
            this.Controls.Add(this.lbl_Adresse);
            this.Controls.Add(this.tbx_Adresse);
            this.Controls.Add(this.tbx_Nachname);
            this.Controls.Add(this.lbl_Vorname);
            this.Name = "Buchungsdetails";
            this.Size = new System.Drawing.Size(583, 385);
            this.Load += new System.EventHandler(this.Buchungsdetails_Load);
            this.VisibleChanged += new System.EventHandler(this.Buchungsdetails_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Vorname;
        private System.Windows.Forms.TextBox tbx_Nachname;
        private System.Windows.Forms.TextBox tbx_Adresse;
        private System.Windows.Forms.Label lbl_Adresse;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_storno;
        private System.Windows.Forms.TextBox tbx_Vorname;
        private System.Windows.Forms.Label lbl_Nachname;
        private System.Windows.Forms.Label lbl_Buchungsnummer;
        private System.Windows.Forms.Label lbl_actualBuchungsnummer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Zeitraum;
        private System.Windows.Forms.Label lbl_Platznummer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbx_Tellnummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_zeitttt;
    }
}
