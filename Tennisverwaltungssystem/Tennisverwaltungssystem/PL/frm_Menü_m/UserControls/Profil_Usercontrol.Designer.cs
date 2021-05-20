namespace Tennisverwaltungssystem.PL.frm_Menü_m.UserControls
{
    partial class Profil_Usercontrol
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.txtbox_nachname = new System.Windows.Forms.TextBox();
            this.textbox_straße = new System.Windows.Forms.TextBox();
            this.txtbox_tell = new System.Windows.Forms.TextBox();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtbox_tell);
            this.panel1.Controls.Add(this.textbox_straße);
            this.panel1.Controls.Add(this.txtbox_nachname);
            this.panel1.Controls.Add(this.txtbox_name);
            this.panel1.Location = new System.Drawing.Point(58, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 243);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtbox_password);
            this.panel2.Controls.Add(this.txtbox_email);
            this.panel2.Location = new System.Drawing.Point(58, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 194);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(662, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 463);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tennisverwaltungssystem.Properties.Resources.tennisball_ist_auf_der_aufschlagvertikale_408034771;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 463);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(145, 56);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(326, 20);
            this.txtbox_name.TabIndex = 0;
            // 
            // txtbox_nachname
            // 
            this.txtbox_nachname.Location = new System.Drawing.Point(145, 97);
            this.txtbox_nachname.Name = "txtbox_nachname";
            this.txtbox_nachname.Size = new System.Drawing.Size(326, 20);
            this.txtbox_nachname.TabIndex = 1;
            // 
            // textbox_straße
            // 
            this.textbox_straße.Location = new System.Drawing.Point(145, 139);
            this.textbox_straße.Name = "textbox_straße";
            this.textbox_straße.Size = new System.Drawing.Size(326, 20);
            this.textbox_straße.TabIndex = 2;
            // 
            // txtbox_tell
            // 
            this.txtbox_tell.Location = new System.Drawing.Point(145, 185);
            this.txtbox_tell.Name = "txtbox_tell";
            this.txtbox_tell.Size = new System.Drawing.Size(326, 20);
            this.txtbox_tell.TabIndex = 3;
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(124, 65);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(326, 20);
            this.txtbox_email.TabIndex = 4;
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(124, 114);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(326, 20);
            this.txtbox_password.TabIndex = 5;
            // 
            // Profil_Usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Profil_Usercontrol";
            this.Size = new System.Drawing.Size(943, 554);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbox_tell;
        private System.Windows.Forms.TextBox textbox_straße;
        private System.Windows.Forms.TextBox txtbox_nachname;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.TextBox txtbox_email;
    }
}
