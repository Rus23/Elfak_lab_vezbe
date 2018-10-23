namespace OOP_Tetris2
{
    partial class Tetris
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTetris = new System.Windows.Forms.Panel();
            this.panelLogicki = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelTetris
            // 
            this.panelTetris.Location = new System.Drawing.Point(4, 4);
            this.panelTetris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTetris.Name = "panelTetris";
            this.panelTetris.Size = new System.Drawing.Size(381, 441);
            this.panelTetris.TabIndex = 0;
            // 
            // panelLogicki
            // 
            this.panelLogicki.Location = new System.Drawing.Point(405, 4);
            this.panelLogicki.Name = "panelLogicki";
            this.panelLogicki.Size = new System.Drawing.Size(329, 441);
            this.panelLogicki.TabIndex = 1;
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLogicki);
            this.Controls.Add(this.panelTetris);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tetris";
            this.Size = new System.Drawing.Size(753, 461);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTetris;
        private System.Windows.Forms.Panel panelLogicki;
    }
}
