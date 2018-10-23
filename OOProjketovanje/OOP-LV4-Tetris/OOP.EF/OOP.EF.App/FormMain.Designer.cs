namespace OOP.EF.App
{
    partial class FormMain
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.cmbStudenti = new System.Windows.Forms.ComboBox();
            this.dgvIspiti = new System.Windows.Forms.DataGridView();
            this.grpIspiti = new System.Windows.Forms.GroupBox();
            this.grpTelefon = new System.Windows.Forms.GroupBox();
            this.btnObrisiTelefon = new System.Windows.Forms.Button();
            this.btnDodajTelefon = new System.Windows.Forms.Button();
            this.dgvTelefon = new System.Windows.Forms.DataGridView();
            this.btnDodajStudenta = new System.Windows.Forms.Button();
            this.btnObrisiStudenta = new System.Windows.Forms.Button();
            this.btnIspiti = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnIzmeniStudenta = new System.Windows.Forms.Button();
            this.btnDodajIspit = new System.Windows.Forms.Button();
            this.btnObrisiIspit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspiti)).BeginInit();
            this.grpIspiti.SuspendLayout();
            this.grpTelefon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(12, 31);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(47, 13);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student:";
            // 
            // cmbStudenti
            // 
            this.cmbStudenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudenti.FormattingEnabled = true;
            this.cmbStudenti.Location = new System.Drawing.Point(65, 28);
            this.cmbStudenti.Name = "cmbStudenti";
            this.cmbStudenti.Size = new System.Drawing.Size(466, 21);
            this.cmbStudenti.TabIndex = 1;
            this.cmbStudenti.SelectedIndexChanged += new System.EventHandler(this.cmbStudenti_SelectedIndexChanged);
            // 
            // dgvIspiti
            // 
            this.dgvIspiti.AllowUserToAddRows = false;
            this.dgvIspiti.AllowUserToDeleteRows = false;
            this.dgvIspiti.AllowUserToResizeRows = false;
            this.dgvIspiti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvIspiti.BackgroundColor = System.Drawing.Color.White;
            this.dgvIspiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIspiti.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgvIspiti.Location = new System.Drawing.Point(8, 19);
            this.dgvIspiti.Name = "dgvIspiti";
            this.dgvIspiti.RowHeadersVisible = false;
            this.dgvIspiti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIspiti.Size = new System.Drawing.Size(505, 126);
            this.dgvIspiti.TabIndex = 0;
            // 
            // grpIspiti
            // 
            this.grpIspiti.Controls.Add(this.btnObrisiIspit);
            this.grpIspiti.Controls.Add(this.btnDodajIspit);
            this.grpIspiti.Controls.Add(this.dgvIspiti);
            this.grpIspiti.Location = new System.Drawing.Point(15, 241);
            this.grpIspiti.Name = "grpIspiti";
            this.grpIspiti.Size = new System.Drawing.Size(519, 186);
            this.grpIspiti.TabIndex = 3;
            this.grpIspiti.TabStop = false;
            this.grpIspiti.Text = "Ispiti";
            // 
            // grpTelefon
            // 
            this.grpTelefon.Controls.Add(this.btnObrisiTelefon);
            this.grpTelefon.Controls.Add(this.btnDodajTelefon);
            this.grpTelefon.Controls.Add(this.dgvTelefon);
            this.grpTelefon.Location = new System.Drawing.Point(15, 63);
            this.grpTelefon.Name = "grpTelefon";
            this.grpTelefon.Size = new System.Drawing.Size(519, 139);
            this.grpTelefon.TabIndex = 2;
            this.grpTelefon.TabStop = false;
            this.grpTelefon.Text = "Telefon";
            // 
            // btnObrisiTelefon
            // 
            this.btnObrisiTelefon.Location = new System.Drawing.Point(412, 110);
            this.btnObrisiTelefon.Name = "btnObrisiTelefon";
            this.btnObrisiTelefon.Size = new System.Drawing.Size(101, 23);
            this.btnObrisiTelefon.TabIndex = 2;
            this.btnObrisiTelefon.Text = "Obrisi Telefon";
            this.btnObrisiTelefon.UseVisualStyleBackColor = true;
            this.btnObrisiTelefon.Click += new System.EventHandler(this.btnObrisiTelefon_Click);
            // 
            // btnDodajTelefon
            // 
            this.btnDodajTelefon.Location = new System.Drawing.Point(6, 110);
            this.btnDodajTelefon.Name = "btnDodajTelefon";
            this.btnDodajTelefon.Size = new System.Drawing.Size(101, 23);
            this.btnDodajTelefon.TabIndex = 1;
            this.btnDodajTelefon.Text = "Dodaj Telefon";
            this.btnDodajTelefon.UseVisualStyleBackColor = true;
            this.btnDodajTelefon.Click += new System.EventHandler(this.btnDodajTelefon_Click);
            // 
            // dgvTelefon
            // 
            this.dgvTelefon.AllowUserToAddRows = false;
            this.dgvTelefon.AllowUserToDeleteRows = false;
            this.dgvTelefon.AllowUserToResizeRows = false;
            this.dgvTelefon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTelefon.BackgroundColor = System.Drawing.Color.White;
            this.dgvTelefon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefon.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgvTelefon.Location = new System.Drawing.Point(8, 19);
            this.dgvTelefon.Name = "dgvTelefon";
            this.dgvTelefon.RowHeadersVisible = false;
            this.dgvTelefon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefon.Size = new System.Drawing.Size(505, 85);
            this.dgvTelefon.TabIndex = 0;
            // 
            // btnDodajStudenta
            // 
            this.btnDodajStudenta.Location = new System.Drawing.Point(15, 442);
            this.btnDodajStudenta.Name = "btnDodajStudenta";
            this.btnDodajStudenta.Size = new System.Drawing.Size(89, 23);
            this.btnDodajStudenta.TabIndex = 4;
            this.btnDodajStudenta.Text = "Dodaj Studenta";
            this.btnDodajStudenta.UseVisualStyleBackColor = true;
            this.btnDodajStudenta.Click += new System.EventHandler(this.btnDodajStudenta_Click);
            // 
            // btnObrisiStudenta
            // 
            this.btnObrisiStudenta.Location = new System.Drawing.Point(218, 442);
            this.btnObrisiStudenta.Name = "btnObrisiStudenta";
            this.btnObrisiStudenta.Size = new System.Drawing.Size(89, 23);
            this.btnObrisiStudenta.TabIndex = 6;
            this.btnObrisiStudenta.Text = "Obrisi Studenta";
            this.btnObrisiStudenta.UseVisualStyleBackColor = true;
            this.btnObrisiStudenta.Click += new System.EventHandler(this.btnObrisiStudenta_Click);
            // 
            // btnIspiti
            // 
            this.btnIspiti.Location = new System.Drawing.Point(353, 442);
            this.btnIspiti.Name = "btnIspiti";
            this.btnIspiti.Size = new System.Drawing.Size(89, 23);
            this.btnIspiti.TabIndex = 7;
            this.btnIspiti.Text = "Ispiti";
            this.btnIspiti.UseVisualStyleBackColor = true;
            this.btnIspiti.Click += new System.EventHandler(this.btnIspiti_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(448, 442);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(89, 23);
            this.btnZatvori.TabIndex = 8;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnIzmeniStudenta
            // 
            this.btnIzmeniStudenta.Location = new System.Drawing.Point(110, 442);
            this.btnIzmeniStudenta.Name = "btnIzmeniStudenta";
            this.btnIzmeniStudenta.Size = new System.Drawing.Size(102, 23);
            this.btnIzmeniStudenta.TabIndex = 5;
            this.btnIzmeniStudenta.Text = "Izmeni Studenta";
            this.btnIzmeniStudenta.UseVisualStyleBackColor = true;
            this.btnIzmeniStudenta.Click += new System.EventHandler(this.btnIzmeniStudenta_Click);
            // 
            // btnDodajIspit
            // 
            this.btnDodajIspit.Location = new System.Drawing.Point(8, 157);
            this.btnDodajIspit.Name = "btnDodajIspit";
            this.btnDodajIspit.Size = new System.Drawing.Size(101, 23);
            this.btnDodajIspit.TabIndex = 1;
            this.btnDodajIspit.Text = "DodajIspit";
            this.btnDodajIspit.UseVisualStyleBackColor = true;
            this.btnDodajIspit.Click += new System.EventHandler(this.btnDodajIspit_Click);
            // 
            // btnObrisiIspit
            // 
            this.btnObrisiIspit.Location = new System.Drawing.Point(412, 157);
            this.btnObrisiIspit.Name = "btnObrisiIspit";
            this.btnObrisiIspit.Size = new System.Drawing.Size(101, 23);
            this.btnObrisiIspit.TabIndex = 2;
            this.btnObrisiIspit.Text = "Obrisi Ispit";
            this.btnObrisiIspit.UseVisualStyleBackColor = true;
            this.btnObrisiIspit.Click += new System.EventHandler(this.btnObrisiIspit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 477);
            this.Controls.Add(this.btnIzmeniStudenta);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnIspiti);
            this.Controls.Add(this.btnObrisiStudenta);
            this.Controls.Add(this.btnDodajStudenta);
            this.Controls.Add(this.grpTelefon);
            this.Controls.Add(this.cmbStudenti);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.grpIspiti);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(565, 516);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(565, 516);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOP EF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspiti)).EndInit();
            this.grpIspiti.ResumeLayout(false);
            this.grpTelefon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbStudenti;
        private System.Windows.Forms.DataGridView dgvIspiti;
        private System.Windows.Forms.GroupBox grpIspiti;
        private System.Windows.Forms.GroupBox grpTelefon;
        private System.Windows.Forms.DataGridView dgvTelefon;
        private System.Windows.Forms.Button btnDodajStudenta;
        private System.Windows.Forms.Button btnObrisiStudenta;
        private System.Windows.Forms.Button btnIspiti;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnIzmeniStudenta;
        private System.Windows.Forms.Button btnDodajTelefon;
        private System.Windows.Forms.Button btnObrisiTelefon;
        private System.Windows.Forms.Button btnObrisiIspit;
        private System.Windows.Forms.Button btnDodajIspit;
    }
}

