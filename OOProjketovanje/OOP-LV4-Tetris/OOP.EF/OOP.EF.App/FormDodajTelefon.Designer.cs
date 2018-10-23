namespace OOP.EF.App
{
    partial class FormDodajTelefon
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
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(27, 52);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(75, 23);
            this.btnProsledi.TabIndex = 2;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(188, 52);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPonisti.TabIndex = 3;
            this.btnPonisti.Text = "Zatvori";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(24, 17);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 0;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(76, 14);
            this.txtTelefon.MaxLength = 15;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(187, 20);
            this.txtTelefon.TabIndex = 1;
            // 
            // FormDodajTelefon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 99);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnProsledi);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 138);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 138);
            this.Name = "FormDodajTelefon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Telefon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
    }
}