namespace OOP_MineSwiper
{
    partial class FormKonfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVelicina = new System.Windows.Forms.TextBox();
            this.txtBrMina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(147, 196);
            this.btnProsledi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(147, 37);
            this.btnProsledi.TabIndex = 0;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite  velicinu  kvadratne matrice:";
            // 
            // txtVelicina
            // 
            this.txtVelicina.Location = new System.Drawing.Point(263, 69);
            this.txtVelicina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVelicina.Name = "txtVelicina";
            this.txtVelicina.Size = new System.Drawing.Size(29, 22);
            this.txtVelicina.TabIndex = 2;
            // 
            // txtBrMina
            // 
            this.txtBrMina.Location = new System.Drawing.Point(263, 139);
            this.txtBrMina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBrMina.Name = "txtBrMina";
            this.txtBrMina.Size = new System.Drawing.Size(29, 22);
            this.txtBrMina.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unesite broj mina:";
            // 
            // FormKonfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(329, 262);
            this.Controls.Add(this.txtBrMina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVelicina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProsledi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormKonfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Konfiguracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVelicina;
        private System.Windows.Forms.TextBox txtBrMina;
        private System.Windows.Forms.Label label2;
    }
}