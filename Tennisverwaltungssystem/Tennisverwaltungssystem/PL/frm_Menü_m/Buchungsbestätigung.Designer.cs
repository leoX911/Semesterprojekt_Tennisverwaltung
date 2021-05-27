namespace Tennisverwaltungssystem.PL.frm_Menü_m
{
    partial class Buchungsbestätigung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buchungsbestätigung));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Herrxy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_buchungsnummer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.lbl_zeitraum = new System.Windows.Forms.Label();
            this.btn_buchungdrucken = new System.Windows.Forms.Button();
            this.btn_hauptmenü = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tennisverwaltungssystem.Properties.Resources.Bild_7;
            this.pictureBox1.Location = new System.Drawing.Point(427, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 516);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buchungsbestätigung";
            // 
            // Herrxy
            // 
            this.Herrxy.AutoSize = true;
            this.Herrxy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Herrxy.Location = new System.Drawing.Point(49, 123);
            this.Herrxy.Name = "Herrxy";
            this.Herrxy.Size = new System.Drawing.Size(135, 15);
            this.Herrxy.TabIndex = 2;
            this.Herrxy.Text = "Hallo Herr Mustermann!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ihre Buchung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 105);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vielen Dank für Ihre Buchung. Wir wünschen Ihnen viel Spaß\r\nbeim Tennispielen. Za" +
    "hlungsinformationen finden Sie auf\r\n unserer Website oder vor Ort.\r\n\r\nMit freund" +
    "lichen Grüßen,\r\n\r\nTC Hard\r\n";
            // 
            // lbl_buchungsnummer
            // 
            this.lbl_buchungsnummer.AutoSize = true;
            this.lbl_buchungsnummer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buchungsnummer.Location = new System.Drawing.Point(48, 280);
            this.lbl_buchungsnummer.Name = "lbl_buchungsnummer";
            this.lbl_buchungsnummer.Size = new System.Drawing.Size(128, 17);
            this.lbl_buchungsnummer.TabIndex = 5;
            this.lbl_buchungsnummer.Text = "Buchungsnummer: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(52, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 1);
            this.panel1.TabIndex = 6;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(49, 318);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(101, 15);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "Max Mustermann";
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbl_datum.Location = new System.Drawing.Point(49, 347);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(62, 23);
            this.lbl_datum.TabIndex = 8;
            this.lbl_datum.Text = "Datum";
            // 
            // lbl_zeitraum
            // 
            this.lbl_zeitraum.AutoSize = true;
            this.lbl_zeitraum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zeitraum.Location = new System.Drawing.Point(49, 384);
            this.lbl_zeitraum.Name = "lbl_zeitraum";
            this.lbl_zeitraum.Size = new System.Drawing.Size(55, 15);
            this.lbl_zeitraum.TabIndex = 9;
            this.lbl_zeitraum.Text = "Zeitraum";
            // 
            // btn_buchungdrucken
            // 
            this.btn_buchungdrucken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(63)))), ((int)(((byte)(78)))));
            this.btn_buchungdrucken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buchungdrucken.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buchungdrucken.ForeColor = System.Drawing.Color.White;
            this.btn_buchungdrucken.Location = new System.Drawing.Point(52, 419);
            this.btn_buchungdrucken.Name = "btn_buchungdrucken";
            this.btn_buchungdrucken.Size = new System.Drawing.Size(322, 42);
            this.btn_buchungdrucken.TabIndex = 10;
            this.btn_buchungdrucken.Text = "Buchung drucken";
            this.btn_buchungdrucken.UseVisualStyleBackColor = false;
            this.btn_buchungdrucken.Click += new System.EventHandler(this.Btn_buchungdrucken_Click);
            // 
            // btn_hauptmenü
            // 
            this.btn_hauptmenü.BackColor = System.Drawing.Color.LightGray;
            this.btn_hauptmenü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hauptmenü.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hauptmenü.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_hauptmenü.Location = new System.Drawing.Point(52, 470);
            this.btn_hauptmenü.Name = "btn_hauptmenü";
            this.btn_hauptmenü.Size = new System.Drawing.Size(119, 28);
            this.btn_hauptmenü.TabIndex = 11;
            this.btn_hauptmenü.Text = "Hauptmenü";
            this.btn_hauptmenü.UseVisualStyleBackColor = false;
            this.btn_hauptmenü.Click += new System.EventHandler(this.Btn_hauptmenü_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Buchungsbestätigung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 511);
            this.Controls.Add(this.btn_hauptmenü);
            this.Controls.Add(this.btn_buchungdrucken);
            this.Controls.Add(this.lbl_zeitraum);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_buchungsnummer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Herrxy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Buchungsbestätigung";
            this.Text = "Buchungsbestätigung";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Herrxy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_buchungsnummer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.Label lbl_zeitraum;
        private System.Windows.Forms.Button btn_buchungdrucken;
        private System.Windows.Forms.Button btn_hauptmenü;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}