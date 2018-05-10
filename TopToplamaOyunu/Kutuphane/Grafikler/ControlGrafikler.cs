using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TopToplamaOyunu.Kutuphane.Grafikler
{
    public partial class ControlGrafikler : UserControl
    {
        public Image ImgTop
        {
            set
            {
                this.pctTop.Image = value;
            }
            get
            {
                return this.pctTop.Image;
            }
        }
       

        public ControlGrafikler()
        {
            InitializeComponent();
        }

        private void ControlGrafikler_Load(object sender, EventArgs e)
        {
            
        }
    }
}
