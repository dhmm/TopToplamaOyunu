namespace TopToplamaOyunu.Kutuphane.Grafikler
{
    partial class ControlGrafikler
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
            this.label1 = new System.Windows.Forms.Label();
            this.pctTop = new TopToplamaOyunu.Kutuphane.Grafikler.GelismisPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctTop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gorunmez nesne";
            // 
            // pctTop
            // 
            this.pctTop.Location = new System.Drawing.Point(15, 59);
            this.pctTop.Name = "pctTop";
            this.pctTop.Size = new System.Drawing.Size(20, 20);
            this.pctTop.TabIndex = 1;
            this.pctTop.TabStop = false;
            // 
            // ControlGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pctTop);
            this.Controls.Add(this.label1);
            this.Name = "ControlGrafikler";
            this.Size = new System.Drawing.Size(217, 104);
            this.Load += new System.EventHandler(this.ControlGrafikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private GelismisPictureBox pctTop;
    }
}
