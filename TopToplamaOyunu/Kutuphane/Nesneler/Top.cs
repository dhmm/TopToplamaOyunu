using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using TopToplamaOyunu.Kutuphane.Grafikler;

namespace TopToplamaOyunu.Kutuphane.Nesneler
{
    public class Top : OyunNesnesi, IOyunNesnesi
    {
        private int XAdim = 2;
        private int YAdim = 5;

        private bool Zipliyor = false;
        private int ZiplamaSayaci = 20;
        

        public Top(Oyun oyun,GelismisPictureBox gpcbTop)
            : base(oyun)
        {
            this.Grafik.Image = gpcbTop.Image;
            this.Genislik = this.Grafik.Image.Width;
            this.Yukseklik = this.Grafik.Image.Height;
            this.X = this.Oyun.R.Next(0, this.Oyun.PnlArena.Width - this.Genislik);            
            this.Y = this.Yukseklik * -1;            
            this.Oyun.PnlArena.Controls.Add(this.Grafik);
            this.SabitNesne = false;
        }

        public override void Baslangic() 
        {
            this.SabitNesne = false;
            this.IlerlemeY = 5;

        }
        public override void Guncelle() 
        {
            this.Ilerle();
            if (this.Oyun.SepeteGirdiMi(this))
            {
                this.Oyun.TopSepeteGirdi(this);
            }
            else
            {
                if (Zipliyor)
                {
                    this.ZiplamaSayaci--;
                    if (ZiplamaSayaci == 0)
                    {
                        this.IlerlemeY = this.YAdim;
                    }
                    else
                    {
                        if (this.Oyun.BaskaNesneyeUsttenCarptiMi(this))
                        {
                            this.IlerlemeY = this.YAdim * -1;
                            ZiplamaSayaci = 20;
                        }
                        else if (this.Oyun.BaskaNesneyeAlttanCarptiMi(this))
                        {
                            this.IlerlemeY = this.YAdim;
                            ZiplamaSayaci = 0;
                        }
                        else if (this.Oyun.BaskaNesneyeSoldanCarptiMi(this) ||
                            this.Oyun.BaskaNesneyeSagdanCarptiMi(this) ||
                            this.Oyun.SagaCarptiMi(this) ||
                            this.Oyun.SolaCarptiMi(this))
                        {
                            this.IlerlemeX *= -1;
                        }
                        else if (this.Oyun.UsteCarptiMi(this))
                        {
                            this.IlerlemeY = this.YAdim;
                            this.ZiplamaSayaci = 0;
                            ZiplamaSayaci = 0;
                        }
                        else if (this.Oyun.AlttanCiktiMi(this))
                        {
                            this.Oyun.TopAltaCarpti(this);
                        }
                    }
                }
                else
                {
                    if (this.Oyun.BaskaNesneyeUsttenCarptiMi(this))
                    {
                        Zipliyor = true;
                        this.IlerlemeY *= -1;
                        this.RandomXILerlemeBelirle();
                    }
                }
            }
        }

        private void RandomXILerlemeBelirle()
        {
            int x = 0;
            x = this.Oyun.R.Next((this.XAdim * -1), (this.XAdim + 1));
            if (x == 0)
            {
                x += this.XAdim;
            }
            this.IlerlemeX += x;  
        }
    }
}
