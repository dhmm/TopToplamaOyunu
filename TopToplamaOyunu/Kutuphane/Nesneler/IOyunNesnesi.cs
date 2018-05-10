using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TopToplamaOyunu.Kutuphane.Nesneler
{
    public interface IOyunNesnesi
    {        
        int X { set; get; }
        int Y { set; get; }        
        int Genislik { set; get; }
        int Yukseklik { set; get; }
        int AltKenar { get; }
        int SagKenar { get; }
        bool SabitNesne { set; get; }
        void Baslangic();
        void Guncelle();
        void GrafikKaldir();
        void RastgeleXBelirle();
        void ArenayaYerles();
    }
}
