namespace OOP.EF.App
{
    partial class FormDodajIspit
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
            this.lblIspit = new System.Windows.Forms.Label();
            this.cmbIspit = new System.Windows.Forms.ComboBox();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIspit
            // 
            this.lblIspit.AutoSize = true;
            this.lblIspit.Location = new System.Drawing.Point(21, 22);
            this.lblIspit.Name = "lblIspit";
            this.lblIspit.Size = new System.Drawing.Size(29, 13);
            this.lblIspit.TabIndex = 0;
            this.lblIspit.Text = "Ispit:";
            // 
            // cmbIspit
            // 
            this.cmbIspit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIspit.FormattingEnabled = true;
            this.cmbIspit.Location = new System.Drawing.Point(53, 19);
            this.cmbIspit.Name = "cmbIspit";
            this.cmbIspit.Size = new System.Drawing.Size(336, 21);
            this.cmbIspit.TabIndex = 1;
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(87, 71);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(75, 23);
            this.btnProsledi.TabIndex = 2;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(255, 71);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 3;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // FormDodajIspit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 111);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.cmbIspit);
            this.Controls.Add(this.lblIspit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(435, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(435, 150);
            this.Name = "FormDodajIspit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj ispit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIspit;
        private System.Windows.Forms.ComboBox cmbIspit;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
    }
}