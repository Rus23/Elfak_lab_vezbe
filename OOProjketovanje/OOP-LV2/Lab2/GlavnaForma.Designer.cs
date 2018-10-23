namespace Lab2
{
    partial class GlavnaForma
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.dgvListaVozaca = new System.Windows.Forms.DataGridView();
            this.btnDodajVozaca = new System.Windows.Forms.Button();
            this.btnIzmeniVozaca = new System.Windows.Forms.Button();
            this.btnIzbrisiVozaca = new System.Windows.Forms.Button();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.lblTacnoVreme = new System.Windows.Forms.Label();
            this.cbxBiraj = new System.Windows.Forms.ComboBox();
            this.gboxListaVozaca = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVozaca)).BeginInit();
            this.gboxListaVozaca.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaVozaca
            // 
            this.dgvListaVozaca.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaVozaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVozaca.Location = new System.Drawing.Point(15, 19);
            this.dgvListaVozaca.Name = "dgvListaVozaca";
            this.dgvListaVozaca.Size = new System.Drawing.Size(593, 179);
            this.dgvListaVozaca.TabIndex = 0;
            this.dgvListaVozaca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaVozaca_CellContentClick);
            // 
            // btnDodajVozaca
            // 
            this.btnDodajVozaca.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajVozaca.Image")));
            this.btnDodajVozaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajVozaca.Location = new System.Drawing.Point(38, 206);
            this.btnDodajVozaca.Name = "btnDodajVozaca";
            this.btnDodajVozaca.Size = new System.Drawing.Size(70, 44);
            this.btnDodajVozaca.TabIndex = 1;
            this.btnDodajVozaca.Text = "Dodaj vozaca";
            this.btnDodajVozaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajVozaca.UseVisualStyleBackColor = true;
            this.btnDodajVozaca.Click += new System.EventHandler(this.btnDodajVozaca_Click);
            // 
            // btnIzmeniVozaca
            // 
            this.btnIzmeniVozaca.Image = ((System.Drawing.Image)(resources.GetObject("btnIzmeniVozaca.Image")));
            this.btnIzmeniVozaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzmeniVozaca.Location = new System.Drawing.Point(164, 206);
            this.btnIzmeniVozaca.Name = "btnIzmeniVozaca";
            this.btnIzmeniVozaca.Size = new System.Drawing.Size(71, 44);
            this.btnIzmeniVozaca.TabIndex = 2;
            this.btnIzmeniVozaca.Text = "Izmeni vozaca";
            this.btnIzmeniVozaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIzmeniVozaca.UseVisualStyleBackColor = true;
            this.btnIzmeniVozaca.Click += new System.EventHandler(this.btnIzmeniVozaca_Click);
            // 
            // btnIzbrisiVozaca
            // 
            this.btnIzbrisiVozaca.Image = ((System.Drawing.Image)(resources.GetObject("btnIzbrisiVozaca.Image")));
            this.btnIzbrisiVozaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzbrisiVozaca.Location = new System.Drawing.Point(444, 206);
            this.btnIzbrisiVozaca.Name = "btnIzbrisiVozaca";
            this.btnIzbrisiVozaca.Size = new System.Drawing.Size(107, 38);
            this.btnIzbrisiVozaca.TabIndex = 3;
            this.btnIzbrisiVozaca.Text = "Izbrisi vozaca";
            this.btnIzbrisiVozaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIzbrisiVozaca.UseVisualStyleBackColor = true;
            this.btnIzbrisiVozaca.Click += new System.EventHandler(this.btnIzbrisiVozaca_Click);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(381, 27);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(75, 23);
            this.btnSortiraj.TabIndex = 4;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // lblTacnoVreme
            // 
            this.lblTacnoVreme.AutoSize = true;
            this.lblTacnoVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacnoVreme.Location = new System.Drawing.Point(35, 23);
            this.lblTacnoVreme.Name = "lblTacnoVreme";
            this.lblTacnoVreme.Size = new System.Drawing.Size(238, 25);
            this.lblTacnoVreme.TabIndex = 5;
            this.lblTacnoVreme.Text = "HH:mm:ss dd.MM.yyyy.";
            // 
            // cbxBiraj
            // 
            this.cbxBiraj.FormattingEnabled = true;
            this.cbxBiraj.Location = new System.Drawing.Point(489, 29);
            this.cbxBiraj.Name = "cbxBiraj";
            this.cbxBiraj.Size = new System.Drawing.Size(121, 21);
            this.cbxBiraj.TabIndex = 6;
            this.cbxBiraj.SelectedIndexChanged += new System.EventHandler(this.cbxBiraj_SelectedIndexChanged);
            // 
            // gboxListaVozaca
            // 
            this.gboxListaVozaca.Controls.Add(this.dgvListaVozaca);
            this.gboxListaVozaca.Controls.Add(this.btnIzmeniVozaca);
            this.gboxListaVozaca.Controls.Add(this.btnDodajVozaca);
            this.gboxListaVozaca.Controls.Add(this.btnIzbrisiVozaca);
            this.gboxListaVozaca.Location = new System.Drawing.Point(2, 56);
            this.gboxListaVozaca.Name = "gboxListaVozaca";
            this.gboxListaVozaca.Size = new System.Drawing.Size(646, 250);
            this.gboxListaVozaca.TabIndex = 7;
            this.gboxListaVozaca.TabStop = false;
            this.gboxListaVozaca.Text = "Lista vozaca";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 338);
            this.Controls.Add(this.gboxListaVozaca);
            this.Controls.Add(this.cbxBiraj);
            this.Controls.Add(this.lblTacnoVreme);
            this.Controls.Add(this.btnSortiraj);
            this.Name = "GlavnaForma";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista vozaca";
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVozaca)).EndInit();
            this.gboxListaVozaca.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaVozaca;
        private System.Windows.Forms.Button btnDodajVozaca;
        private System.Windows.Forms.Button btnIzmeniVozaca;
        private System.Windows.Forms.Button btnIzbrisiVozaca;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Label lblTacnoVreme;
        private System.Windows.Forms.ComboBox cbxBiraj;
        private System.Windows.Forms.GroupBox gboxListaVozaca;
        private System.Windows.Forms.Timer timer1;
    }
}

