namespace OOP_Tetris2
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
            this.gbxKontrole = new System.Windows.Forms.GroupBox();
            this.lblNevidljiva = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxBrzina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxVrste = new System.Windows.Forms.TextBox();
            this.txtbxKolone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerTetris = new System.Windows.Forms.Timer(this.components);
            this.timerVreme = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokreniNovuIgruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacuvajTrenutniSkorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacuvajTrenutniSkorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziListuSaOsvojenimPoenimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacuvajListuUXMLFajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxKontrole.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxKontrole
            // 
            this.gbxKontrole.Controls.Add(this.lblNevidljiva);
            this.gbxKontrole.Controls.Add(this.btnStart);
            this.gbxKontrole.Controls.Add(this.label8);
            this.gbxKontrole.Controls.Add(this.lblPoeni);
            this.gbxKontrole.Controls.Add(this.label7);
            this.gbxKontrole.Controls.Add(this.lblVreme);
            this.gbxKontrole.Controls.Add(this.label6);
            this.gbxKontrole.Controls.Add(this.btnSave);
            this.gbxKontrole.Controls.Add(this.btnPause);
            this.gbxKontrole.Controls.Add(this.txtPrezime);
            this.gbxKontrole.Controls.Add(this.txtIme);
            this.gbxKontrole.Controls.Add(this.label5);
            this.gbxKontrole.Controls.Add(this.label4);
            this.gbxKontrole.Controls.Add(this.txtbxBrzina);
            this.gbxKontrole.Controls.Add(this.label3);
            this.gbxKontrole.Controls.Add(this.txtbxVrste);
            this.gbxKontrole.Controls.Add(this.txtbxKolone);
            this.gbxKontrole.Controls.Add(this.label2);
            this.gbxKontrole.Controls.Add(this.label1);
            this.gbxKontrole.Location = new System.Drawing.Point(12, 27);
            this.gbxKontrole.Name = "gbxKontrole";
            this.gbxKontrole.Size = new System.Drawing.Size(279, 404);
            this.gbxKontrole.TabIndex = 19;
            this.gbxKontrole.TabStop = false;
            // 
            // lblNevidljiva
            // 
            this.lblNevidljiva.AutoSize = true;
            this.lblNevidljiva.Location = new System.Drawing.Point(6, 483);
            this.lblNevidljiva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNevidljiva.Name = "lblNevidljiva";
            this.lblNevidljiva.Size = new System.Drawing.Size(0, 13);
            this.lblNevidljiva.TabIndex = 37;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(32, 237);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(74, 33);
            this.btnStart.TabIndex = 29;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnStart_KeyDown);
            this.btnStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnStart_KeyPress);
            this.btnStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnStart_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 24);
            this.label8.TabIndex = 36;
            this.label8.Text = "Sledeca figura:";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoeni.Location = new System.Drawing.Point(170, 331);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(21, 24);
            this.lblPoeni.TabIndex = 35;
            this.lblPoeni.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Osvojeni poeni:";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.Location = new System.Drawing.Point(177, 293);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(21, 24);
            this.lblVreme.TabIndex = 33;
            this.lblVreme.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Proteklo vreme:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(198, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 33);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(113, 237);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(78, 33);
            this.btnPause.TabIndex = 30;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(123, 189);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(119, 20);
            this.txtPrezime.TabIndex = 28;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(123, 146);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(119, 20);
            this.txtIme.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Prezime igraca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ime igraca:";
            // 
            // txtbxBrzina
            // 
            this.txtbxBrzina.Location = new System.Drawing.Point(123, 90);
            this.txtbxBrzina.Name = "txtbxBrzina";
            this.txtbxBrzina.Size = new System.Drawing.Size(119, 20);
            this.txtbxBrzina.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Brzina kretanja:";
            // 
            // txtbxVrste
            // 
            this.txtbxVrste.Location = new System.Drawing.Point(123, 56);
            this.txtbxVrste.Name = "txtbxVrste";
            this.txtbxVrste.Size = new System.Drawing.Size(119, 20);
            this.txtbxVrste.TabIndex = 22;
            // 
            // txtbxKolone
            // 
            this.txtbxKolone.Location = new System.Drawing.Point(123, 24);
            this.txtbxKolone.Name = "txtbxKolone";
            this.txtbxKolone.Size = new System.Drawing.Size(119, 20);
            this.txtbxKolone.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Broj vrsta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Broj kolona:";
            // 
            // timerTetris
            // 
            this.timerTetris.Interval = 1000;
            this.timerTetris.Tick += new System.EventHandler(this.timerTetris_Tick);
            // 
            // timerVreme
            // 
            this.timerVreme.Interval = 1000;
            this.timerVreme.Tick += new System.EventHandler(this.timerVreme_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokreniNovuIgruToolStripMenuItem,
            this.sacuvajTrenutniSkorToolStripMenuItem,
            this.sacuvajTrenutniSkorToolStripMenuItem1,
            this.prikaziListuSaOsvojenimPoenimaToolStripMenuItem,
            this.sacuvajListuUXMLFajlToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // pokreniNovuIgruToolStripMenuItem
            // 
            this.pokreniNovuIgruToolStripMenuItem.Name = "pokreniNovuIgruToolStripMenuItem";
            this.pokreniNovuIgruToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.pokreniNovuIgruToolStripMenuItem.Text = "Pokreni novu igru";
            this.pokreniNovuIgruToolStripMenuItem.Click += new System.EventHandler(this.pokreniNovuIgruToolStripMenuItem_Click);
            // 
            // sacuvajTrenutniSkorToolStripMenuItem
            // 
            this.sacuvajTrenutniSkorToolStripMenuItem.Name = "sacuvajTrenutniSkorToolStripMenuItem";
            this.sacuvajTrenutniSkorToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.sacuvajTrenutniSkorToolStripMenuItem.Text = "Pauziraj";
            this.sacuvajTrenutniSkorToolStripMenuItem.Click += new System.EventHandler(this.SacuvajTrenutniSkorToolStripMenuItem_Click);
            // 
            // sacuvajTrenutniSkorToolStripMenuItem1
            // 
            this.sacuvajTrenutniSkorToolStripMenuItem1.Name = "sacuvajTrenutniSkorToolStripMenuItem1";
            this.sacuvajTrenutniSkorToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
            this.sacuvajTrenutniSkorToolStripMenuItem1.Text = "Sacuvaj trenutni skor";
            this.sacuvajTrenutniSkorToolStripMenuItem1.Click += new System.EventHandler(this.sacuvajTrenutniSkorToolStripMenuItem1_Click);
            // 
            // prikaziListuSaOsvojenimPoenimaToolStripMenuItem
            // 
            this.prikaziListuSaOsvojenimPoenimaToolStripMenuItem.Name = "prikaziListuSaOsvojenimPoenimaToolStripMenuItem";
            this.prikaziListuSaOsvojenimPoenimaToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.prikaziListuSaOsvojenimPoenimaToolStripMenuItem.Text = "Prikazi listu sa osvojenim poenima";
            this.prikaziListuSaOsvojenimPoenimaToolStripMenuItem.Click += new System.EventHandler(this.prikaziListuSaOsvojenimPoenimaToolStripMenuItem_Click);
            // 
            // sacuvajListuUXMLFajlToolStripMenuItem
            // 
            this.sacuvajListuUXMLFajlToolStripMenuItem.Name = "sacuvajListuUXMLFajlToolStripMenuItem";
            this.sacuvajListuUXMLFajlToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.sacuvajListuUXMLFajlToolStripMenuItem.Text = "Sacuvaj listu u XML fajl";
            this.sacuvajListuUXMLFajlToolStripMenuItem.Click += new System.EventHandler(this.sacuvajListuUXMLFajlToolStripMenuItem_Click);
            // 
            // FormGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 526);
            this.Controls.Add(this.gbxKontrole);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGlavna";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.FormGlavna_Load);
            this.gbxKontrole.ResumeLayout(false);
            this.gbxKontrole.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tetris tetris1;
        private System.Windows.Forms.GroupBox gbxKontrole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxBrzina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxVrste;
        private System.Windows.Forms.TextBox txtbxKolone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerTetris;
        private System.Windows.Forms.Label lblNevidljiva;
        private System.Windows.Forms.Timer timerVreme;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokreniNovuIgruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacuvajTrenutniSkorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacuvajTrenutniSkorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prikaziListuSaOsvojenimPoenimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacuvajListuUXMLFajlToolStripMenuItem;
    }
}

