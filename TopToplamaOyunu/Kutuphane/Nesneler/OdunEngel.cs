using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TopToplamaOyunu.Kutuphane.Grafikler;

namespace TopToplamaOyunu.Kutuphane.Nesneler
{
    class OdunEngel : OyunNesnesi, IOyunNesnesi
    {
        public OdunEngel(Oyun oyun,GelismisPictureBox pctOdunEngel)
            : base(oyun)
        {
            this.Grafik = pctOdunEngel;                        
        }

        public override void Baslangic() 
        {
            
        }
        public override void Guncelle() 
        {
            
        }
    }
}
