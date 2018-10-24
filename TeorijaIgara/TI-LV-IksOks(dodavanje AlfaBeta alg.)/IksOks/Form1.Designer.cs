namespace IksOks
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tlpGame = new System.Windows.Forms.TableLayoutPanel();
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.pnlGameInfo = new System.Windows.Forms.Panel();
			this.btnX = new System.Windows.Forms.Button();
			this.btnO = new System.Windows.Forms.Button();
			this.lblNaPotezu = new System.Windows.Forms.Label();
			this.lblIgrac = new System.Windows.Forms.Label();
			this.btnNewGame = new System.Windows.Forms.Button();
			this.pnlHeader.SuspendLayout();
			this.pnlGameInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpGame
			// 
			this.tlpGame.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tlpGame.BackColor = System.Drawing.Color.Black;
			this.tlpGame.ColumnCount = 3;
			this.tlpGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpGame.Location = new System.Drawing.Point(92, 80);
			this.tlpGame.Name = "tlpGame";
			this.tlpGame.RowCount = 3;
			this.tlpGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpGame.Size = new System.Drawing.Size(300, 300);
			this.tlpGame.TabIndex = 0;
			// 
			// pnlHeader
			// 
			this.pnlHeader.Controls.Add(this.btnO);
			this.pnlHeader.Controls.Add(this.btnX);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(484, 80);
			this.pnlHeader.TabIndex = 1;
			// 
			// pnlGameInfo
			// 
			this.pnlGameInfo.Controls.Add(this.btnNewGame);
			this.pnlGameInfo.Controls.Add(this.lblIgrac);
			this.pnlGameInfo.Controls.Add(this.lblNaPotezu);
			this.pnlGameInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlGameInfo.Location = new System.Drawing.Point(0, 80);
			this.pnlGameInfo.Name = "pnlGameInfo";
			this.pnlGameInfo.Size = new System.Drawing.Size(484, 80);
			this.pnlGameInfo.TabIndex = 2;
			this.pnlGameInfo.Visible = false;
			// 
			// btnX
			// 
			this.btnX.FlatAppearance.BorderSize = 0;
			this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnX.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnX.ForeColor = System.Drawing.Color.Red;
			this.btnX.Location = new System.Drawing.Point(119, 15);
			this.btnX.Name = "btnX";
			this.btnX.Size = new System.Drawing.Size(50, 50);
			this.btnX.TabIndex = 0;
			this.btnX.Text = "X";
			this.btnX.UseVisualStyleBackColor = true;
			this.btnX.Click += new System.EventHandler(this.NovaIgra);
			// 
			// btnO
			// 
			this.btnO.FlatAppearance.BorderSize = 0;
			this.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnO.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnO.ForeColor = System.Drawing.Color.Blue;
			this.btnO.Location = new System.Drawing.Point(315, 15);
			this.btnO.Name = "btnO";
			this.btnO.Size = new System.Drawing.Size(50, 50);
			this.btnO.TabIndex = 0;
			this.btnO.Text = "O";
			this.btnO.UseVisualStyleBackColor = true;
			this.btnO.Click += new System.EventHandler(this.NovaIgra);
			// 
			// lblNaPotezu
			// 
			this.lblNaPotezu.AutoSize = true;
			this.lblNaPotezu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNaPotezu.Location = new System.Drawing.Point(15, 22);
			this.lblNaPotezu.Name = "lblNaPotezu";
			this.lblNaPotezu.Size = new System.Drawing.Size(285, 37);
			this.lblNaPotezu.TabIndex = 0;
			this.lblNaPotezu.Text = "Na potezu je igrač:";
			// 
			// lblIgrac
			// 
			this.lblIgrac.AutoSize = true;
			this.lblIgrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIgrac.Location = new System.Drawing.Point(306, 22);
			this.lblIgrac.Name = "lblIgrac";
			this.lblIgrac.Size = new System.Drawing.Size(38, 37);
			this.lblIgrac.TabIndex = 1;
			this.lblIgrac.Text = "X";
			// 
			// btnNewGame
			// 
			this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewGame.Location = new System.Drawing.Point(414, 11);
			this.btnNewGame.Name = "btnNewGame";
			this.btnNewGame.Size = new System.Drawing.Size(58, 58);
			this.btnNewGame.TabIndex = 2;
			this.btnNewGame.Text = "Nova igra";
			this.btnNewGame.UseVisualStyleBackColor = true;
			this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.tlpGame);
			this.Controls.Add(this.pnlGameInfo);
			this.Controls.Add(this.pnlHeader);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "IksOks";
			this.pnlHeader.ResumeLayout(false);
			this.pnlGameInfo.ResumeLayout(false);
			this.pnlGameInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpGame;
		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Button btnO;
		private System.Windows.Forms.Button btnX;
		private System.Windows.Forms.Panel pnlGameInfo;
		private System.Windows.Forms.Label lblIgrac;
		private System.Windows.Forms.Label lblNaPotezu;
		private System.Windows.Forms.Button btnNewGame;

	}
}

