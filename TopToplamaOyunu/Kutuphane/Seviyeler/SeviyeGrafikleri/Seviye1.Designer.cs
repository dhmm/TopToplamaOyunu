namespace TopToplamaOyunu.Kutuphane.Seviyeler.SeviyeGrafikleri
{
    partial class Seviye1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seviye1));
            this.pnlArena = new System.Windows.Forms.Panel();
            this.gpctOdunEngeli2 = new TopToplamaOyunu.Kutuphane.Grafikler.GelismisPictureBox();
            this.pnlArena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpctOdunEngeli2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlArena
            // 
            this.pnlArena.BackColor = System.Drawing.Color.Black;
            this.pnlArena.Controls.Add(this.gpctOdunEngeli2);
            this.pnlArena.Location = new System.Drawing.Point(3, 3);
            this.pnlArena.Name = "pnlArena";
            this.pnlArena.Size = new System.Drawing.Size(400, 521);
            this.pnlArena.TabIndex = 1;
            // 
            // gpctOdunEngeli2
            // 
            this.gpctOdunEngeli2.Image = ((System.Drawing.Image)(resources.GetObject("gpctOdunEngeli2.Image")));
            this.gpctOdunEngeli2.Location = new System.Drawing.Point(112, 243);
            this.gpctOdunEngeli2.Name = "gpctOdunEngeli2";
            this.gpctOdunEngeli2.Size = new System.Drawing.Size(166, 26);
            this.gpctOdunEngeli2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gpctOdunEngeli2.TabIndex = 0;
            this.gpctOdunEngeli2.TabStop = false;
            // 
            // Seviye1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlArena);
            this.Name = "Seviye1";
            this.Size = new System.Drawing.Size(402, 525);
            this.pnlArena.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpctOdunEngeli2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArena;
        private Grafikler.GelismisPictureBox gpctOdunEngeli2;
    }
}
