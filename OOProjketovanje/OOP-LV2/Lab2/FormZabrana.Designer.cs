namespace Lab2
{
    partial class FormZabrana
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
            this.btn_Zatvori = new System.Windows.Forms.Button();
            this.btn_Prosledi = new System.Windows.Forms.Button();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.cbxZab = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Zatvori
            // 
            this.btn_Zatvori.Location = new System.Drawing.Point(147, 199);
            this.btn_Zatvori.Name = "btn_Zatvori";
            this.btn_Zatvori.Size = new System.Drawing.Size(91, 20);
            this.btn_Zatvori.TabIndex = 15;
            this.btn_Zatvori.Text = "Zatvori";
            this.btn_Zatvori.UseVisualStyleBackColor = true;
            this.btn_Zatvori.Click += new System.EventHandler(this.btn_Zatvori_Click);
            // 
            // btn_Prosledi
            // 
            this.btn_Prosledi.Location = new System.Drawing.Point(50, 197);
            this.btn_Prosledi.Name = "btn_Prosledi";
            this.btn_Prosledi.Size = new System.Drawing.Size(75, 23);
            this.btn_Prosledi.TabIndex = 14;
            this.btn_Prosledi.Text = "Prosledi";
            this.btn_Prosledi.UseVisualStyleBackColor = true;
            this.btn_Prosledi.Click += new System.EventHandler(this.btn_Prosledi_Click);
            // 
            // dtpDO
            // 
            this.dtpDO.CustomFormat = "dd.MM.yyyy.";
            this.dtpDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDO.Location = new System.Drawing.Point(113, 141);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(108, 20);
            this.dtpDO.TabIndex = 13;
            // 
            // dtpOd
            // 
            this.dtpOd.CustomFormat = "dd.MM.yyyy.";
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOd.Location = new System.Drawing.Point(113, 94);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(108, 20);
            this.dtpOd.TabIndex = 12;
            // 
            // cbxZab
            // 
            this.cbxZab.FormattingEnabled = true;
            this.cbxZab.Location = new System.Drawing.Point(110, 41);
            this.cbxZab.Name = "cbxZab";
            this.cbxZab.Size = new System.Drawing.Size(111, 21);
            this.cbxZab.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Datum do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datum od:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kategorija:";
            // 
            // FormZabrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Zatvori);
            this.Controls.Add(this.btn_Prosledi);
            this.Controls.Add(this.dtpDO);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.cbxZab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormZabrana";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zabrana";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormZabrana_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Zatvori;
        private System.Windows.Forms.Button btn_Prosledi;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.ComboBox cbxZab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}