namespace OOP_Tetris2
{
    partial class FormRezultati
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
            this.lbxRezultati = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxRezultati
            // 
            this.lbxRezultati.FormattingEnabled = true;
            this.lbxRezultati.Location = new System.Drawing.Point(17, 15);
            this.lbxRezultati.Name = "lbxRezultati";
            this.lbxRezultati.Size = new System.Drawing.Size(244, 225);
            this.lbxRezultati.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(91, 247);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormRezultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 281);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbxRezultati);
            this.Name = "FormRezultati";
            this.ShowIcon = false;
            this.Text = "Rezultati";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxRezultati;
        private System.Windows.Forms.Button btnOK;
    }
}