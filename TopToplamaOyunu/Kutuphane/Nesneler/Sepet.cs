using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TopToplamaOyunu.Kutuphane.Grafikler;

namespace TopToplamaOyunu.Kutuphane.Nesneler
{
    public class Sepet : OyunNesnesi, IOyunNesnesi    
    {
        public Sepet(Oyun oyun, GelismisPictureBox gpcbSepet)
            : base(oyun)
        {
            this.Grafik.Image = gpcbSepet.Image;
            this.Genislik = this.Grafik.Image.Width;
            this.Yukseklik = this.Grafik.Image.Height;
            this.X = (this.Oyun.PnlArena.Width / 2) - (this.Genislik / 2);
            this.Y = this.Oyun.PnlArena.Height - this.Yukseklik;
            this.Oyun.PnlArena.Controls.Add(this.Grafik);
        }

        public override void Baslangic() 
        {
            this.SabitNesne = false;
            this.IlerlemeY = 0;
            this.IlerlemeX = 0;
        }
        public override void Guncelle() 
        {            
        }
    }
}
