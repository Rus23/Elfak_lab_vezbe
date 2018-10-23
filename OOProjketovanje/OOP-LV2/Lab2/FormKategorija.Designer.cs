namespace Lab2
{
    partial class FormKategorija
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxKategorija = new System.Windows.Forms.ComboBox();
            this.dtpDatumOD = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDO = new System.Windows.Forms.DateTimePicker();
            this.btn_Prosledi = new System.Windows.Forms.Button();
            this.btn_Zatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum do:";
            // 
            // cbxKategorija
            // 
            this.cbxKategorija.FormattingEnabled = true;
            this.cbxKategorija.Items.AddRange(new object[] {
            "AM",
            "A1",
            "A2",
            "A",
            "B1",
            "B",
            "BE",
            "C1",
            "C1E",
            "C",
            "CE",
            "D1",
            "D1E",
            "D",
            "DE",
            "F",
            "M"});
            this.cbxKategorija.Location = new System.Drawing.Point(94, 44);
            this.cbxKategorija.Name = "cbxKategorija";
            this.cbxKategorija.Size = new System.Drawing.Size(111, 21);
            this.cbxKategorija.TabIndex = 3;
            // 
            // dtpDatumOD
            // 
            this.dtpDatumOD.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumOD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumOD.Location = new System.Drawing.Point(97, 97);
            this.dtpDatumOD.Name = "dtpDatumOD";
            this.dtpDatumOD.Size = new System.Drawing.Size(108, 20);
            this.dtpDatumOD.TabIndex = 4;
            // 
            // dtpDatumDO
            // 
            this.dtpDatumDO.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumDO.Location = new System.Drawing.Point(97, 144);
            this.dtpDatumDO.Name = "dtpDatumDO";
            this.dtpDatumDO.Size = new System.Drawing.Size(108, 20);
            this.dtpDatumDO.TabIndex = 5;
            // 
            // btn_Prosledi
            // 
            this.btn_Prosledi.Location = new System.Drawing.Point(34, 200);
            this.btn_Prosledi.Name = "btn_Prosledi";
            this.btn_Prosledi.Size = new System.Drawing.Size(75, 23);
            this.btn_Prosledi.TabIndex = 6;
            this.btn_Prosledi.Text = "Prosledi";
            this.btn_Prosledi.UseVisualStyleBackColor = true;
            this.btn_Prosledi.Click += new System.EventHandler(this.btn_Prosledi_Click);
            // 
            // btn_Zatvori
            // 
            this.btn_Zatvori.Location = new System.Drawing.Point(131, 202);
            this.btn_Zatvori.Name = "btn_Zatvori";
            this.btn_Zatvori.Size = new System.Drawing.Size(91, 20);
            this.btn_Zatvori.TabIndex = 7;
            this.btn_Zatvori.Text = "Zatvori";
            this.btn_Zatvori.UseVisualStyleBackColor = true;
            this.btn_Zatvori.Click += new System.EventHandler(this.btn_Zatvori_Click);
            // 
            // FormKategorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Zatvori);
            this.Controls.Add(this.btn_Prosledi);
            this.Controls.Add(this.dtpDatumDO);
            this.Controls.Add(this.dtpDatumOD);
            this.Controls.Add(this.cbxKategorija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKategorija";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategorija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKategorija_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxKategorija;
        private System.Windows.Forms.DateTimePicker dtpDatumOD;
        private System.Windows.Forms.DateTimePicker dtpDatumDO;
        private System.Windows.Forms.Button btn_Prosledi;
        private System.Windows.Forms.Button btn_Zatvori;
    }
}