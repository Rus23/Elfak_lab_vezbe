namespace OOP.EF.App
{
    partial class FormIspit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnObrisiIspit = new System.Windows.Forms.Button();
            this.btnDodajIspit = new System.Windows.Forms.Button();
            this.dgvIspiti = new System.Windows.Forms.DataGridView();
            this.lblSifra = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspiti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiIspit
            // 
            this.btnObrisiIspit.Location = new System.Drawing.Point(12, 145);
            this.btnObrisiIspit.Name = "btnObrisiIspit";
            this.btnObrisiIspit.Size = new System.Drawing.Size(74, 23);
            this.btnObrisiIspit.TabIndex = 5;
            this.btnObrisiIspit.Text = "Obrisi Ispit";
            this.btnObrisiIspit.UseVisualStyleBackColor = true;
            this.btnObrisiIspit.Click += new System.EventHandler(this.btnObrisiIspit_Click);
            // 
            // btnDodajIspit
            // 
            this.btnDodajIspit.Location = new System.Drawing.Point(224, 101);
            this.btnDodajIspit.Name = "btnDodajIspit";
            this.btnDodajIspit.Size = new System.Drawing.Size(101, 23);
            this.btnDodajIspit.TabIndex = 4;
            this.btnDodajIspit.Text = "DodajIspit";
            this.btnDodajIspit.UseVisualStyleBackColor = true;
            this.btnDodajIspit.Click += new System.EventHandler(this.btnDodajIspit_Click);
            // 
            // dgvIspiti
            // 
            this.dgvIspiti.AllowUserToAddRows = false;
            this.dgvIspiti.AllowUserToDeleteRows = false;
            this.dgvIspiti.AllowUserToResizeColumns = false;
            this.dgvIspiti.AllowUserToResizeRows = false;
            this.dgvIspiti.BackgroundColor = System.Drawing.Color.White;
            this.dgvIspiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIspiti.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIspiti.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgvIspiti.Location = new System.Drawing.Point(12, 174);
            this.dgvIspiti.Name = "dgvIspiti";
            this.dgvIspiti.RowHeadersVisible = false;
            this.dgvIspiti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIspiti.Size = new System.Drawing.Size(515, 136);
            this.dgvIspiti.TabIndex = 3;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(36, 13);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(31, 13);
            this.lblSifra.TabIndex = 6;
            this.lblSifra.Text = "Šifra:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(30, 43);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 7;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(73, 10);
            this.txtSifra.MaxLength = 10;
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(454, 20);
            this.txtSifra.TabIndex = 8;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(73, 36);
            this.txtNaziv.MaxLength = 150;
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(454, 59);
            this.txtNaziv.TabIndex = 9;
            // 
            // FormIspit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 314);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.btnObrisiIspit);
            this.Controls.Add(this.btnDodajIspit);
            this.Controls.Add(this.dgvIspiti);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(555, 353);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(555, 353);
            this.Name = "FormIspit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ispiti";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspiti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiIspit;
        private System.Windows.Forms.Button btnDodajIspit;
        private System.Windows.Forms.DataGridView dgvIspiti;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
    }
}