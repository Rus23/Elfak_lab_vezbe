namespace OOP_MineSwiper
{
    partial class FormGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGlavna));
            this.msOpcije = new System.Windows.Forms.MenuStrip();
            this.opcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucitajIzXMLFajlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snimiUXMLFajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblZastavice = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.panelGame = new System.Windows.Forms.Panel();
            this.timerIgre = new System.Windows.Forms.Timer(this.components);
            this.cbxDrugiPrsten = new System.Windows.Forms.CheckBox();
            this.msOpcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // msOpcije
            // 
            this.msOpcije.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.msOpcije.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcijeToolStripMenuItem});
            this.msOpcije.Location = new System.Drawing.Point(0, 0);
            this.msOpcije.Name = "msOpcije";
            this.msOpcije.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msOpcije.Size = new System.Drawing.Size(621, 31);
            this.msOpcije.TabIndex = 0;
            // 
            // opcijeToolStripMenuItem
            // 
            this.opcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfiguracijaToolStripMenuItem,
            this.ucitajIzXMLFajlaToolStripMenuItem,
            this.snimiUXMLFajlToolStripMenuItem});
            this.opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            this.opcijeToolStripMenuItem.Size = new System.Drawing.Size(70, 27);
            this.opcijeToolStripMenuItem.Text = "Opcije";
            // 
            // konfiguracijaToolStripMenuItem
            // 
            this.konfiguracijaToolStripMenuItem.Name = "konfiguracijaToolStripMenuItem";
            this.konfiguracijaToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.konfiguracijaToolStripMenuItem.Text = "Konfiguracija";
            this.konfiguracijaToolStripMenuItem.Click += new System.EventHandler(this.konfiguracijaToolStripMenuItem_Click);
            // 
            // ucitajIzXMLFajlaToolStripMenuItem
            // 
            this.ucitajIzXMLFajlaToolStripMenuItem.Name = "ucitajIzXMLFajlaToolStripMenuItem";
            this.ucitajIzXMLFajlaToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.ucitajIzXMLFajlaToolStripMenuItem.Text = "Proctiaj iz XML-a";
            this.ucitajIzXMLFajlaToolStripMenuItem.Click += new System.EventHandler(this.ucitajIzXMLFajlaToolStripMenuItem_Click);
            // 
            // snimiUXMLFajlToolStripMenuItem
            // 
            this.snimiUXMLFajlToolStripMenuItem.Name = "snimiUXMLFajlToolStripMenuItem";
            this.snimiUXMLFajlToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.snimiUXMLFajlToolStripMenuItem.Text = "Ucitaj u XML";
            this.snimiUXMLFajlToolStripMenuItem.Click += new System.EventHandler(this.snimiUXMLFajlToolStripMenuItem_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(231, 44);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 46);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblZastavice
            // 
            this.lblZastavice.AutoSize = true;
            this.lblZastavice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZastavice.Font = new System.Drawing.Font("Modern No. 20", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZastavice.Location = new System.Drawing.Point(129, 62);
            this.lblZastavice.Name = "lblZastavice";
            this.lblZastavice.Size = new System.Drawing.Size(27, 31);
            this.lblZastavice.TabIndex = 3;
            this.lblZastavice.Text = "0";
            this.lblZastavice.Click += new System.EventHandler(this.lblZastavice_Click);
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVreme.Font = new System.Drawing.Font("Modern No. 20", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.Location = new System.Drawing.Point(432, 58);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(30, 33);
            this.lblVreme.TabIndex = 4;
            this.lblVreme.Text = "0";
            // 
            // panelGame
            // 
            this.panelGame.Location = new System.Drawing.Point(37, 103);
            this.panelGame.Margin = new System.Windows.Forms.Padding(4);
            this.panelGame.MaximumSize = new System.Drawing.Size(533, 492);
            this.panelGame.MinimumSize = new System.Drawing.Size(533, 492);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(533, 492);
            this.panelGame.TabIndex = 5;
            // 
            // timerIgre
            // 
            this.timerIgre.Interval = 1000;
            this.timerIgre.Tick += new System.EventHandler(this.timerIgre_Tick);
            // 
            // cbxDrugiPrsten
            // 
            this.cbxDrugiPrsten.AutoSize = true;
            this.cbxDrugiPrsten.Location = new System.Drawing.Point(13, 35);
            this.cbxDrugiPrsten.Name = "cbxDrugiPrsten";
            this.cbxDrugiPrsten.Size = new System.Drawing.Size(190, 20);
            this.cbxDrugiPrsten.TabIndex = 6;
            this.cbxDrugiPrsten.Text = "Proveri 2 prstena oko polja";
            this.cbxDrugiPrsten.UseVisualStyleBackColor = true;
            this.cbxDrugiPrsten.CheckedChanged += new System.EventHandler(this.cbxDrugiPrsten_CheckedChanged);
            // 
            // FormGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 631);
            this.Controls.Add(this.cbxDrugiPrsten);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.lblZastavice);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.msOpcije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msOpcije;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.msOpcije.ResumeLayout(false);
            this.msOpcije.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msOpcije;
        private System.Windows.Forms.ToolStripMenuItem opcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfiguracijaToolStripMenuItem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblZastavice;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Timer timerIgre;
        private System.Windows.Forms.ToolStripMenuItem ucitajIzXMLFajlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snimiUXMLFajlToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbxDrugiPrsten;
    }
}

