using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using TopToplamaOyunu.Kutuphane.Grafikler;


namespace TopToplamaOyunu.Kutuphane.Nesneler
{
    abstract public class OyunNesnesi
    {        
        public int X 
        {
            set 
            { 
                this.Grafik.Left = value; 
            }
            get 
            { 
                return this.Grafik.Left; 
            }
        }
        public int Y 
        {
            set { this.Grafik.Top = value; }
            get { return this.Grafik.Top; }
        }
        public int Genislik 
        {
            set { this.Grafik.Width = value; }
            get { return this.Grafik.Width; }
        }
        public int Yukseklik
        {
            set { this.Grafik.Height = value; }
            get { return this.Grafik.Height;  }
        }
        public int AltKenar
        {
            get { return this.Y + this.Yukseklik; }
        }
        public int SagKenar
        {
            get { return this.X + this.Genislik; }
        }
        public int IlerlemeX { set; get; }
        public int IlerlemeY { set; get; }
        public bool SabitNesne { set; get; }            

        protected Oyun Oyun { set; get; }         
        protected GelismisPictureBox  Grafik {set;get;}

        public OyunNesnesi(Oyun oyun)
        {
            this.Oyun = oyun;
            this.Grafik = new GelismisPictureBox();
            this.IlerlemeX = 0;
            this.IlerlemeY = 0;
            this.SabitNesne = true;            
        }
        public void GrafikKaldir()
        {
            this.Grafik.Dispose();
        }
        public void RastgeleXBelirle()
        {
            this.X = this.Oyun.R.Next(0, this.Oyun.PnlArena.Width - this.Genislik + 1);
        }
        public void ArenayaYerles()
        {
            this.Oyun.PnlArena.Controls.Add(this.Grafik);
        }
        public abstract void Baslangic();
        public abstract void Guncelle();

        protected void Ilerle()
        {
            if (this.SabitNesne == false)
            {
                this.X += this.IlerlemeX;
                this.Y += this.IlerlemeY;
            }
        }
    }
}
