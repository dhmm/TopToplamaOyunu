using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TopToplamaOyunu.Kutuphane;

namespace TopToplamaOyunu
{
    public partial class FormAnaForm : Form
    {
        Oyun Oyun { set; get; }
        public FormAnaForm()
        {
            InitializeComponent();
        }

        private void FormAnaForm_Load(object sender, EventArgs e)
        {
            Oyun = new Oyun(pnlArena, timer, pctTop,pctSepet);
            Oyun.LabelleriAyarla(lblSkor, lblSeviye,lblCan);            
        }

        private void FormAnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    Oyun.YeniOyun();                    
                    break;     
                case Keys.Pause:
                    Oyun.DuraklatDevamEttir();
                    break;
            }
        }

        private void pnlArena_MouseMove(object sender, MouseEventArgs e)
        {
            this.Oyun.Sepet.X = ( 
                (
                (this.PointToClient(Cursor.Position).X) - pnlArena.Left)
                )
                - 
                (this.Oyun.Sepet.Genislik/ 2);            
        }
    }
}
