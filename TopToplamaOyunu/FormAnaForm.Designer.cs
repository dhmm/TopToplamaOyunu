namespace TopToplamaOyunu
{
    partial class FormAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaForm));
            this.pnlArena = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblSeviye = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pctSepet = new TopToplamaOyunu.Kutuphane.Grafikler.GelismisPictureBox();
            this.pctTop = new TopToplamaOyunu.Kutuphane.Grafikler.GelismisPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctSepet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTop)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlArena
            // 
            this.pnlArena.BackColor = System.Drawing.Color.Black;
            this.pnlArena.Location = new System.Drawing.Point(12, 12);
            this.pnlArena.Name = "pnlArena";
            this.pnlArena.Size = new System.Drawing.Size(400, 521);
            this.pnlArena.TabIndex = 0;
            this.pnlArena.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlArena_MouseMove);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(418, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Skor";
            // 
            // lblSkor
            // 
            this.lblSkor.BackColor = System.Drawing.Color.White;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblSkor.Location = new System.Drawing.Point(418, 49);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(191, 28);
            this.lblSkor.TabIndex = 7;
            this.lblSkor.Text = "0";
            // 
            // lblSeviye
            // 
            this.lblSeviye.BackColor = System.Drawing.Color.White;
            this.lblSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblSeviye.Location = new System.Drawing.Point(418, 140);
            this.lblSeviye.Name = "lblSeviye";
            this.lblSeviye.Size = new System.Drawing.Size(191, 28);
            this.lblSeviye.TabIndex = 9;
            this.lblSeviye.Text = "0";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(418, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Seviye";
            // 
            // lblCan
            // 
            this.lblCan.BackColor = System.Drawing.Color.White;
            this.lblCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCan.Location = new System.Drawing.Point(418, 225);
            this.lblCan.Name = "lblCan";
            this.lblCan.Size = new System.Drawing.Size(191, 28);
            this.lblCan.TabIndex = 11;
            this.lblCan.Text = "0";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(418, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Can";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(417, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 102);
            this.label1.TabIndex = 12;
            this.label1.Text = "(F2)\r\nYeni Oyun\r\n\r\n(Pause)\r\nDuraklat/Devam ettir";
            // 
            // pctSepet
            // 
            this.pctSepet.Image = ((System.Drawing.Image)(resources.GetObject("pctSepet.Image")));
            this.pctSepet.Location = new System.Drawing.Point(503, 508);
            this.pctSepet.Name = "pctSepet";
            this.pctSepet.Size = new System.Drawing.Size(80, 25);
            this.pctSepet.TabIndex = 4;
            this.pctSepet.TabStop = false;
            this.pctSepet.Visible = false;
            // 
            // pctTop
            // 
            this.pctTop.Image = ((System.Drawing.Image)(resources.GetObject("pctTop.Image")));
            this.pctTop.Location = new System.Drawing.Point(589, 513);
            this.pctTop.Name = "pctTop";
            this.pctTop.Size = new System.Drawing.Size(20, 20);
            this.pctTop.TabIndex = 2;
            this.pctTop.TabStop = false;
            this.pctTop.Visible = false;
            // 
            // FormAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSeviye);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pctSepet);
            this.Controls.Add(this.pctTop);
            this.Controls.Add(this.pnlArena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top Toplama Oyunu v 0.1";
            this.Load += new System.EventHandler(this.FormAnaForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAnaForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctSepet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArena;
        private System.Windows.Forms.Timer timer;
        private Kutuphane.Grafikler.GelismisPictureBox pctTop;
        private Kutuphane.Grafikler.GelismisPictureBox pctSepet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblSeviye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

