namespace OOP.EF.App
{
    partial class FormStudent
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIndeks = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIndeks = new System.Windows.Forms.TextBox();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(60, 35);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(40, 61);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIndeks
            // 
            this.lblIndeks.AutoSize = true;
            this.lblIndeks.Location = new System.Drawing.Point(45, 87);
            this.lblIndeks.Name = "lblIndeks";
            this.lblIndeks.Size = new System.Drawing.Size(42, 13);
            this.lblIndeks.TabIndex = 4;
            this.lblIndeks.Text = "Indeks:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(111, 32);
            this.txtIme.MaxLength = 20;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(141, 20);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(111, 58);
            this.txtPrezime.MaxLength = 20;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(141, 20);
            this.txtPrezime.TabIndex = 3;
            // 
            // txtIndeks
            // 
            this.txtIndeks.Location = new System.Drawing.Point(111, 84);
            this.txtIndeks.MaxLength = 6;
            this.txtIndeks.Name = "txtIndeks";
            this.txtIndeks.Size = new System.Drawing.Size(141, 20);
            this.txtIndeks.TabIndex = 5;
            this.txtIndeks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIndeks_KeyPress);
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(63, 133);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(75, 23);
            this.btnProsledi.TabIndex = 6;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(177, 133);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 174);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.txtIndeks);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIndeks);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 213);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 213);
            this.Name = "FormStudent";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIndeks;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIndeks;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
    }
}