using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TopToplamaOyunu.Kutuphane.Seviyeler.SeviyeGrafikleri
{
    public partial class Seviye7 : UserControl , ISeviyeBilgisi
    {
        private int topSayisi = 5;
        private int topHizi = TopHizlari.HIZ_3;
        public Panel PnlArena 
        { 
            get
            {
                return this.pnlArena;
            }
        }
        public int TopSayisi 
        {
            get
            {
                return this.topSayisi;
            }
        }
        public int TopHizi 
        {
            get
            {
                return this.topHizi;
            }
        }

        public Seviye7()
        {
            InitializeComponent();
        }
    }
}
